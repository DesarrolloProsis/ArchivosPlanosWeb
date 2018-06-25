namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_PERIODE_TARIF")]
    public partial class TABLE_PERIODE_TARIF
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATE_DEBUT { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DATE_FIN { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string CODE_TARIF { get; set; }

        [StringLength(25)]
        public string COMMENTAIRE { get; set; }
    }
}
