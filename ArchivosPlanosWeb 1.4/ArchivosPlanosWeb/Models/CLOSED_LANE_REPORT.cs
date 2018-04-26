namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.CLOSED_LANE_REPORT")]
    public partial class CLOSED_LANE_REPORT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string ID_NETWORK { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2)]
        public string ID_PLAZA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string ID_LANE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string LANE { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime BEGIN_DHM { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime END_DHM { get; set; }

        [StringLength(8)]
        public string BAG_NUMBER { get; set; }

        [StringLength(1)]
        public string REPORT_FLAG { get; set; }

        public DateTime? GENERATION_DHM { get; set; }
    }
}
