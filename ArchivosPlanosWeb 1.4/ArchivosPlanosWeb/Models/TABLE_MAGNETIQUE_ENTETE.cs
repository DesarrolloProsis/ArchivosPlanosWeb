namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_MAGNETIQUE_ENTETE")]
    public partial class TABLE_MAGNETIQUE_ENTETE
    {
        [Key]
        public decimal VERSION_MAGNETIQUE { get; set; }

        public DateTime? DATE_CREATION_MAGNETIQUE { get; set; }

        public DateTime? DATE_PEC_MAGNETIQUE { get; set; }
    }
}
