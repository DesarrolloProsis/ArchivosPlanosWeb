namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_BADGE_CONSIGNE")]
    public partial class TABLE_BADGE_CONSIGNE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_BADGE_CONSIGNE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_CLASSE { get; set; }

        public decimal? CAUTION_TAG_PARTICULIER { get; set; }

        public decimal? CAUTION_CSC_PARTICULIER { get; set; }

        public decimal? CAUTION_TAG_SOCIETE { get; set; }

        public decimal? CAUTION_CSC_SOCIETE { get; set; }
    }
}
