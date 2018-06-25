namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_LSTABONN")]
    public partial class PTM_LSTABONN
    {
        [Key]
        [Column(Order = 0)]
        public decimal ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal VERSION_LSTABONN { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(19)]
        public string NUMERO_CARTE { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal CODE_CONTROLE { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal CLASSE { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime DATE_VALIDITEE { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime DATE_PEREMPTION { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(12)]
        public string NO_ABONNEMENT_CARTE { get; set; }

        public decimal? ID_TYPE_CARTE { get; set; }

        [StringLength(4)]
        public string CODE_MODELE { get; set; }

        public decimal? ID_MONNAIE_UTILISEE { get; set; }

        [StringLength(19)]
        public string NUM_CARTE_BANCAIRE { get; set; }

        [StringLength(4)]
        public string DATE_EXPIRE { get; set; }
    }
}
