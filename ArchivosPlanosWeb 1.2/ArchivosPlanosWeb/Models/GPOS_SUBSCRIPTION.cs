namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_SUBSCRIPTION")]
    public partial class GPOS_SUBSCRIPTION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ID_SUBSCRIPTION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string ID_CUSTOMER { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ID_PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string ID_PRODUCT { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(25)]
        public string PRODUCT_NAME { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string ID_CLASS { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal BALANCE { get; set; }

        public decimal? BALANCE1 { get; set; }

        public DateTime? BALANCE_DATE { get; set; }

        public DateTime? BALANCE_DATE1 { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string BALANCE_UNIT { get; set; }

        public decimal? TOTAL_BALANCE { get; set; }

        public decimal? TOTAL_BALANCE1 { get; set; }

        public decimal? RELOAD_VALUE { get; set; }

        public decimal? RELOAD_PRICE { get; set; }

        public decimal? VAT_AMOUNT_RP { get; set; }

        public decimal? VAT_RATE_RP { get; set; }

        public decimal? THRESHOLD_VALUE { get; set; }

        public decimal? CREDIT_VALUE { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime VALIDITY_DHM { get; set; }

        public DateTime? EXPIRY_DHM { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(4)]
        public string ID_MEDIA_TYPE_LIST { get; set; }

        [StringLength(1)]
        public string OWNER_TYPE { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime CREATION_DHM { get; set; }

        public DateTime? CLOSURE_DHM { get; set; }

        public DateTime? LAST_MODIFICATION_DHM { get; set; }

        [StringLength(1)]
        public string RELOADING_FLAG { get; set; }

        [StringLength(1)]
        public string DEPOSIT_FLAG { get; set; }

        public DateTime? LAST_RELOAD_DHM { get; set; }

        public decimal? LAST_RELOAD_VALUE { get; set; }

        public decimal? LAST_RELOAD_PRICE { get; set; }

        public decimal? VAT_AMOUNT_LRP { get; set; }

        public decimal? VAT_RATE_LRP { get; set; }

        public decimal? LAST_BALANCE { get; set; }

        public decimal? REFUND_CALC { get; set; }

        public decimal? VAT_AMOUNT_RC { get; set; }

        public DateTime? LAST_INVOICE_DHM { get; set; }

        public DateTime? NEXT_INVOICE_DHM { get; set; }

        public DateTime? LAST_ACKNOWLEDGE_DHM { get; set; }

        public decimal? NEXT_ACKNOWLEDGE_NUMBER { get; set; }

        public decimal? PASSAGE_COUNT { get; set; }

        public decimal? PASSAGE_COUNT1 { get; set; }

        public DateTime? LAST_PASSAGE_DHM { get; set; }

        [StringLength(1)]
        public string INVOICING_LOCK { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? REFUND_STATUS { get; set; }

        public decimal? ID_LANE_MODE { get; set; }

        [StringLength(1)]
        public string ID_VALIDITY_TYPE { get; set; }

        public decimal? VALIDITY_LENGTH { get; set; }

        public decimal? SELLING_PRICE { get; set; }

        public decimal? VAT_AMOUNT_SP { get; set; }

        public decimal? VAT_RATE_SP { get; set; }

        [StringLength(2)]
        public string GROUP_CODE { get; set; }
    }
}
