namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_SUBSCRIPTION_LOCK")]
    public partial class GPOS_SUBSCRIPTION_LOCK
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ID_SUBSCRIPTION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string ID_LOCK { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime LOCK_DHM { get; set; }
    }
}
