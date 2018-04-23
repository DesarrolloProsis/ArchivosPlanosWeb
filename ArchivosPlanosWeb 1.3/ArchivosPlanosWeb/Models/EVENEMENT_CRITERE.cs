namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.EVENEMENT_CRITERE")]
    public partial class EVENEMENT_CRITERE
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_LIBELLE_EVENEMENT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string ID_EVENEMENT { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ID_EQUIPEMENT { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string ID_VOIE { get; set; }

        public decimal? STATUS_EVENEMENT { get; set; }

        [StringLength(1)]
        public string SELECTION { get; set; }
    }
}
