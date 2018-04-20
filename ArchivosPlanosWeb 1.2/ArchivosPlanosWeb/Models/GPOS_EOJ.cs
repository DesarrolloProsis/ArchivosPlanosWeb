namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_EOJ")]
    public partial class GPOS_EOJ
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

        public decimal? CURRENCY_VERSION { get; set; }

        public DateTime? TOD_DHM { get; set; }

        public decimal? BAG_NUMBER { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal CREATED_CUSTOMER_COUNTER { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal MODIFIED_CUSTOMER_COUNTER { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal CLOSED_CUSTOMER_COUNTER { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal REPLACED_MEDIA_COUNTER { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal BLACKLIST_MEDIA_COUNTER { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal UNBLACKLIST_MEDIA_COUNTER { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal INVALIDATED_MEDIA_COUNTER { get; set; }

        public decimal? VALIDATED_DATA_FLAG { get; set; }

        [StringLength(6)]
        public string VALIDATION_STAFF { get; set; }

        public DateTime? VALIDATION_DATE { get; set; }

        public DateTime? OPERATING_DATE { get; set; }

        public decimal? EOJ_COUNTER1 { get; set; }

        public decimal? EOJ_COUNTER2 { get; set; }

        public decimal? EOJ_COUNTER3 { get; set; }

        public decimal? EOJ_COUNTER4 { get; set; }

        public decimal? EOJ_COUNTER5 { get; set; }

        public decimal? EOJ_COUNTER6 { get; set; }

        public decimal? EOJ_COUNTER7 { get; set; }

        public decimal? EOJ_COUNTER8 { get; set; }

        public decimal? EOJ_COUNTER9 { get; set; }

        public decimal? EOJ_COUNTER10 { get; set; }

        public decimal? EOJ_COUNTER11 { get; set; }

        public decimal? EOJ_COUNTER12 { get; set; }

        public decimal? EOJ_COUNTER13 { get; set; }

        public decimal? EOJ_COUNTER14 { get; set; }

        public decimal? EOJ_COUNTER15 { get; set; }

        public decimal? EOJ_COUNTER16 { get; set; }

        public decimal? EOJ_COUNTER17 { get; set; }

        public decimal? EOJ_COUNTER18 { get; set; }

        public decimal? EOJ_COUNTER19 { get; set; }

        public decimal? EOJ_COUNTER20 { get; set; }
    }
}
