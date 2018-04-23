namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_LSTPRINT")]
    public partial class TABLE_LSTPRINT
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
        public decimal VERSION_LSTPRINT { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal NUMERO_LIGNE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal CADRAGE { get; set; }

        [StringLength(44)]
        public string LIGNE { get; set; }
    }
}
