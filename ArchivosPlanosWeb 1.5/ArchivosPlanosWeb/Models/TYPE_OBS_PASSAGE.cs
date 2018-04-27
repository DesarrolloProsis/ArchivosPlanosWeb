namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_OBS_PASSAGE")]
    public partial class TYPE_OBS_PASSAGE
    {
        [Key]
        [StringLength(1)]
        public string ID_OBS_PASSAGE { get; set; }

        [StringLength(30)]
        public string LIBELLE_OBS_PASSAGE { get; set; }

        [StringLength(30)]
        public string LIBELLE_OBS_PASSAGE_L2 { get; set; }

        [StringLength(1)]
        public string SEL_OBS_PASSAGE { get; set; }
    }
}
