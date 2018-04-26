namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.SEQ_VOIE_TOD")]
    public partial class SEQ_VOIE_TOD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string VOIE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal NUM_SEQUENCE { get; set; }
    }
}
