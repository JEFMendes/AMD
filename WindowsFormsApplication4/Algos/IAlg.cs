using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMDManager.Models;
using System.Threading;

namespace AMDManager.Algos
{

    using Microsoft.SolverFoundation.Common;
    using Microsoft.SolverFoundation.Solvers;
    using System.Configuration;
    using System.Data;
    using System.Data.Entity.Validation;
    using System.Data.SqlClient;
    using System.Globalization;

    public enum Tipo
    {
        Congelado,
        Frio,
        Seco
    }


    public class EncomendaFrita
    {
        public Encomenda Encomenda { get; set; }
        public Tipo Tipo { get; set; }
        public int Paletes { get; set; }
        public bool SemAcesso { get; set; }
        public bool Ridelle { get; set; }
        public int Cliente { get; set; }
        public int Rolli { get; internal set; }
        public int Semana { get; set; }
        public string Estado { get; set; }
        public int? Peso { get; set; }

    }


    public class PlanoFrito
    {
        public Models.PlanoSemanal PlanoSemanal;

        public int Ocupadas
        {
            get
            {
                return Encomendas.Sum(x => x.Paletes);

            }
            set { }
        }
        public List<EncomendaFrita> Encomendas = new List<EncomendaFrita>();

        public PlanoFrito(Models.PlanoSemanal x)
        {
            this.PlanoSemanal = x;
            this.Preco = PlanoSemanal.Preco;
            this.Congelados = PlanoSemanal.Congelados.HasValue && PlanoSemanal.Congelados.Value;
            this.Secos = PlanoSemanal.Secos.HasValue && PlanoSemanal.Secos.Value;
            this.Frescos = PlanoSemanal.Frescos.HasValue && PlanoSemanal.Frescos.Value;
            this.Zona = PlanoSemanal.Zona;
            this.EntradaSemAcesso = PlanoSemanal.EntradaSemAcesso.HasValue && PlanoSemanal.EntradaSemAcesso.Value;
            this.Ridelle = PlanoSemanal.Ridelle.HasValue && PlanoSemanal.Ridelle.Value;
            this.CapacidadePaletes = PlanoSemanal.CapacidadePaletes.Value;
            this.Transportadora = PlanoSemanal.Transportador;
            this.Estado = PlanoSemanal.Estado;
            this.Peso = PlanoSemanal.Peso;


        }

        public PlanoFrito(PlanoFrito x)
        {
            this.Ocupadas = x.Ocupadas;
            this.Encomendas = new List<EncomendaFrita>();
            this.Encomendas.AddRange(x.Encomendas);
            this.PlanoSemanal = x.PlanoSemanal;
            this.Preco = x.Preco;
            this.Congelados = x.Congelados;
            this.Secos = x.Secos;
            this.Frescos = x.Frescos;
            this.Zona = x.Zona;
            this.EntradaSemAcesso = x.EntradaSemAcesso;
            this.Ridelle = x.Ridelle;
            this.CapacidadePaletes = x.CapacidadePaletes;
            this.Transportadora = x.Transportadora;
            this.Estado = x.Estado;
            this.Peso = x.Peso;
        }

        public int Paragens
        {
            get
            {
                if (this.Encomendas != null)
                    return (this.Encomendas.GroupBy(x => x.Encomenda.Cliente).Count() - 1);
                else return 0;
            }
        }

        public int CapacidadePaletes { get; internal set; }
        public bool Congelados { get; internal set; }
        public int Semana { get; internal set; }
        public bool Secos { get; internal set; }
        public bool Frescos { get; internal set; }
        public string Zona { get; internal set; }
        public bool Ridelle { get; internal set; }
        public bool EntradaSemAcesso { get; internal set; }
        public string Estado { get; internal set; }
        public int? Peso { get; internal set; }

        public double Preco { get; internal set; }
        public string Transportadora { get; private set; }

        public double PrecoTotal { get
            {
                var s = new System.Collections.Generic.List<PlanoFrito>();
                s.Add(this);
                return IAlg.CalculatePrice(s);
            }
            set
            {

            }
        }

        internal double PriceWith(EncomendaFrita current)
        {
            this.Encomendas.Add(current);
            if (this.Encomendas != null && this.Encomendas.Count > 0)
            {
                int extra = (this.Encomendas.GroupBy(x => x.Cliente).Count() - 1) * 50;
                double price = this.Preco / this.CapacidadePaletes * this.Ocupadas;
                this.Encomendas.Remove(current);
                if (price <= 0)
                    return -1;
                return price + extra;
            }
            return -1;
        }
    }
    internal class IAlg
    {
        static int PlanoCount = 0;
        static int RecurCount = 0;
        static int threshold = 100;
        public static AMDModels context = new AMDModels();
        public static Dictionary<string, Preco> Cache = new Dictionary<string, Preco>();


