namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_OPPCARTE")]
    public partial class PTM_OPPCARTE
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_OPPCARTE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(19)]
        public string NUMERO_CARTE_OPP { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal CONFISCATION_CARTE { get; set; }
    }
}
