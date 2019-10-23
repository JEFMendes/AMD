namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [Required]
        [StringLength(50)]
        public string Cliente { get; set; }

        [Key]
        [StringLength(10)]
        public string CodEncomenda { get; set; }

        public int? QtPalSec { get; set; }

        public int? QtRollSec { get; set; }

        public int? QtPalFres { get; set; }

        public int? QtRollFres { get; set; }

        public int? QtPalCong { get; set; }

        public int? QtRollCong { get; set; }

        public decimal? Peso { get; set; }

        public bool? Ridelle { get; set; }

        public bool? Manual { get; set; }

        public TimeSpan HoraCarga { get; set; }
    }
}
