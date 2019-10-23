namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Precos")]
    public partial class Preco
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string zona { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string transportadora { get; set; }

        [Column("km max depois de Attalens")]
        [StringLength(50)]
        public string km_max_depois_de_Attalens { get; set; }

        [StringLength(50)]
        public string Pal3 { get; set; }

        [StringLength(50)]
        public string Pal8 { get; set; }

        [StringLength(50)]
        public string Pal15 { get; set; }

        [StringLength(50)]
        public string Pal32 { get; set; }

        public virtual Distancia Distancia { get; set; }

        public virtual Transportadora Transportadora1 { get; set; }
    }
}
