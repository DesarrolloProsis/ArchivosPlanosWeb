namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_CONTROLE_TRAJET_ENTETE")]
    public partial class TABLE_CONTROLE_TRAJET_ENTETE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_CONTROLE_TRAJET { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATE_CREATION_CONTROLE_TRAJET { get; set; }

        public DateTime? DATE_PEC_CONTROLE_TRAJET { get; set; }
    }
}
