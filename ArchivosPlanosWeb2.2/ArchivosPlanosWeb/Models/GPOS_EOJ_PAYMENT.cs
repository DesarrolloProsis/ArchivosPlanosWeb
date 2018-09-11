namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_EOJ_PAYMENT")]
    public partial class GPOS_EOJ_PAYMENT
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
        public decimal ID_MOP { get; set; }

        [StringLength(3)]
        public string CURRENCY_UNIT { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(4)]
        public string MOP_LABEL { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal PAYMENT_COUNTER { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal TOTAL_AMOUNT { get; set; }

        public decimal? VAT_AMOUNT { get; set; }

        public decimal? VALIDATED_DATA_FLAG { get; set; }

        [StringLength(6)]
        public string VALIDATION_STAFF { get; set; }

        public DateTime? VALIDATION_DATE { get; set; }
    }
}
