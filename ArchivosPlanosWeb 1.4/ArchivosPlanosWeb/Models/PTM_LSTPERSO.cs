namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_LSTPERSO")]
    public partial class PTM_LSTPERSO
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_LSTPERSO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string ID_FONCTION { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string MATRICULE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal CLE_LUHN { get; set; }

        [StringLength(20)]
        public string NOM_PERSONNEL { get; set; }

        [StringLength(10)]
        public string PRENOM_PERSONNEL { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(4)]
        public string ID_SITE_AUTORISE1 { get; set; }

        [StringLength(4)]
        public string ID_SITE_AUTORISE2 { get; set; }

        [StringLength(4)]
        public string ID_SITE_AUTORISE3 { get; set; }

        [StringLength(4)]
        public string ID_SITE_AUTORISE4 { get; set; }

        [StringLength(4)]
        public string ID_SITE_AUTORISE5 { get; set; }

        [StringLength(8)]
        public string CODE_ACCESS { get; set; }

        [StringLength(10)]
        public string ID_USER { get; set; }

        [StringLength(512)]
        public string TEMPLATE { get; set; }

        [StringLength(8)]
        public string NUMERO_CAPUFE { get; set; }
    }
}
