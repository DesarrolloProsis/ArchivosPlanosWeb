namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.IMG_VIDEO_IMAGE")]
    public partial class IMG_VIDEO_IMAGE
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
        public DateTime DATE_IMAGE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string ID_VOIE_ACQUIS { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(80)]
        public string CHEMIN_FICHIER { get; set; }

        public byte? ID_CLASSE { get; set; }

        public short? NUMERO_ACQUISITION { get; set; }

        public byte? RAISON_ENREG { get; set; }

        public byte? NUMERO_POSTE { get; set; }

        public short? NUMERO_TRANSACTION { get; set; }

        [StringLength(6)]
        public string MATRICULE_OPE1 { get; set; }

        [StringLength(6)]
        public string MATRICULE_OPE2 { get; set; }

        [StringLength(15)]
        public string PLAQUE_IMMATRIC1 { get; set; }

        [StringLength(15)]
        public string PLAQUE_IMMATRIC2 { get; set; }

        [StringLength(9)]
        public string PBS_AUTORISE { get; set; }

        [StringLength(20)]
        public string NUMERO_CARTE { get; set; }

        [StringLength(20)]
        public string INFORMATION { get; set; }

        public short? PRIX { get; set; }

        public byte? ID_PAIEMENT { get; set; }

        [StringLength(1)]
        public string LITIGATION { get; set; }

        [StringLength(4)]
        public string SAC { get; set; }

        public byte? CLASSEPREDAC { get; set; }

        public byte? CLASSEPOSTDAC { get; set; }

        [StringLength(1)]
        public string OBSERVATION_TT { get; set; }

        [StringLength(1)]
        public string OBSERVATION_MP { get; set; }

        [StringLength(1)]
        public string OBSERVATION_SEQ { get; set; }

        [StringLength(1)]
        public string OBSERVATION_PAS { get; set; }

        public byte? CLASSECORRIGEE { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_1 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_2 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_3 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_4 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_5 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_6 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_7 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_8 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_9 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_10 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_11 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_12 { get; set; }

        [StringLength(1)]
        public string MAINTENANCE_13 { get; set; }
    }
}
