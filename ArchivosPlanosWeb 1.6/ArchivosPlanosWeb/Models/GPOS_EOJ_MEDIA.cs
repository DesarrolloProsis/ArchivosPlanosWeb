namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_EOJ_MEDIA")]
    public partial class GPOS_EOJ_MEDIA
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
        public string ID_MEDIA_TYPE { get; set; }

        [StringLength(3)]
        public string CURRENCY_UNIT { get; set; }

        public decimal? ADDED_MEDIA_COUNTER { get; set; }

        public decimal? AMOUNT_ADDED_MEDIA { get; set; }

        public decimal? VAT_DEPOSIT_AMOUNT_RECEIVED { get; set; }

        public decimal? RETURNED_MEDIA_COUNTER { get; set; }

        public decimal? AMOUNT_RETURNED_MEDIA { get; set; }

        public decimal? VAT_DEPOSIT_AMOUNT_RETURNED { get; set; }

        public decimal? RETURN_MEDIA_DEPOSIT_KEPT_CT { get; set; }

        public decimal? LOST_MEDIA_DEPOSIT_KEPT_CT { get; set; }

        public decimal? DEPOSIT_AMOUNT_KEPT { get; set; }

        public decimal? VAT_DEPOSIT_AMOUNT_KEPT { get; set; }
    }
}
