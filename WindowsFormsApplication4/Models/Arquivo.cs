namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Arquivo")]
    public partial class Arquivo
    {
        [Key]
        public int NumeroCarga { get; set; }

        [StringLength(50)]
        public string Transportador { get; set; }

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
    }
}
