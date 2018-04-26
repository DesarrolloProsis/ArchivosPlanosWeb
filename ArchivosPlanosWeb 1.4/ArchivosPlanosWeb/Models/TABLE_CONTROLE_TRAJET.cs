namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_CONTROLE_TRAJET")]
    public partial class TABLE_CONTROLE_TRAJET
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_CONTROLE_TRAJET { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal CODE_TRAJET { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_1 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_2 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_3 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_4 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_5 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_6 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_7 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_8 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_9 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_10 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_11 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_12 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_13 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_14 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_15 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_16 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_17 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_18 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_19 { get; set; }

        [StringLength(4)]
        public string ID_RESEAU_GARE_20 { get; set; }
    }
}
