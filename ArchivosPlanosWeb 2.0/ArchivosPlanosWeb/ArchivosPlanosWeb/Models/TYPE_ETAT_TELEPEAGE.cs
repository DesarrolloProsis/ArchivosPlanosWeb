namespace ArchivosPlanosWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GEADBA.TYPE_ETAT_TELEPEAGE")]
    public partial class TYPE_ETAT_TELEPEAGE
    {
        [Key]
        public decimal ID_ETAT_TELEPEAGE { get; set; }

        [StringLength(30)]
        public string LIBELLE_ETAT_TELEPEAGE { get; set; }
    }
}
