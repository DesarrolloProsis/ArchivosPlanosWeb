namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_MAGNETIQUE")]
    public partial class TABLE_MAGNETIQUE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_MAGNETIQUE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal CODE_MIN { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal CODE_MAX { get; set; }

        [StringLength(40)]
        public string CODE_SERVICE { get; set; }

        [StringLength(4)]
        public string LIBELLE_CARTE { get; set; }

        [StringLength(15)]
        public string LIBELLE_RECU { get; set; }

        [StringLength(1)]
        public string TYPE_CARTE { get; set; }

        public decimal? ORGANISATION { get; set; }

        public decimal? ID_MONNAIE { get; set; }

        public decimal? BILLING_CODE { get; set; }

        public decimal? BANK_CODE { get; set; }
    }
}
