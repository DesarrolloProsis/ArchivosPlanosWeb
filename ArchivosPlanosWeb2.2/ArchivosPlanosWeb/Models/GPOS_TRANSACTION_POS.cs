namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_TRANSACTION_POS")]
    public partial class GPOS_TRANSACTION_POS
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
        [StringLength(3)]
        public string ID_LANE { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime TRX_DHM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string ID_LANE_TYPE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string MSG_TYPE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal ID_LANE_MODE { get; set; }

        [StringLength(6)]
        public string ID_STAFF { get; set; }

        public decimal? JOB_NUMBER { get; set; }

        public DateTime? BOJ_DHM { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal TRX_NUMBER { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal TRX_NUMBER_INDEX { get; set; }

        [Key]
        [Column(Order = 9)]
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

        [StringLength(25)]
        public string MEDIA_TYPE_NAME { get; set; }

        [StringLength(2)]
        public string ID_MEDIA_TYPE { get; set; }

        [StringLength(19)]
        public string ID_MEDIA { get; set; }

        [StringLength(2)]
        public string ID_OLD_MEDIA_TYPE { get; set; }

        [StringLength(19)]
        public string ID_OLD_MEDIA { get; set; }

        [StringLength(3)]
        public string CURRENCY_UNIT { get; set; }

        public decimal? TOTAL_AMOUNT { get; set; }

        public decimal? VAT_AMOUNT { get; set; }

        public decimal? VAT_RATE { get; set; }

        public decimal? PARTIAL_AMOUNT { get; set; }

        public decimal? VAT_AMOUNT_D { get; set; }

        public decimal? VAT_RATE_D { get; set; }

        [StringLength(4)]
        public string MOP_LABEL { get; set; }

        [StringLength(39)]
        public string ISO_MOP_NUMBER { get; set; }

        [StringLength(1)]
        public string ID_MOP_ACQ_TYPE { get; set; }

        [StringLength(2)]
        public string ID_OBS_MOP { get; set; }

        public decimal? ID_MOP { get; set; }

        [StringLength(1)]
        public string ID_OBS_SEQUENCE { get; set; }

        [StringLength(2)]
        public string FLAG_OBS_SEQUENCE { get; set; }

        public decimal? VALIDATED_DATA_FLAG { get; set; }

        [StringLength(6)]
        public string VALIDATION_STAFF { get; set; }

        public DateTime? VALIDATION_DATE { get; set; }
    }
}
