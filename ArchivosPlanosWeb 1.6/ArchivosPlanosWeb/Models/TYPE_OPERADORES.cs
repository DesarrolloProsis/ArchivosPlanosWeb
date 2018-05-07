namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TYPE_OPERADORES
    {
        [Key]
        public int idOperador { get; set; }

        [Required]
        [StringLength(100)]
        public string numGea { get; set; }

        [Required]
        [StringLength(100)]
        public string numCapufe { get; set; }
    }
}
