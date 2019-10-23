using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class Menu : Form
    {
        //public string getID { get; set; }


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

        private void copyDB()
        {
            int v = 0;
            try
            {
            int semanaActual = SemanaAtual();
            string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand com2 = new SqlCommand("INSERT INTO Arquivo SELECT * FROM Encomendas WHERE Semana <'" + semanaActual + "'", con);
            con.Open();

            com2.CommandType = CommandType.Text;
            int i = com2.ExecuteNonQuery();
            con.Close();
            }
             catch (Exception e)
             {
                 v = 1;
             }

            if (v == 0)
            {
                try
                {
                    int semanaActual = SemanaAtual();

                    string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand com = new SqlCommand("DELETE FROM Encomendas WHERE Semana <'" + semanaActual + "'", con);

                    con.Open();

                    com.CommandType = CommandType.Text;
                    int i = com.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception e)
                {

                }
            }
            

        }


        public Menu()
        {
            copyDB();

            InitializeComponent();

            System.Windows.Forms.Form log = System.Windows.Forms.Application.OpenForms["Login"];

            string ID = ((Login)log).textBox1.Text;

            if (ID == "Admin" || ID == "admin")
            {
                label5.Visible = true;
                BD.Visible = true;
            }

            else
            {
                label5.Visible = false;
                BD.Visible = false;
            }

            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void CriarEncomenda_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new PrevisaoCargaSemanal());
        }

        private void BD_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());

            string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand com2 = new SqlCommand("DELETE FROM EncomendasFritas", con);
            //SqlCommand com3 = new SqlCommand("DELETE FROM PlanoSemanal", con);
            com2.CommandType = CommandType.Text;
            //com3.CommandType = CommandType.Text;
            con.Open();

            int i = com2.ExecuteNonQuery();
            //int j = com3.ExecuteNonQuery();
            con.Close();
        }


        private void Arquivo_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new Arquivo());
        }

        private void PlanoSemana_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new PlanoSemanal());
        }

        private void prevCarga_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new PrevisaoCargaSemanal());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddRemovePaletes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirPaletes());
        }
    }
}
