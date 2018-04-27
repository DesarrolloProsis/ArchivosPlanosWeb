namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.GPOS_TYPE_OBS_SEQUENCE")]
    public partial class GPOS_TYPE_OBS_SEQUENCE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string ID_OBS_SEQUENCE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string SEL_OBS_SEQUENCE { get; set; }

        [StringLength(30)]
        public string LABEL_OBS_SEQUENCE { get; set; }

        [StringLength(30)]
        public string LABEL_OBS_SEQUENCE_L2 { get; set; }
    }
}
