using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AMDManager.Algos;

namespace AMDManager
{
    public partial class PlanoSemanal : Form
    {
        public PlanoSemanal()
        {
            InitializeComponent();
        }

        Bitmap bmpPrint;
        DateTime atual = DateTime.Now;

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmpPrint = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmpPrint);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printDialog1.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu Check = new Menu();
            Check.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //VerEncomenda Check = new VerEncomenda();
            //Check.Show();
            //this.Hide();
        }

        private void PlanoSemanal_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet1.Encomendas' table. You can move, or remove it, as needed.
                this.encomendasTableAdapter.Fill(this.aMDDataSet1.Encomendas);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de Encomendas. Por favor tente mais tarde.");
            }

            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet1.PlanoSemanal' table. You can move, or remove it, as needed.
                this.planoSemanalTableAdapter.Fill(this.aMDDataSet1.PlanoSemanal);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de transportes. Por favor tente mais tarde.");
            }
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            string estdString = "Por atribuir";

            SqlCommand cmd = new SqlCommand("Select * from Encomendas where Estado == @Estado", con);
            cmd.Parameters.AddWithValue("@Estado", estdString);

            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // morphexe algoritm
            try
            {
                var alg = new Algos.IAlg();
                var results = alg.Execute();
                this.resultsSource.DataSource = results;

                foreach (var plan in results)
                {
                    var cenas = plan.Encomendas.ToList();
                }

            }     
            catch (InvalidCastException d) { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

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


        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //VerEncomenda Check = new VerEncomenda();

            //Check.Show();
        }

        private void encomendasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)        //so esta a alterar visualmente, nao altera na base de dados
        {
            var current = encomendasDataGridView.CurrentRow;
            if (e.RowIndex > -1) // Means that you've not clicked the column header
            {
                if (encomendasDataGridView.SelectedCells.Count > 0)
                {
                    string cellValue = encomendasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();

                    if (cellValue.Contains("PorArquivar"))
                    {
                        try
                        {
                            string estado = "Arquivado";
                            string codEncomenda = encomendasDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

                            encomendasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Arquivado";

                            string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                            SqlConnection con = new SqlConnection(connectionString);

                            SqlCommand com = new SqlCommand("UPDATE Encomendas SET estado = @Estado WHERE codEncomenda = @codEncomenda", con);
                            com.CommandType = CommandType.Text;

                            com.Parameters.AddWithValue("@Estado", estado);
                            com.Parameters.AddWithValue("@codEncomenda", codEncomenda);

                            con.Open();
                            int i = com.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show("Não conseguimos arquivar a encomenda. Tente novamente por favor.");
                        }
                    }

                    if (cellValue.Contains("Arquivado"))
                    {
                        try
                        {
                            string estado = "PorArquivar";
                            string codEncomenda = encomendasDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

                            encomendasDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "PorArquivar";

                            string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                            SqlConnection con = new SqlConnection(connectionString);

                            SqlCommand com = new SqlCommand("UPDATE Encomendas SET estado = @Estado WHERE codEncomenda = @codEncomenda", con);
                            com.CommandType = CommandType.Text;

                            com.Parameters.AddWithValue("@Estado", estado);
                            com.Parameters.AddWithValue("@codEncomenda", codEncomenda);

                            con.Open();
                            int i = com.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception f)
                        {
                            MessageBox.Show("Não conseguimos arquivar a encomenda. Tente novamente por favor.");
                        }
                    }

                }
            }

            else
            {
                return;
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var PlanoFrito = (PlanoFrito)dataGridView2.Rows[e.RowIndex].DataBoundItem;
            VerEncomenda Check = new VerEncomenda(PlanoFrito.PlanoSemanal.NumeroCarga);
            Check.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // morphexe algoritm
            try
            {
                var alg = new Algos.IAlg();
                var results = alg.Execute();
                this.resultsSource.DataSource = results;

                foreach (var plan in results)
                {
                    var cenas = plan.Encomendas.ToList();
                }

            }
            catch (InvalidCastException d) { }
        }
    }
}
