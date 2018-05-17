namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_EOJ_PRODUCT")]
    public partial class GPOS_EOJ_PRODUCT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_NETWORK { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_PLAZA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ID_SITE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string ID_LANE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string ID_LANE_TYPE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ID_LANE_MODE { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime EOJ_DHM { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(6)]
        public string ID_STAFF { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal JOB_NUMBER { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime BOJ_DHM { get; set; }

        public DateTime? TOD_DHM { get; set; }

        public decimal? BAG_NUMBER { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(2)]
        public string ID_PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(4)]
        public string ID_PRODUCT { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(3)]
        public string CURRENCY_UNIT { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal SALE_COUNTER { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal TOTAL_AMOUNT_SALE { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal REFUND_COUNTER { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal TOTAL_AMOUNT_REFUND { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal RELOAD_COUNTER { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal TOTAL_AMOUNT_RELOAD { get; set; }

        public decimal? VAT_AMOUNT_SALE { get; set; }

        public decimal? VAT_AMOUNT_REFUND { get; set; }

        public decimal? VAT_AMOUNT_RELOAD { get; set; }
    }
}
