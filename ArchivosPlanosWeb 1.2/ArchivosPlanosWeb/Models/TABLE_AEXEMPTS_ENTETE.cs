namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TABLE_AEXEMPTS_ENTETE")]
    public partial class TABLE_AEXEMPTS_ENTETE
    {
        [Key]
        [Column(Order = 0)]
        public decimal VERSION_AEXEMPTS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_RESEAU { get; set; }

        public DateTime? DATE_CREATION_AEXEMPTS { get; set; }

        public DateTime? DATE_PEC_AEXEMPTS { get; set; }
    }
}
