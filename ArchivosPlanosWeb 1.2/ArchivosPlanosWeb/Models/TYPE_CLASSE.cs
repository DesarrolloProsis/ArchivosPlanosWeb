namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_CLASSE")]
    public partial class TYPE_CLASSE
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_CLASSE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ORDRE_AFFICHAGE { get; set; }

        [StringLength(30)]
        public string LIBELLE_CLASSE { get; set; }

        [StringLength(30)]
        public string LIBELLE_CLASSE_L2 { get; set; }

        [StringLength(5)]
        public string LIBELLE_COURT1 { get; set; }

        [StringLength(5)]
        public string LIBELLE_COURT1_L2 { get; set; }

        [StringLength(5)]
        public string LIBELLE_COURT2 { get; set; }

        [StringLength(5)]
        public string LIBELLE_COURT2_L2 { get; set; }
    }
}
