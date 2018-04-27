namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_MODULATION_ENTETE")]
    public partial class TABLE_MODULATION_ENTETE
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
        public decimal VERSION_MODULATION { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DATE_CREATION_MODULATION { get; set; }

        public DateTime? DATE_PEC_MODULATION { get; set; }
    }
}
