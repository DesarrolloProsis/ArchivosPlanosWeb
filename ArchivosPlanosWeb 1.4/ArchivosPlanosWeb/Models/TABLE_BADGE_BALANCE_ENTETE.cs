namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_BADGE_BALANCE_ENTETE")]
    public partial class TABLE_BADGE_BALANCE_ENTETE
    {
        [Key]
        public decimal VERSION_BADGE_BALANCE { get; set; }

        public DateTime? DATE_CREATION_BADGE_BALANCE { get; set; }

        public DateTime? DATE_PEC_BADGE_BALANCE { get; set; }
    }
}
