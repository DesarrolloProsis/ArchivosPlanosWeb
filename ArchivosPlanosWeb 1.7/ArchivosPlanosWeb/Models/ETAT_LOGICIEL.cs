namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.ETAT_LOGICIEL")]
    public partial class ETAT_LOGICIEL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_GARE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string ID_VOIE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string VOIE { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime DATE_ETAT_LOGICIEL { get; set; }

        [StringLength(3)]
        public string VERSION_LOGICIEL { get; set; }

        public decimal? TARIF_EC { get; set; }

        public decimal? TARIF_FU { get; set; }

        public decimal? TRAJET_EC { get; set; }

        public decimal? TRAJET_FU { get; set; }

        public decimal? MODULA_EC { get; set; }

        public decimal? MODULA_FU { get; set; }

        public decimal? DEVISE_EC { get; set; }

        public decimal? DEVISE_FU { get; set; }

        public decimal? ACCMPM_EC { get; set; }

        public decimal? ACCMPM_FU { get; set; }

        public decimal? CHQFIX_EC { get; set; }

        public decimal? CHQFIX_FU { get; set; }

        public decimal? AGENTS_EC { get; set; }

        public decimal? AGENTS_FU { get; set; }

        public decimal? OPPOS1_EC { get; set; }

        public decimal? OPPOS1_FU { get; set; }

        public decimal? OPPOS2_EC { get; set; }

        public decimal? OPPOS2_FU { get; set; }

        public decimal? OPPTLP_EC { get; set; }

        public decimal? OPPTLP_FU { get; set; }

        public decimal? TCONST_EC { get; set; }

        public decimal? TCONST_FU { get; set; }

        public decimal? TMOTIF_EC { get; set; }

        public decimal? TMOTIF_FU { get; set; }

        public decimal? TABLE1_EC { get; set; }

        public decimal? TABLE1_FU { get; set; }

        public decimal? TABLE2_EC { get; set; }

        public decimal? TABLE2_FU { get; set; }

        public decimal? TABLE3_EC { get; set; }

        public decimal? TABLE3_FU { get; set; }

        public decimal? TABLE4_EC { get; set; }

        public decimal? TABLE4_FU { get; set; }

        public decimal? TABLE5_EC { get; set; }

        public decimal? TABLE5_FU { get; set; }

        public decimal? TABLE6_EC { get; set; }

        public decimal? TABLE6_FU { get; set; }

        public decimal? TABLE7_EC { get; set; }

        public decimal? TABLE7_FU { get; set; }

        public decimal? TABLE8_EC { get; set; }

        public decimal? TABLE8_FU { get; set; }
    }
}
