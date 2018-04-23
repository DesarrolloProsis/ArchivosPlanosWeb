namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.ACCES_ECRAN_APPLIS")]
    public partial class ACCES_ECRAN_APPLIS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string ID_APPLICATION { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string CODE_ECRAN { get; set; }

        public decimal? ORDRE_AFFICHAGE { get; set; }

        [StringLength(40)]
        public string LIBELLE_MENU { get; set; }

        [StringLength(40)]
        public string LIBELLE_MENU_L2 { get; set; }

        [StringLength(1)]
        public string TYPE_CODE_ECRAN { get; set; }

        [StringLength(1)]
        public string I0 { get; set; }

        [StringLength(1)]
        public string I1 { get; set; }

        [StringLength(1)]
        public string I2 { get; set; }

        [StringLength(1)]
        public string I3 { get; set; }

        [StringLength(1)]
        public string I4 { get; set; }

        [StringLength(1)]
        public string I5 { get; set; }

        [StringLength(1)]
        public string I6 { get; set; }

        [StringLength(1)]
        public string I7 { get; set; }

        [StringLength(1)]
        public string I8 { get; set; }

        [StringLength(1)]
        public string I9 { get; set; }

        [StringLength(1)]
        public string M0 { get; set; }

        [StringLength(1)]
        public string M1 { get; set; }

        [StringLength(1)]
        public string M2 { get; set; }

        [StringLength(1)]
        public string M3 { get; set; }

        [StringLength(1)]
        public string M4 { get; set; }

        [StringLength(1)]
        public string M5 { get; set; }

        [StringLength(1)]
        public string M6 { get; set; }

        [StringLength(1)]
        public string M7 { get; set; }

        [StringLength(1)]
        public string M8 { get; set; }

        [StringLength(1)]
        public string M9 { get; set; }

        [StringLength(1)]
        public string V0 { get; set; }

        [StringLength(1)]
        public string V1 { get; set; }

        [StringLength(1)]
        public string V2 { get; set; }

        [StringLength(1)]
        public string V3 { get; set; }

        [StringLength(1)]
        public string V4 { get; set; }

        [StringLength(1)]
        public string V5 { get; set; }

        [StringLength(1)]
        public string V6 { get; set; }

        [StringLength(1)]
        public string V7 { get; set; }

        [StringLength(1)]
        public string V8 { get; set; }

        [StringLength(1)]
        public string V9 { get; set; }
    }
}
