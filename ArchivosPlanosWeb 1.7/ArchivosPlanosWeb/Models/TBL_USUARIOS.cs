namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TBL_USUARIOS")]
    public partial class TBL_USUARIOS
    {
        public decimal ID { get; set; }

        [StringLength(100)]
        public string USUARIO { get; set; }

        [StringLength(100)]
        public string CLAVE { get; set; }

        public decimal? NIVEL { get; set; }
    }
}
