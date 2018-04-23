namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_CONSTANT_B")]
    public partial class PTM_CONSTANT_B
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_CONSTANT_B { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ID_GARE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LIBELLE_GARE { get; set; }
    }
}
