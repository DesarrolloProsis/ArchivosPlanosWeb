namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.FIN_POSTE_RECETTE_PAIEMENT")]
    public partial class FIN_POSTE_RECETTE_PAIEMENT
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_CLASSE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_PAIEMENT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string ID_NATIONALITE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string ID_GARE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string ID_VOIE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(3)]
        public string VOIE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(6)]
        public string MATRICULE { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal ID_ETAT_TELEPEAGE { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal ID_MODE_VOIE { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal NUMERO_POSTE { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime DATE_FIN_POSTE { get; set; }

        [StringLength(2)]
        public string ID_DPT { get; set; }

        public decimal? NB_PAIEMENT { get; set; }

        public decimal? RECETTE { get; set; }

        public DateTime? OPERATING_DATE { get; set; }

        public decimal? OPERATING_SHIFT { get; set; }

        public decimal? VALIDATED_DATA_FLAG { get; set; }

        [StringLength(6)]
        public string VALIDATION_STAFF { get; set; }

        public DateTime? VALIDATION_DATE { get; set; }
    }
}
