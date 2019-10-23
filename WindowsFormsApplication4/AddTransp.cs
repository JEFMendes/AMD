using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class AddTransp : Form
    {
        public AddTransp()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BDpage Check = new BDpage();
            Check.Show();
            this.Hide();
        }

        private void CriarTransportadora_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                // SqlConnection sc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\USERS\ZE\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\AMDManager\AMDManager\AMD.MDF;Integrated Security=True");
                SqlCommand com = new SqlCommand("INSERT INTO Transportadoras (Nome, Morada, Email, Telefone, \"Cod_Postal\", ValorParagSupl ) VALUES (@Nome, @Morada, @Email, @Telefone, @CodPostal, @ValorParagSupl)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Nome", maskedTextBox1.Text);
                com.Parameters.AddWithValue("@Morada", maskedTextBox2.Text);
                com.Parameters.AddWithValue("@Telefone", maskedTextBox4.Text);
                com.Parameters.AddWithValue("@Email", maskedTextBox5.Text);
                com.Parameters.AddWithValue("@CodPostal", maskedTextBox6.Text);
                com.Parameters.AddWithValue("@ValorParagSupl", maskedTextBox3.Text);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Transportadora adicionada com sucesso!");

                //Clear the fields
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox4.Clear();
                maskedTextBox5.Clear();
                maskedTextBox6.Clear();
                maskedTextBox3.Clear();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar transportadora. Por favor tente novamente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());
        }

        private void AddTransp_Load(object sender, EventArgs e)
        {

        }
    }
}
