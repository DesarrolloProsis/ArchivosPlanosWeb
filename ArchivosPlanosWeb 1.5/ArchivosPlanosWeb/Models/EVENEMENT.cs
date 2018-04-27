namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.EVENEMENT")]
    public partial class EVENEMENT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string ID_EVENEMENT { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte ID_EQUIPEMENT { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DATE_EVENEMENT { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string ID_GARE { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string ID_VOIE { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(3)]
        public string VOIE { get; set; }

        [StringLength(6)]
        public string MATRICULE { get; set; }

        public decimal? ID_ETAT_TELEPEAGE { get; set; }

        public decimal? ID_MODE_VOIE { get; set; }

        public decimal? NUMERO_POSTE { get; set; }

        public decimal? STATUS_EVENEMENT { get; set; }

        [StringLength(25)]
        public string DETAIL_EVENEMENT { get; set; }

        public DateTime? DATE_DEBUT_POSTE { get; set; }
    }
}
