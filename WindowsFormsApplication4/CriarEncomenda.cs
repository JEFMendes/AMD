using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class Form1 : Form
    {
        Boolean entregaAttalens = false;

        public Form1()
        {
            InitializeComponent();
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aMDDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'AMDDataSet.Clientes' table. You can move, or remove it, as needed.
                this.clientesTableAdapter.Fill(this.AMDDataSet.Clientes);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de clientes. Por favor tente mais tarde.");
            }
            
            

            // Clear the form
            comboBox4.ResetText();
            comboBox5.ResetText();
            comboBox1.ResetText();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            maskedTextBox1.Clear();
            //maskedTextBox2.Clear();
            //maskedTextBox3.Clear();
            //maskedTextBox4.Clear();
            //maskedTextBox5.Clear();
            //maskedTextBox6.Clear();
            //maskedTextBox7.Clear();
            maskedTextBox8.Clear();
            textBox1.Clear();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu Check = new Menu();
            Check.Show();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labes_Click(object sender, EventArgs e)
        {

        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void maskedTextBox8_MouseHover(object sender, EventArgs e)
        {
        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.checkBox1, "Atenção: Apenas disponivel para comerciais");
        }

        int tipo = 1; // 1- encomenda normal        2- entrega comercial        3- armazem adicional   4- entrega no armazem (o cliente vem buscar em maos)

        private void CriarEntrega_Click(object sender, EventArgs e)
        {                    
            try
            {
                //verificar se o numero de paletes e Rollis é possivel sequer
                int qtpalsec = Convert.ToInt32(maskedTextBox2.Text);
                int qtrolsec = Convert.ToInt32(maskedTextBox3.Text);
                int qtpalfres = Convert.ToInt32(maskedTextBox4.Text);
                int qtrollfres = Convert.ToInt32(maskedTextBox5.Text);
                int qtpalcong = Convert.ToInt32(maskedTextBox6.Text);
                int qtrollcong = Convert.ToInt32(maskedTextBox7.Text);

                if (qtpalsec > 32 || qtrolsec > 64 || qtpalfres > 32 || qtrollfres > 64 || qtpalcong > 32 || qtrollcong > 64)
                {
                    MessageBox.Show("O número de paletes/rollis inserido não é válido. Por favor tente novamente.");
                    return;
                }


                if (tipo==4)
                {
                    // fazer insert na db EncomendasAttalens
                    string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand com = new SqlCommand("INSERT INTO EncomendasAttalens (Cliente, CodEncomenda, QtPalSec, QtRollSec, QtPalFres, QtRollFres, QtPalCong, QtRollCong, HoraCarga, DataCarga, Semana) VALUES (@Cliente, @CodEncomenda, @QtPalSec, @QtRollSec, @QtPalFres, @QtRollFres, @QtPalCong, @QtRollCong, @HoraCarga, @DataCarga, @Semana)", con);
                    com.CommandType = CommandType.Text;

                    com.Parameters.AddWithValue("@CodEncomenda", maskedTextBox1.Text);
                    com.Parameters.AddWithValue("@QtPalSec", maskedTextBox2.Text);
                    com.Parameters.AddWithValue("@QtRollSec", maskedTextBox3.Text);
                    com.Parameters.AddWithValue("@QtPalFres", maskedTextBox4.Text);
                    com.Parameters.AddWithValue("@QtRollFres", maskedTextBox5.Text);
                    com.Parameters.AddWithValue("@QtPalCong", maskedTextBox6.Text);
                    com.Parameters.AddWithValue("@QtRollCong", maskedTextBox7.Text);
                    com.Parameters.AddWithValue("@HoraCarga", comboBox3.SelectedItem.ToString());
                    com.Parameters.AddWithValue("@DataCarga", comboBox6.SelectedItem.ToString());
                    int semana = SemanaAtual();
                    com.Parameters.AddWithValue("@Semana", semana);


                    DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                    String n = drv2["Nome"].ToString();
                    com.Parameters.AddWithValue("@Cliente", n);

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    // Clear the form
                    comboBox4.ResetText();
                    comboBox5.ResetText();
                    comboBox1.ResetText();
                    comboBox2.ResetText();
                    comboBox3.ResetText();
                    comboBox6.ResetText();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;
                    maskedTextBox1.Clear();
                    maskedTextBox2.Clear();
                    maskedTextBox3.Clear();
                    maskedTextBox4.Clear();
                    maskedTextBox5.Clear();
                    maskedTextBox6.Clear();
                    maskedTextBox7.Clear();
                    maskedTextBox8.Clear();
                    maskedTextBox9.Clear();
                    maskedTextBox10.Clear();
                    maskedTextBox11.Clear();

                    //Confirmation Message 
                    MessageBox.Show("Encomenda adicionado com sucesso!");
                }

                if(tipo==1)     // encomenda normal 
                {
                    // Insert in database
                    string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    SqlCommand com = new SqlCommand("INSERT INTO Encomendas (Semana, Cliente, CodEncomenda, QtPalSec, QtRollSec, QtPalFres, QtRollFres, QtPalCong, QtRollCong, Ridelle, Manual, HoraCarga, Peso) VALUES (@Semana, @Cliente, @CodEncomenda, @QtPalSec, @QtRollSec, @QtPalFres, @QtRollFres, @QtPalCong, @QtRollCong, @Ridelle, @Manual, @HoraCarga, @Peso)", con);
                    com.CommandType = CommandType.Text;

                    DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                    String cb1 = drv2["Numero"].ToString();
                    com.Parameters.AddWithValue("@Cliente", cb1);

                    com.Parameters.AddWithValue("@CodEncomenda", maskedTextBox1.Text);
                    com.Parameters.AddWithValue("@QtPalSec", maskedTextBox2.Text);
                    com.Parameters.AddWithValue("@QtRollSec", maskedTextBox3.Text);
                    com.Parameters.AddWithValue("@QtPalFres", maskedTextBox4.Text);
                    com.Parameters.AddWithValue("@QtRollFres", maskedTextBox5.Text);
                    com.Parameters.AddWithValue("@QtPalCong", maskedTextBox6.Text);
                    com.Parameters.AddWithValue("@QtRollCong", maskedTextBox7.Text);
                    com.Parameters.AddWithValue("@Ridelle", checkBox2.Checked);
                    com.Parameters.AddWithValue("@Manual", checkBox3.Checked);
                    com.Parameters.AddWithValue("@Peso", maskedTextBox8.Text);
                    int semana = SemanaAtual();
                    com.Parameters.AddWithValue("@Semana", semana);

                    string horaDeDescarga = comboBox5.SelectedItem.ToString() + " ate " + comboBox4.SelectedItem.ToString();
                    com.Parameters.AddWithValue("@HoraCarga", horaDeDescarga);

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    // Clear the form
                    comboBox4.ResetText();
                    comboBox5.ResetText();
                    comboBox1.ResetText();
                    comboBox2.ResetText();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;
                    maskedTextBox1.Clear();
                    maskedTextBox2.Clear();
                    maskedTextBox3.Clear();
                    maskedTextBox4.Clear();
                    maskedTextBox5.Clear();
                    maskedTextBox6.Clear();
                    maskedTextBox7.Clear();
                    maskedTextBox8.Clear();
                    maskedTextBox9.Clear();
                    maskedTextBox10.Clear();
                    maskedTextBox11.Clear();

                    //Confirmation Message 
                    MessageBox.Show("Encomenda adicionado com sucesso!");

                }

                if (tipo==2)        // entrega comercial
                {
                    // Insert in database
                    string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    // SqlConnection sc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\USERS\ZE\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\AMDManager\AMDManager\AMD.MDF;Integrated Security=True");
                    SqlCommand com = new SqlCommand("INSERT INTO Encomendas (Semana, Cliente, CodEncomenda, Peso, HoraCarga, Secos, Frescos, Congelados) VALUES (@Semana, @Cliente, @CodEncomenda, @Peso, @HoraCarga, @Secos, @Frescos, @Congelados)", con);
                    com.CommandType = CommandType.Text;

                    DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                    String cb1 = drv2["Nome"].ToString();
                    com.Parameters.AddWithValue("@Cliente", cb1);

                    com.Parameters.AddWithValue("@CodEncomenda", maskedTextBox1.Text);
                    com.Parameters.AddWithValue("@Peso", maskedTextBox8.Text);
                    com.Parameters.AddWithValue("@Secos", checkBox6.Checked);
                    com.Parameters.AddWithValue("@Frescos", checkBox5.Checked);
                    com.Parameters.AddWithValue("@Congelados", checkBox4.Checked);
                    int semana = SemanaAtual();
                    com.Parameters.AddWithValue("@Semana", semana);

                    string horaDeDescarga = comboBox5.SelectedItem.ToString() + " ate " + comboBox4.SelectedItem.ToString();
                    com.Parameters.AddWithValue("@HoraCarga", horaDeDescarga);

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    // Clear the form
                    comboBox4.ResetText();
                    comboBox5.ResetText();
                    comboBox1.ResetText();
                    comboBox2.ResetText();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;
                    maskedTextBox1.Clear();
                    maskedTextBox2.Clear();
                    maskedTextBox3.Clear();
                    maskedTextBox4.Clear();
                    maskedTextBox5.Clear();
                    maskedTextBox6.Clear();
                    maskedTextBox7.Clear();
                    maskedTextBox8.Clear();
                    maskedTextBox9.Clear();
                    maskedTextBox10.Clear();
                    maskedTextBox11.Clear();

                    //Confirmation Message 
                    MessageBox.Show("Encomenda adicionado com sucesso!");

                }

                if (tipo == 3)      // armazem adicional
                {
                    // Insert in database
                    string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);

                    // SqlConnection sc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\USERS\ZE\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\AMDManager\AMDManager\AMD.MDF;Integrated Security=True");
                    SqlCommand com = new SqlCommand("INSERT INTO Encomendas (Semana, Cliente, CodEncomenda, QtPalSecArma,QtPalFresArma, QtPalCongArma, HoraCarga, Armazem, Peso) VALUES (@Semana, @Cliente, @CodEncomenda, @QtPalSecArma, @QtPalFresArma, @QtPalCongArma, @HoraCarga, @Armazem, @Peso)", con);
                    com.CommandType = CommandType.Text;

                    DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                    String cb1 = drv2["Nome"].ToString();
                    com.Parameters.AddWithValue("@Cliente", cb1);

                    com.Parameters.AddWithValue("@CodEncomenda", maskedTextBox1.Text);
                    com.Parameters.AddWithValue("@QtPalSecArma", maskedTextBox11.Text);
                    com.Parameters.AddWithValue("@QtPalFresArma", maskedTextBox10.Text);
                    com.Parameters.AddWithValue("@QtPalCongArma", maskedTextBox9.Text);
                    com.Parameters.AddWithValue("@Peso", maskedTextBox8.Text);
                    int semana = SemanaAtual();
                    com.Parameters.AddWithValue("@Semana", semana);

                    string armazem = comboBox2.SelectedItem.ToString();
                    com.Parameters.AddWithValue("@Armazem", armazem);

                    string horaDeDescarga = comboBox5.SelectedItem.ToString() + " ate " + comboBox4.SelectedItem.ToString();
                    com.Parameters.AddWithValue("@HoraCarga", horaDeDescarga);

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    // Clear the form
                    comboBox4.ResetText();
                    comboBox5.ResetText();
                    comboBox1.ResetText();
                    comboBox2.ResetText();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                    checkBox5.Checked = false;
                    checkBox6.Checked = false;
                    maskedTextBox1.Clear();
                    maskedTextBox2.Clear();
                    maskedTextBox3.Clear();
                    maskedTextBox4.Clear();
                    maskedTextBox5.Clear();
                    maskedTextBox6.Clear();
                    maskedTextBox7.Clear();
                    maskedTextBox8.Clear();
                    maskedTextBox9.Clear();
                    maskedTextBox10.Clear();
                    maskedTextBox11.Clear();

                    //Confirmation Message 
                    MessageBox.Show("Encomenda adicionado com sucesso!");

                }

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar encomenda. Por favor tente novamente.");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)   // Idiot proof - entrega de comercial
        {
            if (checkBox1.Checked)
            {
                tipo = 2;

                label11.Visible = true;
                maskedTextBox8.Visible = true;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                IconCong.Visible = false;
                button2.Visible = false;
                button5.Visible = false;
                maskedTextBox2.Visible = false;
                maskedTextBox4.Visible = false;
                maskedTextBox6.Visible = false;
                maskedTextBox3.Visible = false;
                maskedTextBox5.Visible = false;
                maskedTextBox7.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                button1.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox6.Visible = true;

                checkBox7.Checked = false;
                label12.Visible = false;
                comboBox2.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                label10.Visible = false;
                maskedTextBox10.Visible = false;
                maskedTextBox9.Visible = false;
                maskedTextBox11.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;

                comboBox1.ResetText();
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                maskedTextBox2.Clear();
                maskedTextBox4.Clear();
                maskedTextBox6.Clear();
                maskedTextBox8.Clear();
                maskedTextBox4.Clear();
                maskedTextBox5.Clear();
                maskedTextBox7.Clear();
            }
            else
            {
                label11.Visible = true;
                maskedTextBox8.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                IconCong.Visible = true;
                button2.Visible = true;
                button5.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox4.Visible = true;
                maskedTextBox6.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                maskedTextBox3.Visible = true;
                maskedTextBox5.Visible = true;
                maskedTextBox7.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                label6.Visible = true;
                button1.Visible = true;
                button3.Visible = true;
                button4.Visible = true;

                comboBox1.ResetText();
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                maskedTextBox2.Clear();
                maskedTextBox4.Clear();
                maskedTextBox6.Clear();
                maskedTextBox8.Clear();
            }
            

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox7.Checked)
            {
                tipo = 3;

                label12.Visible = true;
                comboBox2.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label10.Visible = true;
                maskedTextBox10.Visible = true;
                maskedTextBox9.Visible = true;
                maskedTextBox11.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;

                labes.Visible = true;
                maskedTextBox1.Visible = true;

                label11.Visible = true;
                maskedTextBox8.Visible = true;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                IconCong.Visible = false;
                button2.Visible = false;
                button5.Visible = false;
                maskedTextBox2.Visible = false;
                maskedTextBox4.Visible = false;
                maskedTextBox6.Visible = false;
                maskedTextBox3.Visible = false;
                maskedTextBox5.Visible = false;
                maskedTextBox7.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                button1.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;


                comboBox1.ResetText();
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                maskedTextBox2.Clear();
                maskedTextBox4.Clear();
                maskedTextBox6.Clear();
                maskedTextBox8.Clear();
                maskedTextBox4.Clear();
                maskedTextBox5.Clear();
                maskedTextBox7.Clear();


            }

            else
            {
                label12.Visible = false;
                comboBox2.Visible =false;
                label7.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                maskedTextBox10.Visible = false;
                maskedTextBox9.Visible = false;
                maskedTextBox11.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                label10.Visible = false;

                label11.Visible = true;
                maskedTextBox8.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                IconCong.Visible = true;
                button2.Visible = true;
                button5.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox4.Visible = true;
                maskedTextBox6.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                checkBox6.Visible = false;
                maskedTextBox3.Visible = true;
                maskedTextBox5.Visible = true;
                maskedTextBox7.Visible = true;
                label1.Visible = true;
                label3.Visible = true;
                label6.Visible = true;
                button1.Visible = true;
                button3.Visible = true;
                button4.Visible = true;

                comboBox1.ResetText();
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                maskedTextBox2.Clear();
                maskedTextBox4.Clear();
                maskedTextBox6.Clear();
                maskedTextBox8.Clear();
            }

        }   // armazem de saida adicional

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     // quando escolhemos o cliente ver se é entrega attalens ou normal
        {
            int count=0;

            try
            {
                DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv2["Nome"].ToString();

                string connectionString2 = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                SqlConnection con2 = new SqlConnection(connectionString2);

                SqlCommand cmd = new SqlCommand("Select * from Clientes where \"Entrega_Attalens\"=1 and nome=@nome", con2);
                cmd.Parameters.AddWithValue("@nome", cb1);

                con2.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con2.Close();
                count = ds.Tables[0].Rows.Count;

            }

            catch
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar cliente. Por favor tente novamente.");
            }

            //If count is equal to 1, then deliver is in Attalens, no need for algoritm
            if (count == 1)
            {
                tipo = 4;

                entregaAttalens = true;

                label13.Visible = true;
                label14.Visible = true;
                comboBox6.Visible = true;
                comboBox3.Visible = true;
                checkBox1.Visible = false;
                checkBox7.Visible = false;
                comboBox4.Visible = false;
                comboBox5.Visible = false;
                label9.Visible = false;
                checkBox3.Visible = false;
                checkBox2.Visible = false;
            }


            else
            {
                entregaAttalens = false;

                label13.Visible = false;
                label14.Visible = false;
                comboBox6.Visible = false;
                comboBox3.Visible = false;
                checkBox1.Visible = true;
                checkBox7.Visible = true;
                comboBox4.Visible = true;
                comboBox5.Visible = true;
                label9.Visible = true;
                checkBox3.Visible = true;
                checkBox2.Visible = true;
            }

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
