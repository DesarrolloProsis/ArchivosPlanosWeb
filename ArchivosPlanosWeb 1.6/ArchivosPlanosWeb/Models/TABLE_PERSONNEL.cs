namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_PERSONNEL")]
    public partial class TABLE_PERSONNEL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string ID_FONCTION { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_PERSONNEL { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DATE_PEC_PERSONNEL { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(6)]
        public string MATRICULE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string NOM { get; set; }

        [StringLength(8)]
        public string CODE_ACCES { get; set; }

        [StringLength(20)]
        public string PRENOM { get; set; }

        [StringLength(44)]
        public string SITE_AUTORISES { get; set; }

        [StringLength(2)]
        public string NB_SITE { get; set; }

        [StringLength(6)]
        public string MATRICULE_SL { get; set; }

        [StringLength(8)]
        public string NUMERO_CAPUFE { get; set; }
    }
}
