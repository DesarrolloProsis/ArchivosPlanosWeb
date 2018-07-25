namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_TRANSACTION")]
    public partial class GPOS_TRANSACTION
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
        [StringLength(30)]
        public string PLAZA_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string ID_LANE { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime TRX_DHM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string ID_LANE_TYPE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(6)]
        public string ID_STAFF { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal JOB_NUMBER { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(14)]
        public string BOJ_DHM { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal TRX_NUMBER { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal TRX_NUMBER_INDEX { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(2)]
        public string ID_TRX { get; set; }

        [StringLength(12)]
        public string ID_CUSTOMER { get; set; }

        [StringLength(12)]
        public string ID_SUBSCRIPTION { get; set; }

        [StringLength(2)]
        public string ID_PRODUCT_TYPE { get; set; }

        [StringLength(4)]
        public string ID_PRODUCT { get; set; }

        [StringLength(25)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(2)]
        public string ID_CLASS { get; set; }

        [StringLength(19)]
        public string ID_MEDIA { get; set; }

        [StringLength(3)]
        public string CURRENCY_UNIT { get; set; }

        public decimal? TOTAL_AMOUNT { get; set; }

        public decimal? VAT_AMOUNT { get; set; }

        public decimal? VAT_RATE { get; set; }

        public decimal? DEPOSIT { get; set; }

        public decimal? VAT_AMOUNT_D { get; set; }

        public decimal? VAT_RATE_D { get; set; }

        [StringLength(2)]
        public string ID_OBS_TRX { get; set; }

        public decimal? ID_LANE_MODE { get; set; }
    }
}
