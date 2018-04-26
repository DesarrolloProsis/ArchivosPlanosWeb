namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_DEFMEDIA")]
    public partial class PTM_DEFMEDIA
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_NETWORK { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_DEFMEDIA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ID_MEDIA_TYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string MEDIA_TYPE_NAME { get; set; }

        [StringLength(6)]
        public string ISSUER_CODE { get; set; }

        public decimal? VALIDITY_LENGTH { get; set; }

        public decimal? DEPOSIT { get; set; }

        [StringLength(3)]
        public string DEPOSIT_UNIT { get; set; }

        [StringLength(1)]
        public string MANAGEMENT_TYPE { get; set; }

        [StringLength(1)]
        public string ENCODER_TYPE { get; set; }

        public decimal? SELLING_PRICE_VAT { get; set; }

        public decimal? VAT_RATE { get; set; }
    }
}
