namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_LIBELLE_EVENEMENT")]
    public partial class TYPE_LIBELLE_EVENEMENT
    {
        [Key]
        public decimal ID_LIBELLE_EVENEMENT { get; set; }

        [StringLength(30)]
        public string LIBELLE_EVENEMENT_LONG { get; set; }

        [StringLength(10)]
        public string LIBELLE_EVENEMENT_COURT_L2 { get; set; }

        [StringLength(10)]
        public string LIBELLE_EVENEMENT_COURT { get; set; }

        [StringLength(30)]
        public string LIBELLE_EVENEMENT_LONG_L2 { get; set; }
    }
}
