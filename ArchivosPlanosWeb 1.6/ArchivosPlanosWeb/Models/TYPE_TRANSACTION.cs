namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_TRANSACTION")]
    public partial class TYPE_TRANSACTION
    {
        [Key]
        [StringLength(2)]
        public string ID_TRX { get; set; }

        [StringLength(35)]
        public string TRX_LABEL { get; set; }

        [StringLength(35)]
        public string TRX_LABEL_L2 { get; set; }

        [StringLength(1)]
        public string DISPLAY_INDICATOR { get; set; }
    }
}
