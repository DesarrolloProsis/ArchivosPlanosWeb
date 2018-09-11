namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_ACQUISITION")]
    public partial class TYPE_ACQUISITION
    {
        [Key]
        public decimal ID_TYPE_ACQUISITION { get; set; }

        [StringLength(30)]
        public string LIBELLE_ACQUISITION { get; set; }
    }
}
