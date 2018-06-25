namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.FIN_POSTE_TRAFIC")]
    public partial class FIN_POSTE_TRAFIC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_GARE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string ID_VOIE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string VOIE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string MATRICULE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ID_ETAT_TELEPEAGE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal ID_MODE_VOIE { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal NUMERO_POSTE { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime DATE_FIN_POSTE { get; set; }

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

        public DateTime? OPERATING_DATE { get; set; }

        public decimal? OPERATING_SHIFT { get; set; }

        public decimal? VALIDATED_DATA_FLAG { get; set; }

        [StringLength(6)]
        public string VALIDATION_STAFF { get; set; }

        public DateTime? VALIDATION_DATE { get; set; }
    }
}
