namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_TYPE_OBS_MOP")]
    public partial class GPOS_TYPE_OBS_MOP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_OBS_MOP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string SEL_OBS_MOP { get; set; }

        [StringLength(30)]
        public string LABEL_OBS_MOP { get; set; }

        [StringLength(30)]
        public string LABEL_OBS_MOP_L2 { get; set; }
    }
}
