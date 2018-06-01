namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_CONSTANTE_ENTETE")]
    public partial class TABLE_CONSTANTE_ENTETE
    {
        [Key]
        public decimal VERSION_CONSTANTE { get; set; }

        public DateTime? DATE_CREATION_CONSTANTE { get; set; }

        public DateTime? DATE_PEC_CONSTANTE { get; set; }
    }
}
