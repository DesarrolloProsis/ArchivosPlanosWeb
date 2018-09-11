namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_DISCOUNT_ENTETE")]
    public partial class TABLE_DISCOUNT_ENTETE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_DISCOUNT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_NETWORK { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ID_PLAZA { get; set; }

        public DateTime? DATE_CREATION_DISCOUNT { get; set; }

        public DateTime? DATE_PEC_DISCOUNT { get; set; }
    }
}
