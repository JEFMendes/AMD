namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EncomendasFrita
    {
        public int? Plano { get; set; }

        [Required]
        [StringLength(50)]
        public string Tipo { get; set; }

        public int Paletes { get; set; }

        public int? Rolli { get; set; }

        public bool? SemAcesso { get; set; }

        public int? Peso { get; set; }

        public bool? Ridelle { get; set; }

        public int? Cliente { get; set; }

        [StringLength(10)]
        public string Encomenda { get; set; }

        public int ID { get; set; }

        public int? Semana { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        public virtual Cliente Cliente1 { get; set; }

        public virtual Encomenda Encomenda1 { get; set; }

        public virtual PlanoSemanal PlanoSemanal { get; set; }
    }
}
