namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_CUSTOMER_LOCK")]
    public partial class GPOS_CUSTOMER_LOCK
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string ID_CUSTOMER { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string ID_LOCK { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime LOCK_DHM { get; set; }
    }
}
