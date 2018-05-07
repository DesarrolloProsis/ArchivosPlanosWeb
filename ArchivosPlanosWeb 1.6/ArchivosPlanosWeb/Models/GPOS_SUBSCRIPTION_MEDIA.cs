namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_SUBSCRIPTION_MEDIA")]
    public partial class GPOS_SUBSCRIPTION_MEDIA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ID_SUBSCRIPTION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(19)]
        public string ID_MEDIA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ID_MEDIA_TYPE { get; set; }

        [StringLength(25)]
        public string MEDIA_TYPE_NAME { get; set; }

        public DateTime? MEDIA_EXPIRY_DATE { get; set; }

        [StringLength(1)]
        public string OWNER_TYPE { get; set; }

        [StringLength(20)]
        public string OWNER_INFORMATION { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal MEDIA_DEPOSIT { get; set; }

        public decimal? VAT_AMOUNT_MD { get; set; }

        public decimal? VAT_RATE_MD { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string MEDIA_DEPOSIT_UNIT { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CREATION_DHM { get; set; }

        public DateTime? LAST_REPLACE_DHM { get; set; }

        public DateTime? RETURN_DHM { get; set; }

        [StringLength(1)]
        public string ID_MEDIA_TECHNOLOGY { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string MANAGEMENT_FLAG { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? ID_LANE_MODE { get; set; }

        public decimal? TEMPLATE_NUMBER { get; set; }

        [StringLength(512)]
        public string TEMPLATE_1 { get; set; }

        [StringLength(512)]
        public string TEMPLATE_2 { get; set; }
    }
}
