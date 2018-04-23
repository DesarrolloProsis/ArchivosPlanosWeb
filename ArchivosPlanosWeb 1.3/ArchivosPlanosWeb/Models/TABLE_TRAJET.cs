namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_TRAJET")]
    public partial class TABLE_TRAJET
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_TRAJET { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_RESEAU_SORTIE { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string ID_GARE_SORTIE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string ID_RESEAU_ENTREE { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string ID_GARE_ENTREE { get; set; }

        public decimal? CODE_SENS { get; set; }

        public decimal? DISTANCE { get; set; }

        public decimal? TEMPS_MINI { get; set; }

        public decimal? TEMPS_MAXI { get; set; }

        public decimal? TEMPS_MINI_CL1 { get; set; }

        public decimal? TEMPS_MAXI_CL1 { get; set; }

        public decimal? TEMPS_MINI_CL2 { get; set; }

        public decimal? TEMPS_MAXI_CL2 { get; set; }

        public decimal? TEMPS_MINI_CL3 { get; set; }

        public decimal? TEMPS_MAXI_CL3 { get; set; }

        public decimal? TEMPS_MINI_CL4 { get; set; }

        public decimal? TEMPS_MAXI_CL4 { get; set; }

        public decimal? TEMPS_MINI_CL5 { get; set; }

        public decimal? TEMPS_MAXI_CL5 { get; set; }

        public decimal? TEMPS_MINI_CL6 { get; set; }

        public decimal? TEMPS_MAXI_CL6 { get; set; }

        public decimal? TEMPS_MINI_CL7 { get; set; }

        public decimal? TEMPS_MAXI_CL7 { get; set; }

        public decimal? TEMPS_MINI_CL8 { get; set; }

        public decimal? TEMPS_MAXI_CL8 { get; set; }

        public decimal? TEMPS_MINI_CL9 { get; set; }

        public decimal? TEMPS_MAXI_CL9 { get; set; }

        public decimal? TEMPS_MINI_CL10 { get; set; }

        public decimal? TEMPS_MAXI_CL10 { get; set; }

        public decimal? TEMPS_MINI_CL11 { get; set; }

        public decimal? TEMPS_MAXI_CL11 { get; set; }

        public decimal? TEMPS_MINI_CL12 { get; set; }

        public decimal? TEMPS_MAXI_CL12 { get; set; }

        public decimal? TEMPS_MINI_CL13 { get; set; }

        public decimal? TEMPS_MAXI_CL13 { get; set; }

        public decimal? TEMPS_MINI_CL14 { get; set; }

        public decimal? TEMPS_MAXI_CL14 { get; set; }

        public decimal? TEMPS_MINI_CL15 { get; set; }

        public decimal? TEMPS_MAXI_CL15 { get; set; }

        public decimal? TEMPS_MINI_CL16 { get; set; }

        public decimal? TEMPS_MAXI_CL16 { get; set; }

        public decimal? TEMPS_MINI_CL17 { get; set; }

        public decimal? TEMPS_MAXI_CL17 { get; set; }

        public decimal? TEMPS_MINI_CL18 { get; set; }

        public decimal? TEMPS_MAXI_CL18 { get; set; }

        public decimal? TEMPS_MINI_CL19 { get; set; }

        public decimal? TEMPS_MAXI_CL19 { get; set; }

        public decimal? TEMPS_MINI_CL20 { get; set; }

        public decimal? TEMPS_MAXI_CL20 { get; set; }
    }
}
