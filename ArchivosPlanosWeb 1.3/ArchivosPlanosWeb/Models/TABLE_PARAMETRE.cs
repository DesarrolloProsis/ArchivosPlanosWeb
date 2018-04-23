namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_PARAMETRE")]
    public partial class TABLE_PARAMETRE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_PARAMETRE { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime HEURE_DEBUT_PEAGE { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal TOLERANCE_HEURE { get; set; }

        public decimal? ECART_OK_MONNAIE1 { get; set; }

        public decimal? ECART_OK_MONNAIE2 { get; set; }

        public decimal? ECART_OK_MONNAIE3 { get; set; }

        public decimal? ECART_OK_MONNAIE4 { get; set; }

        public decimal? ECART_OK_CHQ { get; set; }

        public decimal? ECART_OK_JETON { get; set; }

        public decimal? ECART_OK_RDD { get; set; }

        public decimal? ECART_OK_GRATUIT { get; set; }
    }
}
