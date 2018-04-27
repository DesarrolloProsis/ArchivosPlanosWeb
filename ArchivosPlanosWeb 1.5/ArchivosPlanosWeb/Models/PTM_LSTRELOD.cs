namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_LSTRELOD")]
    public partial class PTM_LSTRELOD
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

        public decimal? RELOADING_VALUE { get; set; }

        [StringLength(3)]
        public string RELOADING_VALUE_UNIT { get; set; }

        public decimal? RELOADING_PRICE { get; set; }

        [StringLength(3)]
        public string RELOADING_PRICE_UNIT { get; set; }

        public decimal? SELLING_PRICE_VAT { get; set; }

        public decimal? VAT_RATE { get; set; }
    }
}
