namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.HOURLY_TRAFFIC_MOP")]
    public partial class HOURLY_TRAFFIC_MOP
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
        public DateTime HOURLY_TRAFFIC_DHM { get; set; }

        public decimal? TRAFFIC_CL1 { get; set; }

        public decimal? TRAFFIC_CL2 { get; set; }

        public decimal? TRAFFIC_CL3 { get; set; }

        public decimal? TRAFFIC_CL4 { get; set; }

        public decimal? TRAFFIC_CL5 { get; set; }

        public decimal? TRAFFIC_CL6 { get; set; }

        public decimal? TRAFFIC_CL7 { get; set; }

        public decimal? TRAFFIC_CL8 { get; set; }

        public decimal? TRAFFIC_CL9 { get; set; }

        public decimal? TRAFFIC_CL10 { get; set; }

        public decimal? TRAFFIC_CL11 { get; set; }

        public decimal? TRAFFIC_CL12 { get; set; }

        public decimal? TRAFFIC_CL13 { get; set; }

        public decimal? TRAFFIC_CL14 { get; set; }

        public decimal? TRAFFIC_CL15 { get; set; }

        public decimal? TRAFFIC_CL16 { get; set; }

        public decimal? TRAFFIC_CL17 { get; set; }

        public decimal? TRAFFIC_CL18 { get; set; }

        public decimal? TRAFFIC_CL19 { get; set; }

        public decimal? TRAFFIC_CL20 { get; set; }

        public decimal? VALIDATED_DATA_FLAG { get; set; }

        public decimal? ID_LANE_MODE { get; set; }
    }
}
