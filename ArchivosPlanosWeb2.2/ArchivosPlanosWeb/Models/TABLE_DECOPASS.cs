namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_DECOPASS")]
    public partial class TABLE_DECOPASS
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_DECOPASS { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal CODE_TRAJET { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal ID_CLASSE { get; set; }

        [StringLength(40)]
        public string NOM_TRAJET { get; set; }

        public decimal? NB_PASSAGE_1 { get; set; }

        public decimal? PRIX_NB_PASSAGE_1 { get; set; }

        public decimal? NB_PASSAGE_2 { get; set; }

        public decimal? PRIX_NB_PASSAGE_2 { get; set; }

        public decimal? NB_PASSAGE_3 { get; set; }

        public decimal? PRIX_NB_PASSAGE_3 { get; set; }

        public decimal? NB_PASSAGE_4 { get; set; }

        public decimal? PRIX_NB_PASSAGE_4 { get; set; }

        public decimal? NB_PASSAGE_5 { get; set; }

        public decimal? PRIX_NB_PASSAGE_5 { get; set; }

        public decimal? DUREE_VAL_1 { get; set; }

        public decimal? DUREE_VAL_2 { get; set; }

        public decimal? DUREE_VAL_3 { get; set; }

        public decimal? DUREE_VAL_4 { get; set; }

        public decimal? DUREE_VAL_5 { get; set; }

        public decimal? PLAFOND_1 { get; set; }

        public decimal? PLAFOND_2 { get; set; }

        public decimal? PLAFOND_3 { get; set; }

        public decimal? PLAFOND_4 { get; set; }

        public decimal? PLAFOND_5 { get; set; }
    }
}