        public double CurrentMinimum = double.MaxValue;

        private volatile IEnumerable<PlanoFrito> FinalPlans;

        public static void deleteDB()
        {
            try
            {
                // Insert in database
                string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                //string sqlTrunc = "TRUNCATE TABLE EncomendasFritas";
                //SqlCommand cmd = new SqlCommand(sqlTrunc, con);
                //cmd.ExecuteNonQuery();
                
                SqlCommand com = new SqlCommand("TRUNCATE TABLE EncomendasFritas" , con);
                com.CommandType = CommandType.Text;

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }



        public List<PlanoFrito> Execute()
        {
            deleteDB();
            PlanoCount = 0;
            RecurCount = 0;
            Cache.Clear();
            context = new AMDModels();
            // context.Encomendas.Where( x => x.QtRollCong > 5 && x.Clientes.Distancias. )
            List<Models.PlanoSemanal> plano = context.PlanoSemanals.ToList();

            var plan = plano.Select(x => new PlanoFrito(x)).ToList();
            List<EncomendaFrita> regisotSemanal = new List<EncomendaFrita>();



            var encomendas = context.Encomendas.ToList();

            foreach (var enc in encomendas)
            {
                if (enc.Estado == "Arquivado")
                    continue;


                if (enc.QtRollCong > 0 || enc.QtPalCong > 0)
                {
                    var encoF = new EncomendaFrita();
                    encoF.Encomenda = enc;
                    encoF.Tipo = Tipo.Congelado;
                    encoF.Semana = encoF.Semana;
                    encoF.Paletes = enc.TotalCongelados;
                    encoF.Rolli = enc.QtRollCong ?? 0;
                    encoF.SemAcesso = enc.Manual ?? false;
                    if (enc.Ridelle != null) encoF.Ridelle = enc.Ridelle.Value;
                    if (enc.Manual != null) encoF.SemAcesso = enc.Manual.Value;
                    encoF.Cliente = enc.Cliente;
                    regisotSemanal.Add(encoF);
                    encoF.Peso = enc.Peso;
                }
                if (enc.QtRollSec > 0 || enc.QtPalSec > 0)
                {
                    var encoF = new EncomendaFrita();
                    encoF.Encomenda = enc;
                    encoF.Tipo = Tipo.Seco;
                    encoF.Semana = encoF.Semana;
                    encoF.Paletes = enc.TotalSecos;
                    encoF.Rolli = enc.QtRollSec ?? 0;
                    encoF.SemAcesso = enc.Manual ?? false;
                    if (enc.Ridelle != null) encoF.Ridelle = enc.Ridelle.Value;
                    if (enc.Manual != null) encoF.SemAcesso = enc.Manual.Value;
                    encoF.Cliente = enc.Cliente;
                    regisotSemanal.Add(encoF);
                    encoF.Peso = enc.Peso;
                }
                if (enc.QtRollFres > 0 || enc.QtPalFres > 0)
                {
                    var encoF = new EncomendaFrita();
                    encoF.Encomenda = enc;
                    encoF.Semana = encoF.Semana;
                    encoF.Tipo = Tipo.Frio;
                    encoF.Paletes = enc.TotalFrios;
                    encoF.Rolli = enc.QtRollFres ?? 0;
                    encoF.SemAcesso = enc.Manual ?? false;
                    if (enc.Ridelle != null) encoF.Ridelle = enc.Ridelle.Value;
                    if (enc.Manual != null) encoF.SemAcesso = enc.Manual.Value;
                    encoF.Cliente = enc.Cliente;
                    regisotSemanal.Add(encoF);
                    encoF.Peso = enc.Peso;
                }
            }
            

            
    

    //Algoritmo

    IEnumerable<PlanoFrito> ol = R(regisotSemanal, plan);
            //Recursive(regisotSemanal, plano, out ol);
            //var semana = 0;
            
            //var preçoMinimo = CalculatePrice(ol);

            // OK Simple s:P
            // Nos queremos os planos que nao têm nada primeiro
            //ver se existe algum que de para por encomendas

            var master = ol.ToList();
            bool stop = false;
            do
            {
                bool troca = false;
                var emptyPlans = master.Where(x => x.Encomendas.Count == 0);
                var withEncomendas = master.Where(x => x.Encomendas.Count > 0);
                foreach (var com in withEncomendas)
                {
                    foreach (var sem in emptyPlans.OrderBy(x => x.CapacidadePaletes))
                    {
                        //temos que ver se o plano é menor que o que temos
                        if (com.CapacidadePaletes <= sem.CapacidadePaletes || com.Ocupadas > sem.CapacidadePaletes)
                            continue; //Este nao tem espaço
                        bool valid = true;
                        // temos que verificar se este camiao consegue levar todas as nossas encomendas
                        foreach (var enc in com.Encomendas)
                        {
                            if (!isValidPlan(enc, sem))
                            {
                                //chapeu nao da, next
                                valid = false;
                                break;
                            }
                        }
                        if (!valid)
                            continue; // Next Pleaze not valid
                        // Este camiao é mais pequeno e consegue levar as nossas encomendas
                        // Toca a trocar
                        sem.Encomendas.AddRange(com.Encomendas);
                        com.Encomendas.Clear();
                        troca = true;
                        break;
                    }
                    if (troca) // Se tivermos trocado temos que correr de  novo porque isto alterou os camioes
                        break;
                }
                stop = !troca; // paramos se nao tiver havido troca

            } while (!stop);

            foreach (var planf in plan)
            {
                foreach (var encomendaF in planf.Encomendas)
                {
                    if (encomendaF.Estado == "Arquivado")
                        break;

                    try
                    {
                        // Your code...
                        // Could also be before try if you know the exception occurs in SaveChanges
                        // Aqui ta a encomenda frita
                        var context = new AMDModels();

                        String tipoEnc = "";

                        if ((int)encomendaF.Tipo == 0)
                            tipoEnc = "Congelados";

                        if ((int)encomendaF.Tipo == 1)
                            tipoEnc = "Frescos";

                        if ((int)encomendaF.Tipo == 2)
                            tipoEnc = "Secos";




                        /*
                        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                        SqlConnection con = new SqlConnection(connectionString);

                        SqlCommand cmd = new SqlCommand("Select Nome from Clientes where Numero == @encomendaF.Cliente", con);

                        con.Open();
                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapt.Fill(ds);
                        string nome = ds.Tables[0].Rows[0]["Item"].ToString();
                        con.Close();
                        */

                        context.EncomendasFritas.Add(new EncomendasFrita()
                        {
                            Cliente = encomendaF.Cliente,
                            Paletes = encomendaF.Paletes,
                            Plano = planf.PlanoSemanal.NumeroCarga,
                            Encomenda = encomendaF.Encomenda.CodEncomenda,
                            Ridelle = encomendaF.Ridelle,
                            Rolli = encomendaF.Rolli,
                            SemAcesso = encomendaF.SemAcesso,
                            Tipo = tipoEnc,
                            Semana = SemanaAtual(),
                            Peso = encomendaF.Peso


                        });
                        context.SaveChanges();
                    }
                    catch (DbEntityValidationException e)
                    {
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw;
                    }
                    context.SaveChanges();
                }
            }


            //Este e o novo preço minimo, 
            //TODO:: Ou muito me engano ou estas a calcular mal os preços, o que esta certo e que ele de facto faz o que é rpeciso, escolhe os camioes mais pequenos ;)
            var preçoMinimo2 = CalculatePrice(master);

            try
            {
                var re = ol.Where(x => x.Encomendas != null);
                MessageBox.Show("Preço Minimo = " + preçoMinimo2 );
                return ol.Where(x => x.Ocupadas > 0).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não é possivel efectuar carga");
                return null;

            }
            //var age = a.First().Transportador;
        }

        private void Encomenda(IEnumerable<EncomendaFrita> encomendas, IEnumerable<PlanoFrito> planos)
        {
            double cachePrice = CalculatePrice(planos);
            RecurCount++;
            if (!encomendas.Any())
            {
                var resultPrice = CalculatePrice(planos);
                if (resultPrice < CurrentMinimum)
                {
                    CurrentMinimum = resultPrice;
                    FinalPlans = planos;
                }
                return;
            }
            double max = CurrentMinimum;
            if (cachePrice >= CurrentMinimum - threshold)
                return;
            foreach (var encomenda in encomendas)
            {
                if (cachePrice >= CurrentMinimum - threshold)
                    return;
                //tentar por esta encomenda nos nossos planos
                var encomendasClone = encomendas.ToList();
                encomendasClone.Remove(encomenda);
                //FindPlanification
                Planify(encomenda, encomendasClone, planos);

            }
            return;
        }

        private void Planify(EncomendaFrita current, IEnumerable<EncomendaFrita> encomendas, IEnumerable<PlanoFrito> plans)
        {
            PlanoCount++;
            double cachePrice = CalculatePrice(plans);
            if (cachePrice >= CurrentMinimum - threshold)
                return;
            var planos = plans.ToList();
            // Try all the plan
            for (int i = 0; i < planos.Count(); i++)
            {
                if (cachePrice >= CurrentMinimum - threshold)
                    return;
                var plan = planos[i];
                if (!isValidPlan(current, plan))
                    continue;
                //fast price check
                var planosClone = planos.Select(x => new PlanoFrito(x)).ToList();
                plan = planosClone[i];
                // Test this
                plan.Encomendas.Add(current);
                var price = CalculatePrice(planosClone);
                if (price >= CurrentMinimum - threshold)
                    continue;
                //test the rest of the setup
                Encomenda(encomendas, planosClone);
                // Null is impossible               
            }
        }

        private IEnumerable<PlanoFrito> R(List<EncomendaFrita> encomendas, IEnumerable<PlanoFrito> plans)
        {
            Dictionary<string, List<EncomendaFrita>> groups = new Dictionary<string, List<EncomendaFrita>>();
            var backupPlans = plans.Select(x => new PlanoFrito(x)).ToList();

            try
            {
                //ordenar por maior encomenda
                var ordered = encomendas.Select(group =>
                        new
                        {
                            Name = group.Cliente,
                            Value = group
                        })
                    .OrderBy(group => -group.Value.Paletes);

                var currentPack = 0;
                foreach (var grou in ordered)
                {
                    var encomenda = grou.Value;
                    var totalPaletes = encomenda.Paletes;
                    //tentar adicionar esta encomenda toda num camiao apenas
                    var plan = plans.Where(x => x.Ocupadas > 0 && isValidPlan(encomenda, x)).OrderBy(x => (x.PriceWith(encomenda))).FirstOrDefault();
                    if (plan != null)
                    {
                        plan.Encomendas.Add(encomenda);
                        currentPack += encomenda.Paletes;

                        continue;
                    }
                    plan = plans.Where(x => x.Ocupadas == 0 && isValidPlan(encomenda, x)).OrderBy(x => (x.PriceWith(encomenda))).FirstOrDefault();
                    if (plan != null)
                    {
                        plan.Encomendas.Add(encomenda);
                        currentPack += encomenda.Paletes;
                        continue;
                    }

                    //we didnt fit, lets see if in the plans there is a place for us even if full
                    var avaiable = plans.Where(x => CamiaoValido(encomenda, x));

                    if (avaiable.Any())
                    {
                        //we exist
                        //remove one package from here and put this one there
                    }
                    return null;
                }
            }
            catch (InvalidCastException e) { }



            //var totalFit = encomendas.Sum(x => x.Paletes);

            var min = CalculatePrice(plans);

            CurrentMinimum = min;


            var groupZone = encomendas.GroupBy(x => x.Encomenda.Cliente1.Zona);

            List<PlanoFrito> bestPlans = new List<PlanoFrito>();

            var optmized = CalculatePrice(FinalPlans);
            return plans;
        }

        DateTime atual = DateTime.Now;

        private int SemanaAtual()
        {
            int semana = GetIso8601WeekOfYear(atual);
            return semana;

        }


        public static int GetIso8601WeekOfYear(DateTime time)       // obter qual semana do ano é que estamos
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }


