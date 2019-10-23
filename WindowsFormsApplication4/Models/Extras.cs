using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AMDManager.Algos;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMDManager.Models
{


    public partial class PlanoSemanal
    {
        [NotMapped]
        public double Preco
        {
            get
            {
                var Cache = IAlg.Cache;
                var context = IAlg.context;

                string key = this.Transportador + this.Zona;
                var firstOrDefault =  context.Precos.First(x => x.zona == this.Zona && x.transportadora == this.Transportador);
                if (firstOrDefault == null)
                    return -1;
                if (this.CapacidadePaletes == 5 && !string.IsNullOrEmpty(firstOrDefault.Pal3)  )
                {
                    double res = Convert.ToDouble(firstOrDefault.Pal3);
                    return res;
                }
                if (this.CapacidadePaletes == 11 && !string.IsNullOrEmpty(firstOrDefault.Pal8))
                {
                    double res = Convert.ToDouble(firstOrDefault.Pal8);
                    return res;
                }
                if (this.CapacidadePaletes == 18 && !string.IsNullOrEmpty(firstOrDefault.Pal15))
                {
                    double res = Convert.ToDouble(firstOrDefault.Pal15);
                    return res;
                }
                if (this.CapacidadePaletes == 32 && !string.IsNullOrEmpty(firstOrDefault.Pal32))
                {
                    double res = Convert.ToDouble(firstOrDefault.Pal32);
                    return res;

                }
                return -1;
            }
        }
    }

    public partial class Encomenda
    {
        [NotMapped]
        public int TotalCongelados
        {
            get
            {
                var total = (this.QtPalCong ?? 0) + (this.QtRollCong ?? 0);
                return (int) Math.Ceiling((decimal) total);
            }
        }

        [NotMapped]
        public int TotalSecos
        {
            get
            {
                var total = (this.QtPalSec ?? 0) + (this.QtRollSec ?? 0);
                return (int) Math.Ceiling((decimal) total);
            }
        }
        [NotMapped]
        public int TotalFrios
        {
            get
            {
                var total = (this.QtPalFres ?? 0) + (this.QtRollFres ?? 0);
                return (int) Math.Ceiling((decimal) total);
            }
        }
    }
}
