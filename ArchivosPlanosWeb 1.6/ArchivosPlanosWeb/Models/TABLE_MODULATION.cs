namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_MODULATION")]
    public partial class TABLE_MODULATION
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string TAB_ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string TAB_ID_GARE { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal VERSION_MODULATION { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string ID_GARE { get; set; }

        [StringLength(1)]
        public string C01_1 { get; set; }

        [StringLength(1)]
        public string C01_2 { get; set; }

        [StringLength(1)]
        public string C02_1 { get; set; }

        [StringLength(1)]
        public string C02_2 { get; set; }

        [StringLength(1)]
        public string C03_1 { get; set; }

        [StringLength(1)]
        public string C03_2 { get; set; }

        [StringLength(1)]
        public string C04_1 { get; set; }

        [StringLength(1)]
        public string C04_2 { get; set; }

        [StringLength(1)]
        public string C05_1 { get; set; }

        [StringLength(1)]
        public string C05_2 { get; set; }

        [StringLength(1)]
        public string C06_1 { get; set; }

        [StringLength(1)]
        public string C06_2 { get; set; }

        [StringLength(1)]
        public string C07_1 { get; set; }

        [StringLength(1)]
        public string C07_2 { get; set; }

        [StringLength(1)]
        public string C08_1 { get; set; }

        [StringLength(1)]
        public string C08_2 { get; set; }

        [StringLength(1)]
        public string C09_1 { get; set; }

        [StringLength(1)]
        public string C09_2 { get; set; }

        [StringLength(1)]
        public string C10_1 { get; set; }

        [StringLength(1)]
        public string C10_2 { get; set; }
    }
}
