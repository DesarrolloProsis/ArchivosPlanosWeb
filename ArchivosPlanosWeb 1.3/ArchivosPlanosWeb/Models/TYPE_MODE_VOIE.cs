namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_MODE_VOIE")]
    public partial class TYPE_MODE_VOIE
    {
        [Key]
        public decimal ID_MODE_VOIE { get; set; }

        [StringLength(30)]
        public string LIBELLE_MODE_VOIE { get; set; }

        [StringLength(30)]
        public string LIBELLE_MODE_VOIE_L2 { get; set; }
    }
}
