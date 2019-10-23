using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class AddVeiculo : Form
    {
        public AddVeiculo()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BDpage Check = new BDpage();
            Check.Show();
            this.Hide();
        }

        private void AddVeiculo_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void criarVeiculo_Click(object sender, EventArgs e)
        {

            //Insert in the database
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString; 
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("INSERT INTO Veiculos (Matricula, Secos, Frescos, Congelados, \"Limite_de_Peso\", Classe) VALUES (@Matricula, @Secos, @Frescos, @Congelados, @Limite, @Classe)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Matricula", maskedTextBox1.Text);
                cmd.Parameters.AddWithValue("@Secos", checkBox2.Checked);
                cmd.Parameters.AddWithValue("@Frescos", checkBox1.Checked);
                cmd.Parameters.AddWithValue("@Congelados", checkBox3.Checked);
                cmd.Parameters.AddWithValue("@Limite", maskedTextBox2.Text);
                cmd.Parameters.AddWithValue("@Classe", comboBox1.SelectedItem.ToString());
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Veiculo adicionado com sucesso!");

                //Clear the fields
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                comboBox1.ResetText();

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar veiculo. Por favor tente novamente.");
            }
        }

    
        private void veiculosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());
        }
    }
}
