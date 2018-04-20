namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_PERIODE_TARIF_ENTETE")]
    public partial class TABLE_PERIODE_TARIF_ENTETE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATE_CREATION { get; set; }

        public DateTime? DATE_PEC { get; set; }
    }
}