        private bool CamiaoValidoNaoCompleto(EncomendaFrita encomenda, PlanoFrito plano)
        {
            if (plano.CapacidadePaletes == plano.Ocupadas)
            {
                return false;
            }
            return CamiaoValido(encomenda, plano);
        }

        private bool CamiaoValido(EncomendaFrita encomenda, PlanoFrito plano)
        {
            if (plano.CapacidadePaletes == 5 && plano.Ocupadas < 3)
                return false;
            if (plano.CapacidadePaletes == 11 && plano.Ocupadas < 8)
                return false;
            if (plano.CapacidadePaletes == 18 && plano.Ocupadas < 12)
                return false;
            if (plano.CapacidadePaletes == 32 && plano.Ocupadas < 21)
                return false;

            if (!plano.Congelados &&
                encomenda.Tipo == Tipo.Congelado)
                return false;
            //Preciso e tenho Scos?
            if (!plano.Secos &&
                encomenda.Tipo == Tipo.Seco)
                return false;
            //Preciso e tenho frescos?
            if (!plano.Frescos &&
                encomenda.Tipo == Tipo.Frio)
                return false;
            //Faço entregas para a zona do cliente?
            if (plano.Zona != encomenda.Encomenda.Cliente1.Zona &&
                plano.Zona != encomenda.Encomenda.Cliente1.Opcao_zona_2 &&
                plano.Zona != encomenda.Encomenda.Cliente1.Opcao_zona_3)
            {
                return false;
            }


            return true;
        }


