namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.LANE_ASSIGN")]
    public partial class LANE_ASSIGN
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
        [StringLength(3)]
        public string ID_LANE { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime MSG_DHM { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string LANE_TYPE { get; set; }

        public decimal? SHIFT_NUMBER { get; set; }

        [StringLength(2)]
        public string OPERATION_ID { get; set; }

        [StringLength(6)]
        public string STAFF_NUMBER { get; set; }

        public decimal? JOB_NUMBER { get; set; }

        public DateTime? ASSIGN_DHM { get; set; }

        public decimal? IN_CHARGE_SHIFT_NUMBER { get; set; }

        [StringLength(20)]
        public string DELEGATION { get; set; }

        [StringLength(6)]
        public string MAT_ADMIN { get; set; }
    }
}
