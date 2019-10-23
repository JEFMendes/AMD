namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanoSemanal")]
    public partial class PlanoSemanal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanoSemanal()
        {
            EncomendasFritas = new HashSet<EncomendasFrita>();
        }

        [Key]
        public int NumeroCarga { get; set; }

        [StringLength(50)]
        public string Transportador { get; set; }

        public int? Peso { get; set; }

        public int? CapacidadePaletes { get; set; }

        [StringLength(50)]
        public string Comercial { get; set; }

        [StringLength(50)]
        public string Zona { get; set; }

        public bool? Secos { get; set; }

        public bool? Frescos { get; set; }

        public bool? Congelados { get; set; }

        [StringLength(50)]
        public string DiasDeCarga { get; set; }

        [StringLength(50)]
        public string HoraDeCarga { get; set; }

        [StringLength(50)]
        public string Cais { get; set; }

        [StringLength(50)]
        public string Veiculo { get; set; }

        public bool? Ridelle { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public bool? EntradaSemAcesso { get; set; }

        [StringLength(50)]
        public string NumeroEncomendas { get; set; }

        public int? Semana { get; set; }

        public virtual Comerciai Comerciai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncomendasFrita> EncomendasFritas { get; set; }

        public virtual Transportadora Transportadora { get; set; }
    }
}
