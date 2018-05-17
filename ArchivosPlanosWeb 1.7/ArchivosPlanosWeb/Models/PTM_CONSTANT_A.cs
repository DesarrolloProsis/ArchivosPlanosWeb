namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_CONSTANT_A")]
    public partial class PTM_CONSTANT_A
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_CONSTANT_A { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string HEURE_DEBUT_PEAGE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal TOLERANCE_HEURE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal ECART_OK_MONNAIE1 { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal IMPR_AUTO_CP_MONNAIE1 { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal IMPR_AUTO_CP_MONNAIE2 { get; set; }

        public decimal? IMPR_AUTO_CP_DEVISES { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal IMPR_AUTO_CP_VIO { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal IMPR_AUTO_CP_VSC { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal IMPR_AUTO_CP_IAVE { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal IMPR_AUTO_CP_RPI { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal MAX_NATIONALITES { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal MAX_CLASSES { get; set; }

        public decimal? VAT_RATE { get; set; }

        public decimal? ECART_OK_JETON { get; set; }

        public decimal? ECART_OK_RPI { get; set; }

        public decimal? ECART_OK_VSC { get; set; }

        public decimal? ECART_OK_VIO { get; set; }

        public decimal? ECART_OK_MNT_RPI { get; set; }

        public decimal? ECART_OK_MNT_VSC { get; set; }

        public decimal? ECART_OK_MNT_VIO { get; set; }
    }
}
