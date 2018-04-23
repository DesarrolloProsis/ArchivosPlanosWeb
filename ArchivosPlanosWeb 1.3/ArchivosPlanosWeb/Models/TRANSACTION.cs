namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TRANSACTION")]
    public partial class TRANSACTION
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
        public DateTime DATE_TRANSACTION { get; set; }

        [StringLength(6)]
        public string MATRICULE { get; set; }

        public decimal? ID_ETAT_TELEPEAGE { get; set; }

        public decimal? ID_MODE_VOIE { get; set; }

        public decimal? NUMERO_POSTE { get; set; }

        public decimal? ID_CLASSE { get; set; }

        public decimal? ID_TYPE_ACQUISITION { get; set; }

        [StringLength(1)]
        public string ID_OBS_TT { get; set; }

        [StringLength(2)]
        public string ID_OBS_MP { get; set; }

        [StringLength(1)]
        public string ID_OBS_SEQUENCE { get; set; }

        [StringLength(1)]
        public string ID_OBS_PASSAGE { get; set; }

        public decimal? ID_CATEGORIE_FISCALE { get; set; }

        public decimal? ID_TRANSIT { get; set; }

        public decimal? TAB_ID_CLASSE { get; set; }

        [StringLength(2)]
        public string TAB_ID_RESEAU { get; set; }

        [StringLength(2)]
        public string TAB_ID_GARE { get; set; }

        [StringLength(2)]
        public string TRA_ID_RESEAU { get; set; }

        [StringLength(2)]
        public string TRA_ID_GARE { get; set; }

        [StringLength(1)]
        public string TRA_ID_VOIE { get; set; }

        [StringLength(3)]
        public string TRA_VOIE { get; set; }

        public decimal? VERSION_TARIF { get; set; }

        public decimal? ID_PAIEMENT { get; set; }

        public decimal? NUMERO_TRANSACTION { get; set; }

        public decimal? INDICE_SUITE { get; set; }

        public decimal? NIVEAU_EMISSION_TT { get; set; }

        [StringLength(14)]
        public string DATE_ENTREE { get; set; }

        public decimal? NUMERO_TICKET { get; set; }

        [StringLength(1)]
        public string CODE_GRILLE_TARIF { get; set; }

        public decimal? PRIX_TOTAL { get; set; }

        public decimal? PRIX_PARTIEL { get; set; }

        [StringLength(39)]
        public string CONTENU_ISO { get; set; }

        [StringLength(2)]
        public string CODE_OCTAL { get; set; }

        [StringLength(4)]
        public string MODE_REGLEMENT { get; set; }

        [StringLength(6)]
        public string TRANSACTION_CPT0 { get; set; }

        [StringLength(6)]
        public string TRANSACTION_CPT1 { get; set; }

        [StringLength(6)]
        public string TRANSACTION_CPT2 { get; set; }

        [StringLength(6)]
        public string TRANSACTION_CPT3 { get; set; }

        [StringLength(6)]
        public string TRANSACTION_CPT4 { get; set; }

        [StringLength(4)]
        public string TRANSACTION_CPT5 { get; set; }

        [StringLength(4)]
        public string TRANSACTION_CPT6 { get; set; }

        [StringLength(4)]
        public string TRANSACTION_CPT7 { get; set; }

        [StringLength(2)]
        public string TRANSACTION_CPT8 { get; set; }

        [StringLength(2)]
        public string TRANSACTION_CPT9 { get; set; }

        [StringLength(2)]
        public string ID_FACTURATION { get; set; }

        public DateTime? DATE_DEBUT_POSTE { get; set; }

        [StringLength(1)]
        public string CODE1 { get; set; }

        [StringLength(19)]
        public string NUMERO_CARTE { get; set; }

        [StringLength(12)]
        public string NO_ABONNEMENT_CARTE { get; set; }

        [StringLength(2)]
        public string ID_NETWORK_ENTRY { get; set; }

        [StringLength(6)]
        public string ID_STAFF_ENTRY { get; set; }

        public decimal? INCOME_AMOUNT { get; set; }

        public decimal? VAT_AMOUNT { get; set; }

        [StringLength(10)]
        public string RECEIPT_NUMBER { get; set; }

        public decimal? VALIDATED_DATA_FLAG { get; set; }

        [StringLength(6)]
        public string VALIDATION_STAFF { get; set; }

        public DateTime? VALIDATION_DATE { get; set; }

        [StringLength(1)]
        public string ID_TYPE_CORRECTION { get; set; }

        [StringLength(1)]
        public string CORRECTION_STATUS { get; set; }

        public decimal? SHIFT_NUMBER { get; set; }

        [StringLength(16)]
        public string VIOLATION_NUMBER { get; set; }

        [StringLength(20)]
        public string VEHICLE_LPN { get; set; }

        public decimal? EVENT_NUMBER { get; set; }

        public decimal? ACD_CLASS { get; set; }

        [StringLength(4)]
        public string ISSUER_ID { get; set; }

        public decimal? TAG_TRX_NB { get; set; }

        [StringLength(32)]
        public string EFACTURA { get; set; }

        [StringLength(2)]
        public string OPERATION_CODE { get; set; }

        public decimal? FOLIO_ECT { get; set; }
    }
}
