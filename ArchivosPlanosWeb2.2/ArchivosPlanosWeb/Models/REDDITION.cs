namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.REDDITION")]
    public partial class REDDITION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_SITE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MATRICULE { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DATE_REDDITION { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(8)]
        public string SAC { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal VERSION_DEVISE { get; set; }

        public decimal? POSTE_POS_RCT_MONNAIE1 { get; set; }

        public decimal? POSTE_POS_RCT_MONNAIE2 { get; set; }

        public decimal? POSTE_POS_RCT_MONNAIE3 { get; set; }

        public decimal? POSTE_POS_RCT_MONNAIE4 { get; set; }

        public decimal? POSTE_POS_RMB_MONNAIE1 { get; set; }

        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        public decimal? POSTE_POS_RCT_DEVISE { get; set; }

        public decimal? POSTE_POS_RCT_CHQ { get; set; }

        public decimal? POSTE_RCT_DEVISE { get; set; }

        public decimal? POSTE_RCT_MONNAIE1 { get; set; }

        public decimal? POSTE_RCT_MONNAIE2 { get; set; }

        public decimal? POSTE_RCT_MONNAIE3 { get; set; }

        public decimal? POSTE_RCT_MONNAIE4 { get; set; }

        public decimal? POSTE_JETON { get; set; }

        public decimal? POSTE_RDD { get; set; }

        public decimal? POSTE_GRATUIT { get; set; }

        public decimal? POSTE_RCT_CHQ { get; set; }

        public decimal? RED_RCT_DEVISE { get; set; }

        public decimal? RED_RCT_MONNAIE1 { get; set; }

        public decimal? RED_RCT_MONNAIE2 { get; set; }

        public decimal? RED_RCT_MONNAIE3 { get; set; }

        public decimal? RED_RCT_MONNAIE4 { get; set; }

        public decimal? RED_JETON { get; set; }

        public decimal? RED_RDD { get; set; }

        public decimal? RED_GRATUIT { get; set; }

        public decimal? RED_RCT_CHQ { get; set; }

        public decimal? RED_NB_CHQ { get; set; }

        public decimal? ETAT_REDDITION { get; set; }

        [StringLength(1)]
        public string ID_MONNAIE_REF { get; set; }

        public decimal? TRAFIC_TOTAL { get; set; }

        public decimal? NB_POSTE { get; set; }

        public decimal? NB_POSTE_POS { get; set; }

        public decimal? NB_POSTE_CLAIM { get; set; }

        [StringLength(12)]
        public string LISTE_MONNAIE { get; set; }

        [StringLength(6)]
        public string MATRICULE_COMMENTAIRE { get; set; }

        [StringLength(250)]
        public string COMMENTAIRE { get; set; }

        public DateTime? DATE_VERSEMENT_BANQUE { get; set; }

        [StringLength(20)]
        public string BANK_SLIP_NUMBER { get; set; }

        [StringLength(2)]
        public string BANK_SLIP_SITE { get; set; }

        public decimal? FOND_CAISSE { get; set; }

        public decimal? FOND_CAISSE_MONNAIE2 { get; set; }

        public decimal? RED_RCT_TOT_INI { get; set; }

        public decimal? RED_CPT1 { get; set; }

        public decimal? RED_CPT2 { get; set; }

        public decimal? RED_CPT3 { get; set; }

        public decimal? RED_CPT4 { get; set; }

        public decimal? RED_CPT5 { get; set; }

        public decimal? RED_CPT6 { get; set; }

        public decimal? RED_CPT7 { get; set; }

        public decimal? RED_CPT8 { get; set; }

        public decimal? RED_CPT9 { get; set; }

        public decimal? RED_CPT10 { get; set; }

        public decimal? RED_CPT11 { get; set; }

        public decimal? RED_CPT12 { get; set; }

        public decimal? RED_CPT13 { get; set; }

        public decimal? RED_CPT14 { get; set; }

        public decimal? RED_CPT15 { get; set; }

        public decimal? RED_CPT16 { get; set; }

        public decimal? RED_CPT17 { get; set; }

        public decimal? RED_CPT18 { get; set; }

        public decimal? RED_CPT19 { get; set; }

        public decimal? RED_CPT20 { get; set; }

        public decimal? RED_CPT21 { get; set; }

        public decimal? RED_CPT22 { get; set; }

        public decimal? RED_CPT23 { get; set; }

        public decimal? RED_CPT24 { get; set; }

        public decimal? RED_CPT25 { get; set; }

        [StringLength(8)]
        public string RED_TXT1 { get; set; }

        [StringLength(8)]
        public string RED_TXT2 { get; set; }

        [StringLength(8)]
        public string RED_TXT3 { get; set; }

        [StringLength(8)]
        public string RED_TXT4 { get; set; }

        [StringLength(1)]
        public string CORRECTION_STATUS { get; set; }

        public decimal? OPERATING_SHIFT { get; set; }

        public DateTime? DATE_SHIFT_DEBUT { get; set; }

        public DateTime? DATE_SHIFT_FIN { get; set; }

        public decimal? RED_RCT_RDD { get; set; }

        public decimal? POSTE_RCT_RDD { get; set; }

        public DateTime? OPERATING_DATE { get; set; }

        public decimal? POSTE_CLAIM_RCT_MONNAIE1 { get; set; }

        public decimal? POSTE_CLAIM_RCT_MONNAIE2 { get; set; }

        public decimal? POSTE_CLAIM_RCT_MONNAIE3 { get; set; }

        public decimal? POSTE_CLAIM_RCT_MONNAIE4 { get; set; }

        public decimal? POSTE_CLAIM_RCT_DEVISE { get; set; }

        public decimal? POSTE_CLAIM_RCT_CHQ { get; set; }

        public decimal? VALIDATED_DATA_FLAG { get; set; }

        [StringLength(6)]
        public string VALIDATION_STAFF { get; set; }

        public DateTime? VALIDATION_DATE { get; set; }

        public decimal? ID_SHIFT { get; set; }
    }
}
