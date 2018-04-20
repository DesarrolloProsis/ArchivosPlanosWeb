namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.CORRECTED_TRANSACTION")]
    public partial class CORRECTED_TRANSACTION
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
        [StringLength(1)]
        public string ID_LANE_TYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string ID_LANE { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime TRX_DHM { get; set; }

        public decimal? ID_ETC_STATUS { get; set; }

        public decimal? ID_LANE_MODE { get; set; }

        [StringLength(6)]
        public string ID_STAFF { get; set; }

        public decimal? JOB_NUMBER { get; set; }

        public DateTime? BOJ_DHM { get; set; }

        public decimal? TRX_NUMBER { get; set; }

        public decimal? TRX_NUMBER_INDEX { get; set; }

        public decimal? ID_TAB_CLASS { get; set; }

        [StringLength(2)]
        public string ID_TAB_PLAZA { get; set; }

        [StringLength(2)]
        public string ID_TT_NETWORK { get; set; }

        [StringLength(2)]
        public string ID_TT_PLAZA { get; set; }

        [StringLength(3)]
        public string ID_TT_LANE { get; set; }

        [StringLength(14)]
        public string TT_DHM { get; set; }

        public decimal? ID_TT_TYPE { get; set; }

        public decimal? TT_NUMBER { get; set; }

        [StringLength(1)]
        public string ID_OBS_TT { get; set; }

        [StringLength(2)]
        public string ID_OBS_MOP { get; set; }

        [StringLength(1)]
        public string ID_OBS_SEQUENCE { get; set; }

        [StringLength(1)]
        public string ID_OBS_PASSAGE { get; set; }

        [StringLength(1)]
        public string FARE_MODULATION_CODE { get; set; }

        public decimal? FARE_TABLE_VERSION { get; set; }

        public decimal? TOLL_FARE { get; set; }

        public decimal? AMOUNT_PAID { get; set; }

        [StringLength(4)]
        public string MOP_LABEL { get; set; }

        [StringLength(39)]
        public string ISO_MOP_NUMBER { get; set; }

        public decimal? ID_MOP { get; set; }

        public decimal? ID_AVC_CLASS { get; set; }

        public decimal? ID_CORRECTED_CLASS { get; set; }

        [StringLength(2)]
        public string ID_CORRECTED_PLAZA { get; set; }

        public decimal? ID_CORRECTED_MOP { get; set; }

        public decimal? ID_CORRECTED_TOLL_FARE { get; set; }

        [StringLength(6)]
        public string ID_CORRECTOR_STAFF { get; set; }

        public DateTime? CORRECTION_DHM { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string ID_TYPE_CORRECTION { get; set; }

        public DateTime? OPERATING_DATE { get; set; }

        [StringLength(10)]
        public string RECEIPT_NUMBER { get; set; }

        [StringLength(3)]
        public string MODULATION_VERSION { get; set; }

        public DateTime? EOJ_DHM { get; set; }

        public decimal? ID_TAB_AXLE { get; set; }

        public decimal? ID_AVC_AXLE { get; set; }

        public decimal? ID_CORRECTED_AXLE { get; set; }

        public decimal? EVENT_NUMBER { get; set; }
    }
}
