namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_COMM")]
    public partial class TABLE_COMM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_GARE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string ID_VOIE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string VOIE { get; set; }

        public DateTime? DERNIERE_DHM { get; set; }
    }
}