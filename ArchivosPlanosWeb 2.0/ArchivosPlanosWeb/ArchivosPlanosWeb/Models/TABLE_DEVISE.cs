namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_DEVISE")]
    public partial class TABLE_DEVISE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string ID_DEVISE { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_DEVISE { get; set; }

        [StringLength(20)]
        public string LIBELLE_DEVISE { get; set; }

        public decimal? TAUX_DEVISE { get; set; }

        public decimal? COUP1 { get; set; }

        public decimal? COUP2 { get; set; }

        public decimal? COUP3 { get; set; }

        public decimal? COUP4 { get; set; }

        public decimal? COUP5 { get; set; }
    }
}
