namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.REDDITION_PIECE")]
    public partial class REDDITION_PIECE
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_MONNAIE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_SITE { get; set; }

        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string MATRICULE { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DATE_REDDITION { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(8)]
        public string SAC { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string LIBELLE_PIECE { get; set; }

        public decimal? MONTANT { get; set; }

        public decimal? NBR_PIECE { get; set; }

        public decimal? SAC_PARTIELLE { get; set; }

        public DateTime? DATE_RED_PARTIELLE { get; set; }

        [StringLength(1)]
        public string CONSOLIDATION_FLAG { get; set; }

        public decimal? SOUS_TYPE_MP { get; set; }

        public DateTime? DATE_VERSEMENT_BANQUE { get; set; }

        [StringLength(20)]
        public string BANK_SLIP_NUMBER { get; set; }
    }
}
