namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_PARAMETRE_ENTETE")]
    public partial class TABLE_PARAMETRE_ENTETE
    {
        [Key]
        public decimal VERSION_PARAMETRE { get; set; }

        public DateTime? DATE_CREATION_PARAMETRE { get; set; }

        public DateTime? DATE_PEC_PARAMETRE { get; set; }
    }
}
