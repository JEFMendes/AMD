namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            EncomendasFritas = new HashSet<EncomendasFrita>();
            Encomendas = new HashSet<Encomenda>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numero { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Morada { get; set; }

        [StringLength(50)]
        public string Telefone { get; set; }

        [Required]
        [StringLength(50)]
        public string Zona { get; set; }

        [StringLength(50)]
        public string Comercial { get; set; }

        public bool? Ridelle { get; set; }

        public bool? Entrega_pelo_comercial { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public bool? Entrada_sem_acesso { get; set; }

        public int Codigo_postal { get; set; }

        [StringLength(50)]
        public string Opcao_zona_2 { get; set; }

        [StringLength(50)]
        public string Opcao_zona_3 { get; set; }

        public bool? Entrega_Attalens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncomendasFrita> EncomendasFritas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Encomenda> Encomendas { get; set; }

        public virtual Distancia Distancia { get; set; }

        public virtual Distancia Distancia1 { get; set; }

        public virtual Distancia Distancia2 { get; set; }
    }
}
