namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_LSTPRODS")]
    public partial class PTM_LSTPRODS
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_LSTPRODS { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_NETWORK { get; set; }

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
        public decimal ID_CLASS { get; set; }

        [StringLength(25)]
        public string PRODUCT_NAME { get; set; }

        [StringLength(1)]
        public string RELOADING_FLAG { get; set; }

        public decimal? INITIAL_BALANCE { get; set; }

        [StringLength(3)]
        public string INITIAL_BALANCE_UNIT { get; set; }

        public decimal? SELLING_PRICE { get; set; }

        [StringLength(3)]
        public string SELLING_PRICE_UNIT { get; set; }

        public decimal? SELLING_PRICE_VAT { get; set; }

        public decimal? VAT_RATE { get; set; }

        [StringLength(1)]
        public string ID_VALIDITY_TYPE { get; set; }

        public decimal? VALIDITY_LENGTH { get; set; }

        [StringLength(1)]
        public string DEPOSIT_FLAG { get; set; }

        [StringLength(4)]
        public string ID_MEDIA_TYPE_LIST { get; set; }

        [StringLength(1)]
        public string EQUIP_RESTRICT_CODE { get; set; }

        [StringLength(4)]
        public string PLAZA_RESTRICT_CODE { get; set; }

        public decimal? LEVEL_RESTRICT_CODE { get; set; }

        [StringLength(1)]
        public string OWNER_TYPE { get; set; }

        public decimal? THRESHOLD_VALUE { get; set; }

        public decimal? CREDIT_LIMIT { get; set; }

        [StringLength(4)]
        public string MULTI_CLASS { get; set; }
    }
}
