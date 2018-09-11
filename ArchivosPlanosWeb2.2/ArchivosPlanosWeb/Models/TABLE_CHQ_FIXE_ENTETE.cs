namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_CHQ_FIXE_ENTETE")]
    public partial class TABLE_CHQ_FIXE_ENTETE
    {
        [Key]
        public decimal VERSION_CHQ_FIXE { get; set; }

        public DateTime? DATE_CREATION_CHQ_FIXE { get; set; }

        public DateTime? DATE_PEC_CHQ_FIXE { get; set; }
    }
}
