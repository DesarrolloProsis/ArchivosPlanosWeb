namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.COMPTAGE_HORAIRE")]
    public partial class COMPTAGE_HORAIRE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string ID_NATIONALITE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ID_GARE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string ID_VOIE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string VOIE { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime DATE_COMPTAGE_HORAIRE { get; set; }

        public decimal? TRAFIC_CL1 { get; set; }

        public decimal? TRAFIC_CL2 { get; set; }

        public decimal? TRAFIC_CL3 { get; set; }

        public decimal? TRAFIC_CL4 { get; set; }

        public decimal? TRAFIC_CL5 { get; set; }

        public decimal? TRAFIC_CL6 { get; set; }

        public decimal? TRAFIC_CL7 { get; set; }

        public decimal? TRAFIC_CL8 { get; set; }

        public decimal? TRAFIC_CL9 { get; set; }

        public decimal? TRAFIC_CL10 { get; set; }

        public decimal? TRAFIC_CL11 { get; set; }

        public decimal? TRAFIC_CL12 { get; set; }

        public decimal? TRAFIC_CL13 { get; set; }

        public decimal? TRAFIC_CL14 { get; set; }

        public decimal? TRAFIC_CL15 { get; set; }

        public decimal? TRAFIC_CL16 { get; set; }

        public decimal? TRAFIC_CL17 { get; set; }

        public decimal? TRAFIC_CL18 { get; set; }

        public decimal? TRAFIC_CL19 { get; set; }

        public decimal? TRAFIC_CL20 { get; set; }

        public decimal? COMPTAGE_CPT1 { get; set; }

        public decimal? COMPTAGE_CPT2 { get; set; }

        public decimal? COMPTAGE_CPT3 { get; set; }

        public decimal? COMPTAGE_CPT4 { get; set; }

        public decimal? COMPTAGE_CPT5 { get; set; }

        public decimal? PASSAGE_FORCE_EP { get; set; }

        public decimal? PASSAGE_FORCE_HP { get; set; }

        public decimal? PASSAGE_LIBRE { get; set; }

        public decimal? TEMPS_OUVERTURE { get; set; }
    }
}
