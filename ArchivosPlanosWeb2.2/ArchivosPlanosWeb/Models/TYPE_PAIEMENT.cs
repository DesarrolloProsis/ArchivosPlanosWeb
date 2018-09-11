namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_PAIEMENT")]
    public partial class TYPE_PAIEMENT
    {
        [Key]
        public decimal ID_PAIEMENT { get; set; }

        [StringLength(30)]
        public string LIBELLE_PAIEMENT { get; set; }

        [StringLength(30)]
        public string LIBELLE_PAIEMENT_L2 { get; set; }

        [StringLength(1)]
        public string SEL_OBS_TYPE_PAIEMENT { get; set; }

        [StringLength(1)]
        public string ID_TYPE_MODE_PAIEMENT { get; set; }

        public decimal? PRESENTATION { get; set; }
    }
}
