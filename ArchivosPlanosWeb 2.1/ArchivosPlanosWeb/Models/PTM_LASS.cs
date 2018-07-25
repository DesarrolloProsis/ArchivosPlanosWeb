namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_LASS")]
    public partial class PTM_LASS
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_LASS { get; set; }

        [StringLength(20)]
        public string DELEGATION { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ID_GARE { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DATE_APPLICATION { get; set; }

        public decimal? ID_SHIFT { get; set; }

        [StringLength(3)]
        public string VOIE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal MAT_PEAGER { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal MAT_SUPER { get; set; }

        [StringLength(100)]
        public string OBSERVATION { get; set; }

        [StringLength(6)]
        public string MAT_ADMIN { get; set; }
    }
}
