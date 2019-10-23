namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comerciai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comerciai()
        {
            PlanoSemanals = new HashSet<PlanoSemanal>();
        }

        [Key]
        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string Veiculo { get; set; }

        [Required]
        [StringLength(50)]
        public string Custo_por_hora { get; set; }

        [Required]
        public string Zonas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanoSemanal> PlanoSemanals { get; set; }
    }
}
