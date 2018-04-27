namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_TABLE_ENTETE")]
    public partial class PTM_TABLE_ENTETE
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_TABLE { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATE_CREATION { get; set; }

        public DateTime? DATE_PEC { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ID_RESEAU_SORTIE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal ID_GARE_SORTIE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal VERSION { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal NB_ENREGS { get; set; }

        public DateTime? DATE_GENERATION { get; set; }

        [StringLength(1)]
        public string ETAT_TABLE { get; set; }

        [StringLength(6)]
        public string MATRICULE { get; set; }
    }
}
