namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Palete
    {
        [Key]
        [StringLength(50)]
        public string Transportadora { get; set; }

        public int? QtEurPaletes { get; set; }
    }
}
