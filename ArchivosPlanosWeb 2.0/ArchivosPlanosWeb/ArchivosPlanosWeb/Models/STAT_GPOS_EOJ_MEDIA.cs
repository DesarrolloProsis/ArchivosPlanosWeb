namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.STAT_GPOS_EOJ_MEDIA")]
    public partial class STAT_GPOS_EOJ_MEDIA
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
        [StringLength(1)]
        public string ID_LANE_TYPE { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime DATE_DAY { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(6)]
        public string ID_STAFF { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string ID_MEDIA_TYPE { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string CURRENCY_UNIT { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal ADDED_MEDIA_COUNTER { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal AMOUNT_ADDED_MEDIA { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal VAT_DEPOSIT_AMOUNT_RECEIVED { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal RETURNED_MEDIA_COUNTER { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal AMOUNT_RETURNED_MEDIA { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal VAT_DEPOSIT_AMOUNT_RETURNED { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal RETURN_MEDIA_DEPOSIT_KEPT_CT { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal LOST_MEDIA_DEPOSIT_KEPT_CT { get; set; }

        [Key]
        [Column(Order = 16)]
        public decimal DEPOSIT_AMOUNT_KEPT { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal VAT_DEPOSIT_AMOUNT_KEPT { get; set; }
    }
}
