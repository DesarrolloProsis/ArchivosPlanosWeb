namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_RESEAU")]
    public partial class TYPE_RESEAU
    {
        [Key]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [StringLength(30)]
        public string NOM_RESEAU { get; set; }

        [StringLength(30)]
        public string NOM_RESEAU_L2 { get; set; }
    }
}
