namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TYPE_CARRIL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string idCarril { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string numCarril { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string idPlaza { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string numTramo { get; set; }

        public virtual TYPE_PLAZA TYPE_PLAZA { get; set; }
    }
}
