namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_CONSTANTE")]
    public partial class TABLE_CONSTANTE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_CONSTANTE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ID_GARE { get; set; }

        [StringLength(20)]
        public string LIBELLE_GARE { get; set; }
    }
}
