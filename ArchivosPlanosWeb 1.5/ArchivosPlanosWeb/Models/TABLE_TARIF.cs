namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_TARIF")]
    public partial class TABLE_TARIF
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_MONNAIE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_TARIF { get; set; }

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
        [StringLength(2)]
        public string ID_RESEAU_ENTREE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string ID_GARE_ENTREE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string ID_PERIODE_TARIFAIRE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1)]
        public string TYPE_CODE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(2)]
        public string CODE { get; set; }

        public decimal? PRIX_CL01 { get; set; }

        public decimal? PRIX_CL02 { get; set; }

        public decimal? PRIX_CL03 { get; set; }

        public decimal? PRIX_CL04 { get; set; }

        public decimal? PRIX_CL05 { get; set; }

        public decimal? PRIX_CL06 { get; set; }

        public decimal? PRIX_CL07 { get; set; }

        public decimal? PRIX_CL08 { get; set; }

        public decimal? PRIX_CL09 { get; set; }

        public decimal? PRIX_CL10 { get; set; }

        public decimal? PRIX_CL11 { get; set; }

        public decimal? PRIX_CL12 { get; set; }

        public decimal? PRIX_CL13 { get; set; }

        public decimal? PRIX_CL14 { get; set; }

        public decimal? PRIX_CL15 { get; set; }

        public decimal? PRIX_CL16 { get; set; }

        public decimal? PRIX_CL17 { get; set; }

        public decimal? PRIX_CL18 { get; set; }

        public decimal? PRIX_CL19 { get; set; }

        public decimal? PRIX_CL20 { get; set; }

        public decimal? TVA_CL01 { get; set; }

        public decimal? TVA_CL02 { get; set; }

        public decimal? TVA_CL03 { get; set; }

        public decimal? TVA_CL04 { get; set; }

        public decimal? TVA_CL05 { get; set; }

        public decimal? TVA_CL06 { get; set; }

        public decimal? TVA_CL07 { get; set; }

        public decimal? TVA_CL08 { get; set; }

        public decimal? TVA_CL09 { get; set; }

        public decimal? TVA_CL10 { get; set; }

        public decimal? TVA_CL11 { get; set; }

        public decimal? TVA_CL12 { get; set; }

        public decimal? TVA_CL13 { get; set; }

        public decimal? TVA_CL14 { get; set; }

        public decimal? TVA_CL15 { get; set; }

        public decimal? TVA_CL16 { get; set; }

        public decimal? TVA_CL17 { get; set; }

        public decimal? TVA_CL18 { get; set; }

        public decimal? TVA_CL19 { get; set; }

        public decimal? TVA_CL20 { get; set; }

        public decimal? TAX_FREE_CL01 { get; set; }

        public decimal? TAX_FREE_CL02 { get; set; }

        public decimal? TAX_FREE_CL03 { get; set; }

        public decimal? TAX_FREE_CL04 { get; set; }

        public decimal? TAX_FREE_CL05 { get; set; }

        public decimal? TAX_FREE_CL06 { get; set; }

        public decimal? TAX_FREE_CL07 { get; set; }

        public decimal? TAX_FREE_CL08 { get; set; }

        public decimal? TAX_FREE_CL09 { get; set; }

        public decimal? TAX_FREE_CL10 { get; set; }

        public decimal? TAX_FREE_CL11 { get; set; }

        public decimal? TAX_FREE_CL12 { get; set; }

        public decimal? TAX_FREE_CL13 { get; set; }

        public decimal? TAX_FREE_CL14 { get; set; }

        public decimal? TAX_FREE_CL15 { get; set; }

        public decimal? TAX_FREE_CL16 { get; set; }

        public decimal? TAX_FREE_CL17 { get; set; }

        public decimal? TAX_FREE_CL18 { get; set; }

        public decimal? TAX_FREE_CL19 { get; set; }

        public decimal? TAX_FREE_CL20 { get; set; }
    }
}
