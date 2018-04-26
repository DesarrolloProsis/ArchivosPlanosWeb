namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_DECOPASS_ENTETE")]
    public partial class TABLE_DECOPASS_ENTETE
    {
        [Key]
        public decimal VERSION_DECOPASS { get; set; }

        public DateTime? DATE_CREATION_DECOPASS { get; set; }

        public DateTime? DATE_PEC_DECOPASS { get; set; }
    }
}
