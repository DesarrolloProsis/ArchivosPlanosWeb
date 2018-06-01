namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_SITE")]
    public partial class TYPE_SITE
    {
        [Key]
        [StringLength(2)]
        public string ID_SITE { get; set; }

        [StringLength(30)]
        public string NOM_SITE { get; set; }

        [StringLength(30)]
        public string NOM_SITE_L2 { get; set; }
    }
}