        private bool isValidPlan(EncomendaFrita encomenda, PlanoFrito plano)
        {
            if (plano.Preco <= 0)
                return false;
            if (plano.Ocupadas == plano.CapacidadePaletes)
                return false;

            //Tem espaço para esta encomenda?
            if (plano.CapacidadePaletes - plano.Ocupadas < encomenda.Paletes)
                return false;
            //Preciso e tenho congelados?
            if (!plano.Congelados && encomenda.Tipo == Tipo.Congelado)
                return false;
            //Preciso e tenho Scos?
            if (!plano.Secos && encomenda.Tipo == Tipo.Seco)
                return false;
            //Preciso e tenho frescos?
            if (!plano.Frescos &&
                encomenda.Tipo == Tipo.Frio)
                return false;
            //Faço entregas para a zona do cliente?
            if (plano.Zona != encomenda.Encomenda.Cliente1.Zona && plano.Zona != encomenda.Encomenda.Cliente1.Opcao_zona_2 && plano.Zona != encomenda.Encomenda.Cliente1.Opcao_zona_3)
                return false;
            //Camiao com ridelle
            if (!plano.Ridelle && encomenda.Ridelle)
                return false;
            //Camiao com descarga manual
            if (!plano.EntradaSemAcesso && encomenda.SemAcesso)
                return false;

            /*
            if (plano.CapacidadePaletes == 15 && plano.Ocupadas < 12)
                return false;          
            if (plano.CapacidadePaletes == 8 && (plano.Ocupadas + encomenda.Paletes) < 6)
                return false;*/

            return true;
        }

