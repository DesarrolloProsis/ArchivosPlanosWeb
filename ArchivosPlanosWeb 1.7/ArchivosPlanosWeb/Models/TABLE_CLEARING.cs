namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_CLEARING")]
    public partial class TABLE_CLEARING
    {
        [Key]
        public decimal VERSION_CLEARING { get; set; }

        [StringLength(2)]
        public string ID_NETWORK { get; set; }

        [StringLength(3)]
        public string ID_BANK { get; set; }

        [StringLength(6)]
        public string ID_CLEARING { get; set; }

        [StringLength(16)]
        public string BANK_NAME { get; set; }

        [StringLength(40)]
        public string BANK_ADDRESS { get; set; }

        [StringLength(10)]
        public string BANK_POST_CODE { get; set; }

        [StringLength(15)]
        public string BANK_TOWN { get; set; }

        [StringLength(15)]
        public string BANK_COUNTRY { get; set; }

        [StringLength(15)]
        public string BANK_CONTACT { get; set; }

        public decimal? BANK_TEL { get; set; }

        public decimal? ID_TRANSMITTER { get; set; }

        public decimal? TYPE_PAYMENT_OR_SITE { get; set; }

        [StringLength(1)]
        public string TRANSMISSION_MODE { get; set; }

        [StringLength(11)]
        public string BANK_ACCOUNT_NUMBER { get; set; }

        [StringLength(5)]
        public string BANK_ACCOUNT_NUMBER_C1 { get; set; }

        [StringLength(5)]
        public string BANK_ACCOUNT_NUMBER_C2 { get; set; }

        [StringLength(3)]
        public string CURRENCY_UNIT { get; set; }

        public decimal? DELAY_FROM_BANK_RESPONSE { get; set; }

        [StringLength(10)]
        public string PARAM1 { get; set; }

        [StringLength(10)]
        public string PARAM2 { get; set; }

        [StringLength(10)]
        public string PARAM3 { get; set; }

        [StringLength(10)]
        public string PARAM4 { get; set; }

        [StringLength(10)]
        public string PARAM5 { get; set; }

        public decimal? PARAM6 { get; set; }

        public decimal? PARAM7 { get; set; }

        public decimal? PARAM8 { get; set; }

        public decimal? PARAM9 { get; set; }

        public decimal? PARAM10 { get; set; }
    }
}
