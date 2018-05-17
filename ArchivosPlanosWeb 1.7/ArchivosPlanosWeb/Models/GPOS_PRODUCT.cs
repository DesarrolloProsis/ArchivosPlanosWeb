namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_PRODUCT")]
    public partial class GPOS_PRODUCT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_PRODUCT_TYPE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string ID_PRODUCT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string PRODUCT_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal VERSION_PRODUCT { get; set; }
    }
}
