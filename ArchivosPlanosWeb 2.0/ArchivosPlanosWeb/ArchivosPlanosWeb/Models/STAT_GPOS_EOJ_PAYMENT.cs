namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.STAT_GPOS_EOJ_PAYMENT")]
    public partial class STAT_GPOS_EOJ_PAYMENT
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
        public decimal ID_MOP { get; set; }

        [StringLength(3)]
        public string CURRENCY_UNIT { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(4)]
        public string MOP_LABEL { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal PAYMENT_COUNTER { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal TOTAL_AMOUNT { get; set; }

        public decimal? VAT_AMOUNT { get; set; }
    }
}
