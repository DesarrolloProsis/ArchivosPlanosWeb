namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.SIX_MIN_TRAFFIC")]
    public partial class SIX_MIN_TRAFFIC
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
        public string ID_LANE_TYPE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string ID_LANE { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime SIX_MIN_TRAFFIC_DHM { get; set; }

        public decimal? TRAFFIC_CL { get; set; }
    }
}
