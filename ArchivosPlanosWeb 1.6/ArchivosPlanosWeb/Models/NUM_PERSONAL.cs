namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.NUM_PERSONAL")]
    public partial class NUM_PERSONAL
    {
        [Key]
        public decimal ID_NUM_PERSONAL { get; set; }

        [StringLength(6)]
        public string MATRICULE { get; set; }

        [StringLength(10)]
        public string NUM_CAPUFE { get; set; }
    }
}
