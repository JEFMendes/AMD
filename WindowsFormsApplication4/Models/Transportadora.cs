namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transportadora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transportadora()
        {
            Encomendas = new HashSet<Encomenda>();
            PlanoSemanals = new HashSet<PlanoSemanal>();
            Precos = new HashSet<Preco>();
        }

        [Key]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Morada { get; set; }

        public int? Cod_Postal { get; set; }

        public int? Telefone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? ValorParagSupl { get; set; }

        [StringLength(50)]
        public string Zona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Encomenda> Encomendas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanoSemanal> PlanoSemanals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Preco> Precos { get; set; }
    }
}
