using ArchivosPlanosWeb.Models;
using ArchivosPlanosWeb.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;
using System.Data;
using Ionic.Zip;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArchivosPlanosWeb.Controllers
{
    public class ExportarController : Controller 
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private object SubirArchivo;

        public object Paht { get; private set; }
        //public object Files { get; private set; }
        public object MapPath { get; private set; }
        public object SubirArchivoModelo { get; private set; }
        public object SubirArchivosMdel { get; private set; }
        public static List<filas> listaaa { get; set; }
        public static List<string> comen { get; set; }

        public static bool entra = false;

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
            //entra = false;
            comen = model.Comentario;
            if(comen == null)
            {
                entra = false;
            }
            ValidacionesRepository validaciones = new ValidacionesRepository();
            Archivo2ARepository archivo2A = new Archivo2ARepository();
            Archivo1ARepository archivo1A = new Archivo1ARepository();
            Archivo9ARepository archivo9A = new Archivo9ARepository();
            ArchivoIIRepository archivoII = new ArchivoIIRepository();
            ArchivoPARepository archivoPA = new ArchivoPARepository();
            EncriptarRepository encriptar = new EncriptarRepository();
            ComprimirRepository comprimir = new ComprimirRepository();
            Encriptar2 encriptar2 = new Encriptar2();
            Comprimir2 comprimir2 = new Comprimir2();
            DateTime fecha_Actual = DateTime.Today;
            
   
            var DataStrDele = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(GetDelegaciones().Data); // convert json object to string.
            model.ListDelegaciones = JsonConvert.DeserializeObject<List<SelectListItem>>(DataStrDele);

            var DataStrPlaza = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(GetPlazaCobro().Data); // convert json object to string.
            model.ListPlazaCobro = JsonConvert.DeserializeObject<List<SelectListItem>>(DataStrPlaza);

            var DataStrTurno = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(GetTurnos().Data); // convert json object to string.
            model.ListTurno = JsonConvert.DeserializeObject<List<SelectListItem>>(DataStrTurno);

            var  Delegacion = model.ListDelegaciones.Find(x => x.Value == model.DelegacionesId);
            var Plaza = model.ListPlazaCobro.Find(p => p.Value == model.PlazaCobroId);
            var Turno = model.ListTurno.Find(p => p.Value == model.TurnoId);
            DateTime FechaInicio = model.FechaInicio;
            

            try
            {
                if (entra == true && comen.ToString() != null)
                {
                    
                    entra = false;
                     if (validaciones.Isertar_Comentarios(listaaa, comen) == "OK")
                     {
                        Response.Write("<script>alert('" + "Si Jala" + "');</script>");
                        return View();
                     }
                }

                if (Delegacion == null)
                    Response.Write("<script>alert('" + "Falta Delegaciones" + "');</script>");
                else if (Plaza == null)
                    Response.Write("<script>alert('" + "Falta Plaza" + "');</script>");
                else if (Turno == null)
                    Response.Write("<script>alert('" + "Falta Turno" + "');</script>");
                else if (FechaInicio.ToString() == "01/01/0001 12:00:00 a. m.")
                    Response.Write("<script>alert('" + "Falta Fecha" + "');</script>");
                else if(FechaInicio > fecha_Actual)
                    Response.Write("<script>alert('" + "La fecha debe ser menor al dia actual" + "');</script>");
                else
                listaaa = validaciones.ValidarComentarios(FechaInicio.AddDays(-1), FechaInicio, Turno.Text);

                if(listaaa.Count == 1)
                {

                    ViewBag.List = new List<filas>();
                    ViewBag.List = listaaa;
                    entra = true;
                    Response.Write("<script>alert('" + validaciones.Message + "');</script>");
                    return View(ViewBag.List, model);

                }
                else if (validaciones.ValidarCarrilesCerrados(FechaInicio.AddDays(-1), FechaInicio, Turno.Text) == "STOP")
                    Response.Write("<script>alert('" + validaciones.Message + "');</script>");
                else if (validaciones.ValidarBolsas(FechaInicio.AddDays(-1), FechaInicio, Turno.Text) == "STOP")
                    Response.Write("<script>alert('" + validaciones.Message + "');</script>");

                else

                {

                    //"01" SE DEBE ALMACENAR DE ACUERDO AL INICION DE SESIÓN 
                    archivo1A.Generar_Bitacora_Operacion(Turno.Text, FechaInicio, Convert.ToString("1" + Plaza.Value), Convert.ToString(Delegacion.Value), "01");
                    archivo2A.Preliquidaciones_de_cajero_receptor_para_transito_vehicular(Turno.Text, FechaInicio, Convert.ToString("1" + Plaza.Value), Convert.ToString(Delegacion.Value), "01");
                    archivo9A.eventos_detectados_y_marcados_en_el_ECT(Turno.Text, FechaInicio, Convert.ToString("1" + Plaza.Value), Convert.ToString(Delegacion.Value), "01");
                    archivoII.Registro_usuarios_telepeaje(Turno.Text, FechaInicio, Convert.ToString("1" + Plaza.Value), Convert.ToString(Delegacion.Value), "01");
                    archivoPA.eventos_detectados_y_marcados_en_el_ECT_EAP(Turno.Text, FechaInicio, Convert.ToString("1" + Plaza.Value), Convert.ToString(Delegacion.Value), "01");
                    encriptar2.EncriptarArchivos(FechaInicio, Turno.Text, Convert.ToString("1" + Plaza.Value), archivo1A.Archivo_1, archivo2A.Archivo_2, archivo9A.Archivo_3, archivoPA.Archivo_4, archivoII.Archivo_5, Plaza.Text);
                    encriptar.EncriptarArchivos(FechaInicio, Turno.Text, Convert.ToString("1" + Plaza.Value), archivo1A.Archivo_1, archivo2A.Archivo_2, archivo9A.Archivo_3, archivoPA.Archivo_4, archivoII.Archivo_5, Plaza.Text);
                    comprimir.ComprimirArchivos(FechaInicio, Turno.Text, Convert.ToString("1" + Plaza.Value), archivo1A.Archivo_1, archivo2A.Archivo_2, archivo9A.Archivo_3, archivoPA.Archivo_4, archivoII.Archivo_5, Plaza.Text);
                    comprimir2.ComprimirArchivos(FechaInicio, Turno.Text, Convert.ToString("1" + Plaza.Value), archivo1A.Archivo_1, archivo2A.Archivo_2, archivo9A.Archivo_3, archivoPA.Archivo_4, archivoII.Archivo_5, Plaza.Text);
                    Response.Write("<script>alert('Archivo 1A: " + archivo1A.Message + "\\nArchivo 2A: " + archivo2A.Message + "\\nArchivo 9A: " + archivo9A.Message + "\\nArchivo LL: " + archivoII.Message + "\\nArchivo PA: " + archivoPA.Message + "\\nEncriptación: " + encriptar.Message + "\\nCompresión: " + comprimir.Message + "');</script>");



                }

            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert('" + "TIenes que agregar datos" + "');</script>");
            }

            if (comprimir2.Nombre1 == null && comprimir2.Nombre1 == null)
            {
                return View();
                //return Descargar(comprimir2.Nombre1, comprimir2.Nombre2);
            }
            else
            {

                //Response.Write("<script>alert('" + "TIenes que agregar datos" + "');</script>");
                //return View();
                Response.Write("<script>alert('Archivo 1A: " + archivo1A.Message + "\\nArchivo 2A: " + archivo2A.Message + "\\nArchivo 9A: " + archivo9A.Message + "\\nArchivo LL: " + archivoII.Message + "\\nArchivo PA: " + archivoPA.Message + "\\nEncriptación: " + encriptar.Message + "\\nCompresión: " + comprimir.Message + "');</script>");
                return Descargar(comprimir2.Nombre1, comprimir2.Nombre2);
            }

          
            //return Descargar(comprimir2.Nombre1, comprimir2.Nombre2);
            //return View();
        }


        //JSON RESULT PARA LLENAR CON AJAX LAS DELEGACIONES
        [HttpGet]
        public JsonResult GetDelegaciones()
        {

            string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            string query = string.Empty;
            query = @"SELECT idTramo,nomTramo FROM TYPE_TRAMO";
            List<SelectListItem> Items = new List<SelectListItem>();
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            SelectListItem listItem = new SelectListItem();
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);
            

            foreach (DataRow indi in dataTable.Rows)
            {
              
                if (indi["nomTramo"].ToString() == "Mexico-Acapulco")
                {

                    Items.Add(new SelectListItem
                    {
                        Text = "Delegación IV Cuernavaca",
                        Value = "04"
                    });
                    //Items.Add(new SelectListItem
                    //{
                    //    Text = "Delegación III Queretaro",
                    //    Value = "03"
                    //});

                }
            }

            return Json(Items, JsonRequestBehavior.AllowGet);
     
        }

        //JSON RESULT PARA LLENAR CON AJAX LAS PLAZAS DE COBRO
        [HttpGet]
        public JsonResult GetPlazaCobro()
        {
            string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnection"].ConnectionString;
            SqlConnection Connection = new SqlConnection(ConnectionString);
            Connection.Open();
            string query = string.Empty;
            query = @"SELECT idPlaza,nomPlaza FROM TYPE_PLAZA";
            List<SelectListItem> Items = new List<SelectListItem>();
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            SelectListItem listItem = new SelectListItem();
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            foreach (DataRow indi in dataTable.Rows)
            {
                Items.Add(new SelectListItem
                {
                    Text = indi["idPlaza"].ToString() + " " + indi["nomPlaza"].ToString(),
                    Value = indi["idPlaza"].ToString()
                });
            }

            //Items.Add(new SelectListItem
            //{
            //    Value = "08",
            //    Text = "Tlalpan"
            //});

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


        public ActionResult Encriptar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Encriptar(List<HttpPostedFileBase> file)
        {
            List<HttpPostedFileBase> lista = new List<HttpPostedFileBase>();
            if (file != null)
            {

                foreach (var indi in file)
                {
                    lista.Add(indi);
                }

            }
            string ruta = Server.MapPath("~/Temp/");

            if (lista.Count == 5)
            {

                ReEncriptarRepository ce = new ReEncriptarRepository();
                ce.SeleccionarArchivos(lista, ruta);
                Response.Write("<script>alert('" + ce.Message + "C:ARCHIVOSPLANOS2\" " + "');</script>");


            }
            else

            {
                Response.Write("<script>alert('Faltan Archivos compruebe que sean 5');</script>");
            }




            return View();
        }


        public FileResult Descargar(string nombre1, string nombre2)
        {
            Comprimir2 comprimir = new Comprimir2();
          
            using (ZipFile zip = new ZipFile())
            {
                
                //C:\Users\Desarrollo3\Desktop\ArchivosPlanosWebModel\ArchivosPlanosWeb\Descargas\Tlalpan\2017\junio\22
                //000106222017.Z4A

                //C:\Users\Desarrollo3\Desktop\ArchivosPlanosWebModel\ArchivosPlanosWeb\Descargas\Tlalpan\2017\junio\22\SinEncriptar
                //00010622.Z4A


                var archivo1 = Server.MapPath("~/Descargas/" + "\\" + "SinEncriptar\\" + nombre1);
                var archivo2 = Server.MapPath("~/Descargas/" + nombre2);
                //var archivo1 = "C:\\inetpub\\wwwroot\\ArchivosPlanos\\Descargas" + "\\" + "SinEncriptar\\" + nombre1;
                //var archivo2 = "C:\\inetpub\\wwwroot\\ArchivosPlanos\\Descargas" + "\\" + nombre2;


                var archivo1_nombre = Path.GetFileName(archivo1);
                var archivo1_arreglo = System.IO.File.ReadAllBytes(archivo1);

                var archivo2_nombre = Path.GetFileName(archivo2);
                var archivo2_arreglo = System.IO.File.ReadAllBytes(archivo2);

                zip.AddEntry(archivo1_nombre, archivo1_arreglo);
                zip.AddEntry(archivo2_nombre, archivo2_arreglo);

                var nombredelZIp = "MIZIP.zip";


                

                using (MemoryStream output = new MemoryStream())
                {
                    zip.Save(output);
                    comprimir.EliminarZip(archivo1,archivo2);
                    Response.Write("<script>alert('" + "Todos los archivos OK" + "');</script>");
                    return File(output.ToArray(), "application/ZIP", nombredelZIp);
                }

               
            }

          
        }

       
    }

   


}