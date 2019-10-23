namespace AMDManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Veiculos")]
    public partial class Veiculo
    {
        [Key]
        [StringLength(50)]
        public string Matricula { get; set; }

        public bool? Secos { get; set; }

        public bool? Frescos { get; set; }

        public bool? Congelados { get; set; }

        public int Limite_de_peso { get; set; }

        [Required]
        [StringLength(50)]
        public string Classe { get; set; }
    }
}
