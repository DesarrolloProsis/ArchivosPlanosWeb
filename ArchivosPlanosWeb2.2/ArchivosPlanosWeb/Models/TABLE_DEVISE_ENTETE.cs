namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_DEVISE_ENTETE")]
    public partial class TABLE_DEVISE_ENTETE
    {
        [Key]
        public decimal VERSION_DEVISE { get; set; }

        public DateTime? DATE_CREATION_DEVISE { get; set; }

        public DateTime? DATE_PEC_DEVISE { get; set; }
    }
}
