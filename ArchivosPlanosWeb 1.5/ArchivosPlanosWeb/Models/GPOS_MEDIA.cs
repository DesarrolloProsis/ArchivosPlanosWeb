namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_MEDIA")]
    public partial class GPOS_MEDIA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_MEDIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string MEDIA_NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal VERSION_MEDIA { get; set; }
    }
}
