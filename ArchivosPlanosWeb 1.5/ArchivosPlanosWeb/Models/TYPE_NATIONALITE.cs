namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_NATIONALITE")]
    public partial class TYPE_NATIONALITE
    {
        [Key]
        [StringLength(1)]
        public string ID_NATIONALITE { get; set; }

        [StringLength(30)]
        public string LIBELLE_NATIONALITE { get; set; }
    }
}
