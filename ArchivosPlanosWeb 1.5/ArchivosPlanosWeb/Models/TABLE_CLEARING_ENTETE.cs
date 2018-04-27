namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_CLEARING_ENTETE")]
    public partial class TABLE_CLEARING_ENTETE
    {
        [Key]
        public decimal VERSION_CLEARING { get; set; }

        public DateTime? DATE_CREATION_CLEARING { get; set; }

        public DateTime? DATE_PEC_CLEARING { get; set; }
    }
}
