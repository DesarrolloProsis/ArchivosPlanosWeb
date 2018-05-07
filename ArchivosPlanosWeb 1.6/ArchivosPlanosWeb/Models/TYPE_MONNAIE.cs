namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_MONNAIE")]
    public partial class TYPE_MONNAIE
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_MONNAIE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ORDRE_MONNAIE { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal MONNAIE_REF { get; set; }

        [StringLength(30)]
        public string LIBELLE_MONNAIE { get; set; }

        [StringLength(30)]
        public string LIBELLE_MONNAIE_L2 { get; set; }
    }
}
