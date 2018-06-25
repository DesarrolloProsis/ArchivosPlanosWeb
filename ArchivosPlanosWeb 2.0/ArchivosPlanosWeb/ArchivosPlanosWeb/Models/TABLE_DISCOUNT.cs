namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_DISCOUNT")]
    public partial class TABLE_DISCOUNT
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_DISCOUNT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_NETWORK { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ID_PLAZA { get; set; }

        [StringLength(4)]
        public string ID_PRODUCT { get; set; }

        public decimal? THRESHOLD_TYPE { get; set; }

        public decimal? THRESHOLD_VALUE { get; set; }

        public decimal? DISCOUNT { get; set; }
    }
}
