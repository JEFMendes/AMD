namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Encomenda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Encomenda()
        {
            EncomendasFritas = new HashSet<EncomendasFrita>();
        }

        public int Cliente { get; set; }

        [Key]
        [StringLength(10)]
        public string CodEncomenda { get; set; }

        public int? QtPalSec { get; set; }

        public int? QtRollSec { get; set; }

        public int? QtPalFres { get; set; }

        public int? QtRollFres { get; set; }

        public int? QtPalCong { get; set; }

        public int? QtRollCong { get; set; }

        public int? Peso { get; set; }

        public bool? Ridelle { get; set; }

        public bool? Manual { get; set; }

        public int Semana { get; set; }

        [Required]
        [StringLength(50)]
        public string HoraCarga { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(50)]
        public string Transportadora { get; set; }

        [StringLength(50)]
        public string Data_de_carga { get; set; }

        public bool? Secos { get; set; }

        public bool? Frescos { get; set; }

        public bool? Congelados { get; set; }

        [StringLength(50)]
        public string Armazem { get; set; }

        public int? QtPalSecArma { get; set; }

        public int? QtPalFresArma { get; set; }

        public int? QtPalCongArma { get; set; }

        public bool? Comercial { get; set; }

        [StringLength(50)]
        public string IdRolliSeco { get; set; }

        [StringLength(50)]
        public string IdRolliFres { get; set; }

        [StringLength(50)]
        public string IdRolliCong { get; set; }

        public virtual Cliente Cliente1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncomendasFrita> EncomendasFritas { get; set; }

        public virtual Transportadora Transportadora1 { get; set; }
    }
}
