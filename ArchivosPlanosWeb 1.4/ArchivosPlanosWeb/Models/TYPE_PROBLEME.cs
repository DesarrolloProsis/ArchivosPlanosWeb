namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_PROBLEME")]
    public partial class TYPE_PROBLEME
    {
        [Key]
        public decimal ID_PROBLEME { get; set; }

        [StringLength(30)]
        public string LIBELLE_PROBLEME { get; set; }
    }
}