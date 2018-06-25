namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_FONCTION")]
    public partial class TYPE_FONCTION
    {
        [Key]
        [StringLength(1)]
        public string ID_FONCTION { get; set; }

        [StringLength(20)]
        public string LIBELLE_FONCTION { get; set; }

        [StringLength(20)]
        public string LIBELLE_FONCTION_L2 { get; set; }
    }
}
