namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_OBS_TT")]
    public partial class TYPE_OBS_TT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string ID_OBS_TT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string SEL_OBS_TT { get; set; }

        [StringLength(30)]
        public string LIBELLE_OBS_TT { get; set; }

        [StringLength(30)]
        public string LIBELLE_OBS_TT_L2 { get; set; }
    }
}
