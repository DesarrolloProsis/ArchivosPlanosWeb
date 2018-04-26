namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.FIN_POSTE")]
    public partial class FIN_POSTE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_GARE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string ID_VOIE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string VOIE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string MATRICULE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal ID_ETAT_TELEPEAGE { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal ID_MODE_VOIE { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal NUMERO_POSTE { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime DATE_FIN_POSTE { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal VERSION_DEVISE { get; set; }

        [StringLength(2)]
        public string ID_SITE { get; set; }

        [StringLength(2)]
        public string ID_DPT { get; set; }

        [StringLength(6)]
        public string RED_MATRICULE { get; set; }

        public DateTime? DATE_REDDITION { get; set; }

        [StringLength(8)]
        public string SAC { get; set; }

        public decimal? TRAFIC_TOTAL { get; set; }

        public decimal? RECETTE_MONNAIE1 { get; set; }

        public decimal? RECETTE_MONNAIE2 { get; set; }

        public decimal? RECETTE_MONNAIE3 { get; set; }

        public decimal? RECETTE_MONNAIE4 { get; set; }

        public decimal? DISCORDANCE_DAC { get; set; }

        public decimal? PASSAGE_FORCE1 { get; set; }

        public decimal? PASSAGE_FORCE2 { get; set; }

        public decimal? PASSAGE_FORCE3 { get; set; }

        public decimal? PASSAGE_FORCE4 { get; set; }

        public decimal? PASSAGE_FORCE5 { get; set; }

        public decimal? MP_OPPOSITION { get; set; }

        public decimal? MP_DEPASSEE { get; set; }

        public decimal? TT_DEPASSEE { get; set; }

        public decimal? VIOLATION_FERME { get; set; }

        public decimal? FIN_POSTE_CPT1 { get; set; }

        public decimal? FIN_POSTE_CPT2 { get; set; }

        public decimal? FIN_POSTE_CPT3 { get; set; }

        public decimal? FIN_POSTE_CPT4 { get; set; }

        public decimal? FIN_POSTE_CPT5 { get; set; }

        public decimal? FIN_POSTE_CPT6 { get; set; }

        public decimal? FIN_POSTE_CPT7 { get; set; }

        public decimal? FIN_POSTE_CPT8 { get; set; }

        public decimal? FIN_POSTE_CPT9 { get; set; }

        public decimal? FIN_POSTE_CPT10 { get; set; }

        public decimal? FIN_POSTE_CPT11 { get; set; }

        public decimal? FIN_POSTE_CPT12 { get; set; }

        public decimal? FIN_POSTE_CPT13 { get; set; }

        public decimal? FIN_POSTE_CPT14 { get; set; }

        public decimal? FIN_POSTE_CPT15 { get; set; }

        public decimal? FIN_POSTE_CPT16 { get; set; }

        public decimal? FIN_POSTE_CPT17 { get; set; }

        public decimal? FIN_POSTE_CPT18 { get; set; }

        public decimal? FIN_POSTE_CPT19 { get; set; }

        public decimal? FIN_POSTE_CPT20 { get; set; }

        public decimal? FIN_POSTE_CPT21 { get; set; }

        public decimal? FIN_POSTE_CPT22 { get; set; }

        public decimal? FIN_POSTE_CPT23 { get; set; }

        public decimal? FIN_POSTE_CPT24 { get; set; }

        public decimal? FIN_POSTE_CPT25 { get; set; }

        public decimal? FIN_POSTE_CPT26 { get; set; }

        public decimal? FIN_POSTE_CPT27 { get; set; }

        public decimal? FIN_POSTE_CPT28 { get; set; }

        public decimal? FIN_POSTE_CPT29 { get; set; }

        public decimal? FIN_POSTE_CPT30 { get; set; }

        public decimal? FIN_POSTE_CPT31 { get; set; }

        public decimal? FIN_POSTE_CPT32 { get; set; }

        public decimal? FIN_POSTE_CPT33 { get; set; }

        public decimal? FIN_POSTE_CPT34 { get; set; }

        public decimal? FIN_POSTE_CPT35 { get; set; }

        public DateTime? DATE_DEBUT_POSTE { get; set; }

        public DateTime? OPERATING_DATE { get; set; }

        public decimal? OPERATING_SHIFT { get; set; }

        public decimal? VALIDATED_DATA_FLAG { get; set; }

        [StringLength(6)]
        public string VALIDATION_STAFF { get; set; }

        public DateTime? VALIDATION_DATE { get; set; }

        public decimal? FOLIO_NUMBER_OPEN { get; set; }

        public decimal? FOLIO_NUMBER_CLOSE { get; set; }

        public decimal? INITIAL_EVENT_NUMBER { get; set; }

        public decimal? FINAL_EVENT_NUMBER { get; set; }

        public decimal? FOLIO2_NUMBER_INITIAL { get; set; }

        public decimal? FOLIO2_NUMBER_FINAL { get; set; }

        public decimal? FOLIO3_NUMBER_INITIAL { get; set; }

        public decimal? FOLIO3_NUMBER_FINAL { get; set; }

        public decimal? FOLIO_ECT_NUMBER_INITIAL { get; set; }

        public decimal? FOLIO_ECT_NUMBER_FINAL { get; set; }
    }
}
