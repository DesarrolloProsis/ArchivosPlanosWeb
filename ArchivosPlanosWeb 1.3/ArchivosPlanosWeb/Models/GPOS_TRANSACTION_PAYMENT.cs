namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_TRANSACTION_PAYMENT")]
    public partial class GPOS_TRANSACTION_PAYMENT
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

        [StringLength(3)]
        public string CURRENCY_UNIT { get; set; }

        public decimal? TOTAL_AMOUNT { get; set; }

        public decimal? VAT_AMOUNT { get; set; }

        public decimal? VAT_RATE { get; set; }

        public decimal? PARTIAL_AMOUNT { get; set; }

        public decimal? VAT_AMOUNT_P { get; set; }

        public decimal? VAT_RATE_P { get; set; }

        [StringLength(4)]
        public string MOP_LABEL { get; set; }

        [StringLength(39)]
        public string ISO_MOP_NUMBER { get; set; }

        [StringLength(1)]
        public string ID_MOP_ACQ_TYPE { get; set; }

        [StringLength(2)]
        public string ID_OBS_MOP { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal ID_MOP { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(1)]
        public string ID_OBS_SEQUENCE { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(2)]
        public string FLAG_OBS_SEQUENCE { get; set; }

        public decimal? ID_LANE_MODE { get; set; }
    }
}
