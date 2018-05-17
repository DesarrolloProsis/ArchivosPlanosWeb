namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_VOIE")]
    public partial class TYPE_VOIE
    {
        [Key]
        [StringLength(1)]
        public string ID_VOIE { get; set; }

        [StringLength(10)]
        public string LIBELLE_COURT_VOIE { get; set; }

        [StringLength(10)]
        public string LIBELLE_COURT_VOIE_L2 { get; set; }

        [StringLength(30)]
        public string LIBELLE_VOIE { get; set; }

        [StringLength(1)]
        public string ENTREE_SORTIE { get; set; }
    }
}
