namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_LSTDEVIS")]
    public partial class PTM_LSTDEVIS
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_LSTDEVIS { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string CODE_DEVISE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string LIBELLE_DEVISE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal TAUX_DEVISE { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal COUPURE1 { get; set; }

        public decimal? COUPURE2 { get; set; }

        public decimal? COUPURE3 { get; set; }

        public decimal? COUPURE4 { get; set; }

        public decimal? COUPURE5 { get; set; }

        public decimal? ORDRE_DEV { get; set; }
    }
}
