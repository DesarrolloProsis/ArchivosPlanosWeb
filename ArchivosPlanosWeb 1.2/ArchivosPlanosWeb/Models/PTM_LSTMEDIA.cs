namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.PTM_LSTMEDIA")]
    public partial class PTM_LSTMEDIA
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_LSTMEDIA { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal ID_NETWORK { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string ID_MEDIA_TYPE_LIST { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string MEDIA_TYPE_LIST_NAME { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal MEDIA_TYPE_LIST_COUNT { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(40)]
        public string MEDIA_TYPE_LIST { get; set; }
    }
}
