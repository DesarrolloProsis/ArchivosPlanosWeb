namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TRANSFERT_BANQUE")]
    public partial class TRANSFERT_BANQUE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_SITE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MATRICULE { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DATE_VERSEMENT { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DATE_VALIDATION { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal NB_SACS { get; set; }
    }
}
