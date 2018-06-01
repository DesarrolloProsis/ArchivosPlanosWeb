namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_LSTRELOD_P")]
    public partial class PTM_LSTRELOD_P
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_LSTRELOD { get; set; }

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

        [StringLength(1)]
        public string ID_VALIDITY_TYPE { get; set; }

        public decimal? VALIDITY_LENGTH { get; set; }

        public decimal? RELOADING_PRICE { get; set; }

        [StringLength(3)]
        public string RELOADING_PRICE_UNIT { get; set; }

        public decimal? VAT_RATE { get; set; }

        public decimal? SELLING_PRICE_VAT { get; set; }
    }
}
