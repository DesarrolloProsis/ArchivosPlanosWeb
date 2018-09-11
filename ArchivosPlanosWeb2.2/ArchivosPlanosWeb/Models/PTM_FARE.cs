namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_FARE")]
    public partial class PTM_FARE
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_MOP { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_TARIF { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string ID_NATIONALITE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal ID_GARE { get; set; }

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
