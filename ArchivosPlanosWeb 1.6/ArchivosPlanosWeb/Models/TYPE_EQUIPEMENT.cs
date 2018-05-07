namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_EQUIPEMENT")]
    public partial class TYPE_EQUIPEMENT
    {
        [Key]
        public decimal ID_EQUIPEMENT { get; set; }

        [StringLength(8)]
        public string LIBELLE_EQUIPEMENT { get; set; }

        [StringLength(8)]
        public string LIBELLE_EQUIPEMENT_L2 { get; set; }

        [StringLength(30)]
        public string LIBELLE_EQUIPEMENT_LONG { get; set; }

        [StringLength(30)]
        public string LIBELLE_EQUIPEMENT_LONG_L2 { get; set; }
    }
}
