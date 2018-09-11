namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_BADGE_BALANCE")]
    public partial class TABLE_BADGE_BALANCE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_BADGE_BALANCE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string TYPE_BALANCE { get; set; }

        public decimal? VALEUR_BALANCE { get; set; }

        public decimal? VALEUR_PRIX { get; set; }
    }
}
