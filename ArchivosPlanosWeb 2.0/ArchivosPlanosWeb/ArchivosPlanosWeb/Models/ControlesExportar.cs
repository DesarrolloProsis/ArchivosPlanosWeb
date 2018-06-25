using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArchivosPlanosWeb.Models
{
    public class ControlesExportar
    {
        public List<SelectListItem> ListDelegaciones { get; set; }

        public string DelegacionesId { get; set; }

        public List<SelectListItem> ListPlazaCobro { get; set; }

        public string PlazaCobroId { get; set; }

        public List<SelectListItem> ListTurno { get; set; }

        public string TurnoId { get; set; }

        public string EncargadoTurno { get; set; }

        public DateTime FechaFin { get; set; }

        public DateTime FechaInicio { get; set; }

        public List<HttpPostedFileBase> files { get; set; }


        //////////////////////////////////////////////////////////////////

        //public IEnumerable<HttpPostedFileBase> Files { get; set; }

        //public Dictionary<string, string> ListaEncriptar { get; set; }

        /////////////////////////////////////////////////////////////////



        //public List<string> ListEncriptar { get; set; }

        //public void SubirArchivos (string ruta, HttpPostedFileBase file)
        //{
        // file.SaveAs(ruta);
        //}


    }
}