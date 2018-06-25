namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_CHQ_FIXE")]
    public partial class TABLE_CHQ_FIXE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_CHQ_FIXE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string LIBELLE_CHQ_FIXE { get; set; }

        public decimal? MONTANT_CHQ_FIXE { get; set; }
    }
}
