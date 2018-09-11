namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.HOURLY_REVENUE_MOP")]
    public partial class HOURLY_REVENUE_MOP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string BILLING_CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_NETWORK { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ID_PLAZA { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string ID_LANE_TYPE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string ID_LANE { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime HOURLY_REVENUE_DHM { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string ID_NATIONALITY { get; set; }

        public decimal? REVENUE_CL1 { get; set; }

        public decimal? REVENUE_CL2 { get; set; }

        public decimal? REVENUE_CL3 { get; set; }

        public decimal? REVENUE_CL4 { get; set; }

        public decimal? REVENUE_CL5 { get; set; }

        public decimal? REVENUE_CL6 { get; set; }

        public decimal? REVENUE_CL7 { get; set; }

        public decimal? REVENUE_CL8 { get; set; }

        public decimal? REVENUE_CL9 { get; set; }

        public decimal? REVENUE_CL10 { get; set; }

        public decimal? REVENUE_CL11 { get; set; }

        public decimal? REVENUE_CL12 { get; set; }

        public decimal? REVENUE_CL13 { get; set; }

        public decimal? REVENUE_CL14 { get; set; }

        public decimal? REVENUE_CL15 { get; set; }

        public decimal? REVENUE_CL16 { get; set; }

        public decimal? REVENUE_CL17 { get; set; }

        public decimal? REVENUE_CL18 { get; set; }

        public decimal? REVENUE_CL19 { get; set; }

        public decimal? REVENUE_CL20 { get; set; }

        public decimal? VALIDATED_DATA_FLAG { get; set; }

        public decimal? ID_LANE_MODE { get; set; }
    }
}
