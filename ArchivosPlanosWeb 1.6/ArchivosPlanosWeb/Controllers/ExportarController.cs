using ArchivosPlanosWeb.Models;
using ArchivosPlanosWeb.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArchivosPlanosWeb.Controllers
{
    public class ExportarController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Exportar
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // POST : Exportar
        [HttpPost]
        public ActionResult Index(ControlesExportar model)
        {
            ValidacionesRepository validaciones = new ValidacionesRepository();
            Archivo1ARepository archivo1A = new Archivo1ARepository();
            Archivo2ARepository archivo2A = new Archivo2ARepository();
            Archivo9ARepository archivo9A = new Archivo9ARepository();
            ArchivoIIRepository archivoII = new ArchivoIIRepository();
            ArchivoPARepository archivoPA = new ArchivoPARepository();
            EncriptarRepository encriptar = new EncriptarRepository();
            ComprimirRepository comprimir = new ComprimirRepository();

            var DataStrDele = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(GetDelegaciones().Data); // convert json object to string.
            model.ListDelegaciones = JsonConvert.DeserializeObject<List<SelectListItem>>(DataStrDele);

            var DataStrPlaza = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(GetPlazaCobro().Data); // convert json object to string.
            model.ListPlazaCobro = JsonConvert.DeserializeObject<List<SelectListItem>>(DataStrPlaza);

            var DataStrTurno = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(GetTurnos().Data); // convert json object to string.
            model.ListTurno = JsonConvert.DeserializeObject<List<SelectListItem>>(DataStrTurno);

            var Delegacion = model.ListDelegaciones.Find(x => x.Value == model.DelegacionesId);
            var Plaza = model.ListPlazaCobro.Find(p => p.Value == model.PlazaCobroId);
            var Turno = model.ListTurno.Find(p => p.Value == model.TurnoId);
            DateTime FechaInicio = model.FechaInicio;

            if (validaciones.ValidarCarrilesCerrados(FechaInicio.AddDays(-1), FechaInicio, Turno.Text) == "STOP")
                Response.Write("<script>alert('" + validaciones.Message + "');</script>");
            else if (validaciones.ValidarBolsas(FechaInicio.AddDays(-1), FechaInicio, Turno.Text) == "STOP")
                Response.Write("<script>alert('" + validaciones.Message + "');</script>");
            else if (validaciones.ValidarComentarios(FechaInicio.AddDays(-1), FechaInicio, Turno.Text) == "STOP")
                Response.Write("<script>alert('" + validaciones.Message + "');</script>");
            else
            {

                //"01" SE DEBE ALMACENAR DE ACUERDO AL INIION DE SESIÓN 
                archivo1A.Generar_Bitacora_Operacion(Turno.Text, FechaInicio, Convert.ToString("1" + Plaza.Value), Convert.ToString(Delegacion.Value), "01");
                archivo2A.Preliquidaciones_de_cajero_receptor_para_transito_vehicular(Turno.Text, FechaInicio, Convert.ToString("1" + Plaza.Value), Convert.ToString(Delegacion.Value), "01");
                archivo9A.eventos_detectados_y_marcados_en_el_ECT(Turno.Text, FechaInicio, Convert.ToString("1" + Plaza.Value), Convert.ToString(Delegacion.Value), "01");
                archivoII.Registro_usuarios_telepeaje(Turno.Text, FechaInicio, Convert.ToString("1" + Plaza.Value), Convert.ToString(Delegacion.Value), "01");
                archivoPA.eventos_detectados_y_marcados_en_el_ECT_EAP(Turno.Text, FechaInicio, Convert.ToString("1" + Plaza.Value), Convert.ToString(Delegacion.Value), "01");
                encriptar.EncriptarArchivos(FechaInicio, Turno.Text, Convert.ToString("1" + Plaza.Value), archivo1A.Archivo_1, archivo2A.Archivo_2, archivo9A.Archivo_3, archivoPA.Archivo_4, archivoII.Archivo_5);
                comprimir.ComprimirArchivos(FechaInicio, Turno.Text, Convert.ToString("1" + Plaza.Value), archivo1A.Archivo_1, archivo2A.Archivo_2, archivo9A.Archivo_3, archivoPA.Archivo_4, archivoII.Archivo_5);

                Response.Write("<script>alert('Archivo 1A: " + archivo1A.Message + "\\nArchivo 2A: " + archivo2A.Message + "\\nArchivo 9A: " + archivo9A.Message +
                                "\\nArchivo LL: " + archivoII.Message + "\\nArchivo PA: " + archivoPA.Message + "\\nEncriptación: " + encriptar.Message + "\\nCompresión: " + comprimir.Message + "');</script>");

            }

            return View(model);
        }

        //JSON RESULT PARA LLENAR CON AJAX LAS DELEGACIONES
        [HttpGet]
        public JsonResult GetDelegaciones()
        {
            List<SelectListItem> Items = new List<SelectListItem>();
            var Query = db.Database.SqlQuery<TYPE_RESEAU>(@"SELECT ID_RESEAU, NOM_RESEAU, NOM_RESEAU_L2 FROM TYPE_RESEAU").ToArray();

            if (Query.Count() > 0)
            {
                foreach (var value in Query)
                {
                    if (value.NOM_RESEAU.ToString() == "Autopista Mexico Acapulco")
                    {
                        Items.Add(new SelectListItem
                        {
                            Text = "Delegación III Queretaro",
                            Value = "03"
                        });
                        Items.Add(new SelectListItem
                        {
                            Text = "Delegación IV Cuernavaca",
                            Value = "04"
                        });
                    }
                }
            }

            return Json(Items, JsonRequestBehavior.AllowGet);
        }

        //JSON RESULT PARA LLENAR CON AJAX LAS PLAZAS DE COBRO
        [HttpGet]
        public JsonResult GetPlazaCobro()
        {
            List<SelectListItem> Items = new List<SelectListItem>();
            var Query = db.Database.SqlQuery<TYPE_SITE>(@"SELECT ID_SITE, NOM_SITE, NOM_SITE_L2, ID_SITE ||' '|| NOM_SITE as PlazaCobro FROM TYPE_SITE ORDER BY NOM_SITE").ToArray();

            if (Query.Count() > 0)
            {
                foreach (var value in Query)
                {
                    Items.Add(new SelectListItem
                    {
                        Value = value.ID_SITE,
                        Text = value.ID_SITE + " " + value.NOM_SITE
                    });
                }
            }
            return Json(Items, JsonRequestBehavior.AllowGet);
        }

        //JSON RESULT PARA LLENAR CON AJAX LOS TURNO
        [HttpGet]
        public JsonResult GetTurnos()
        {
            List<SelectListItem> Items = new List<SelectListItem>();

            Items.Add(new SelectListItem
            {
                Text = "22:00 - 06:00",
                Value = "1"
            });

            Items.Add(new SelectListItem
            {
                Text = "06:00 - 14:00",
                Value = "2"
            });

            Items.Add(new SelectListItem
            {
                Text = "14:00 - 22:00",
                Value = "3"
            });

            return Json(Items, JsonRequestBehavior.AllowGet);
        }
    }
}