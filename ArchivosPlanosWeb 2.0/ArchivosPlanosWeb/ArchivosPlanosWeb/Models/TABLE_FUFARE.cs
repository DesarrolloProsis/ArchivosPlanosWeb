namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_FUFARE")]
    public partial class TABLE_FUFARE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_FUFARE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_NETWORK { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ID_PLAZA { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string FARE_MODULATION_CODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string THRESHOLD_TYPE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal THRESHOLD_VALUE { get; set; }

        public decimal? FARE_INCLVAT_CL01 { get; set; }

        public decimal? FARE_INCLVAT_CL02 { get; set; }

        public decimal? FARE_INCLVAT_CL03 { get; set; }

        public decimal? FARE_INCLVAT_CL04 { get; set; }

        public decimal? FARE_INCLVAT_CL05 { get; set; }

        public decimal? FARE_INCLVAT_CL06 { get; set; }

        public decimal? FARE_INCLVAT_CL07 { get; set; }

        public decimal? FARE_INCLVAT_CL08 { get; set; }

        public decimal? FARE_INCLVAT_CL09 { get; set; }

        public decimal? FARE_INCLVAT_CL10 { get; set; }

        public decimal? VAT_AMOUNT_CL01 { get; set; }

        public decimal? VAT_AMOUNT_CL02 { get; set; }

        public decimal? VAT_AMOUNT_CL03 { get; set; }

        public decimal? VAT_AMOUNT_CL04 { get; set; }

        public decimal? VAT_AMOUNT_CL05 { get; set; }

        public decimal? VAT_AMOUNT_CL06 { get; set; }

        public decimal? VAT_AMOUNT_CL07 { get; set; }

        public decimal? VAT_AMOUNT_CL08 { get; set; }

        public decimal? VAT_AMOUNT_CL09 { get; set; }

        public decimal? VAT_AMOUNT_CL10 { get; set; }
    }
}
