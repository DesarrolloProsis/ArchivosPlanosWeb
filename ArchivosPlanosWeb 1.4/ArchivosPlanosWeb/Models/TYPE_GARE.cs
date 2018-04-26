namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_GARE")]
    public partial class TYPE_GARE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_GARE { get; set; }

        [StringLength(30)]
        public string NOM_GARE { get; set; }

        [StringLength(30)]
        public string NOM_GARE_L2 { get; set; }
    }
}
