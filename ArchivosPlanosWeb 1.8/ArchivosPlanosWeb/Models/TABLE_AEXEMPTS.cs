namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_AEXEMPTS")]
    public partial class TABLE_AEXEMPTS
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_AEXEMPTS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string ID_VEHICULE { get; set; }

        public decimal? ID_CLASSE { get; set; }

        [StringLength(15)]
        public string IMMATRICULATION { get; set; }

        [StringLength(10)]
        public string PROPRIETAIRE { get; set; }

        [StringLength(15)]
        public string NUM_PATRIMOINE { get; set; }

        [StringLength(10)]
        public string MARQUE { get; set; }

        [StringLength(10)]
        public string MODELE { get; set; }

        [StringLength(10)]
        public string COULEUR { get; set; }

        [StringLength(10)]
        public string PREFIXE { get; set; }

        [StringLength(25)]
        public string MUNICIPALITE { get; set; }

        [StringLength(2)]
        public string ETAT { get; set; }

        [StringLength(3)]
        public string TYPE { get; set; }
    }
}
