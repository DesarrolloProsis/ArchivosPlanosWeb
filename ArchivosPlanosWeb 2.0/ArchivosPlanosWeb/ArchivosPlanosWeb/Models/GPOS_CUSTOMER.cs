namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_CUSTOMER")]
    public partial class GPOS_CUSTOMER
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ID_CUSTOMER { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string NAME { get; set; }

        [StringLength(30)]
        public string FIRST_NAME { get; set; }

        [StringLength(30)]
        public string CONTACT_NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string ADDRESS_L1 { get; set; }

        [StringLength(40)]
        public string ADDRESS_L2 { get; set; }

        [StringLength(40)]
        public string ADDRESS_L3 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string POSTCODE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string TOWN { get; set; }

        [StringLength(30)]
        public string COUNTRY { get; set; }

        [StringLength(15)]
        public string PHONE_NUMBER1 { get; set; }

        [StringLength(15)]
        public string PHONE_NUMBER2 { get; set; }

        [StringLength(15)]
        public string FAX_NUMBER { get; set; }

        [StringLength(80)]
        public string EMAIL { get; set; }

        [StringLength(1)]
        public string INVOICING_ADDRESS_FLAG { get; set; }

        [StringLength(40)]
        public string INVOICING_ADDRESS_L1 { get; set; }

        [StringLength(40)]
        public string INVOICING_ADDRESS_L2 { get; set; }

        [StringLength(40)]
        public string INVOICING_ADDRESS_L3 { get; set; }

        [StringLength(15)]
        public string INVOICING_POSTCODE { get; set; }

        [StringLength(30)]
        public string INVOICING_TOWN { get; set; }

        [StringLength(30)]
        public string INVOICING_COUNTRY { get; set; }

        [StringLength(30)]
        public string BANK_NAME { get; set; }

        [StringLength(35)]
        public string BANK_ACCOUNT_NUMBER { get; set; }

        [StringLength(19)]
        public string CREDIT_CARD_NUMBER { get; set; }

        [StringLength(4)]
        public string CREDIT_CARD_EXPIRY { get; set; }

        [StringLength(1)]
        public string INVOICING_TYPE { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CREATION_DHM { get; set; }

        public DateTime? LAST_MODIFICATION_DHM { get; set; }

        public DateTime? CLOSURE_DHM { get; set; }

        [StringLength(1)]
        public string INVOICING_LOCK { get; set; }

        public decimal? STATUS { get; set; }

        public decimal? ID_LANE_MODE { get; set; }
    }
}