        private PlanoFrito BestPlanFor(EncomendaFrita encomenda, List<PlanoFrito> plans)
        {
            var alreadyUsed = plans.Where(x => x.Ocupadas > 0).ToList();
            var minPrice = double.MaxValue;
            PlanoFrito plan = null;

            //Already used 
            for (int i = 0; i < alreadyUsed.Count; i++)
            {
                var plano = alreadyUsed[i];
                if (!isValidPlan(encomenda, plano))
                    continue;
                if (minPrice > plano.Preco)
                {
                    minPrice = plano.Preco;
                    plan = plano;
                }
            }

            if (plan != null)
            {
                return plan;
            }
            //Pick from rest
            var notalreadyUsed = plans.Where(x => x.Ocupadas == 0).ToList();
            for (int i = 0; i < notalreadyUsed.Count; i++)
            {
                var plano = notalreadyUsed[i];
                if (!isValidPlan(encomenda, plano))
                    continue;
                if (minPrice > plano.Preco)
                {
                    minPrice = plano.Preco;
                    plan = plano;
                }
            }
            return plan;

        }
        /*
                public PlanoFrito MenorTransportePorCompletar(EncomendaFrita encomenda, List<PlanoFrito> plans)
                {
                    var notfull = plans.Where(x => x.Ocupadas != x.CapacidadePaletes).ToList();
                    for (int i = 0; i < notfull.Count; i++)
                    {
                        var plano = notfull[i];

                    }
                    return notfull;
                }
        */

        public static double CalculatePrice(IEnumerable<PlanoFrito> results)
        {

            if (results == null)
                return -1;
            double total = 0;
            foreach (var plan in results)
            {
                if (plan.Transportadora == "Girardet")       // caso em que nao interessa o numero de paragens
                {
                    if (plan.Encomendas != null && plan.Encomendas.Count > 0)
                    {
                        int extra = (plan.Encomendas.GroupBy(x => x.Cliente).Count() - 1) * 0;
                        double price = plan.Preco / plan.CapacidadePaletes * plan.Ocupadas;

                        if (price <= 0)
                            return -1;
                        total += price + extra;
                    }
                }

                else        // casos em que interessa o numero de paragens
                {
                    if (plan.Encomendas != null && plan.Encomendas.Count > 0)
                    {
                        int extra = (plan.Encomendas.GroupBy(x => x.Cliente).Count() - 1) * 50;
                        double price = plan.Preco / plan.CapacidadePaletes * plan.Ocupadas;
                        if (price <= 0)
                            return -1;
                        total += price; // + extra;
                    }

                }

            }
            return total;
        }

    }
}