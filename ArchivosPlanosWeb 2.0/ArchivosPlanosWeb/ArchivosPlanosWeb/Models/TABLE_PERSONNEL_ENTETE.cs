namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_PERSONNEL_ENTETE")]
    public partial class TABLE_PERSONNEL_ENTETE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_PERSONNEL { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATE_PEC_PERSONNEL { get; set; }

        public DateTime? DATE_CREATION_PERSONNEL { get; set; }
    }
}
