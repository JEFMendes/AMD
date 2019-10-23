namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Login
    {
        [Key]
        public int NumeroLogin { get; set; }

        [StringLength(50)]
        public string User { get; set; }

        [StringLength(50)]
        public string DataLogin { get; set; }
    }
}
