using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class AddComercial : Form
    {
        public AddComercial()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BDpage Check = new BDpage();
            Check.Show();
            this.Hide();
        }

        private void AddComercial_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'AMDDataSet.Distancias' table. You can move, or remove it, as needed.
                this.distanciasTableAdapter.Fill(this.aMDDataSet.Distancias);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de localidades. Por favor tente mais tarde.");
            }

            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.Veiculos' table. You can move, or remove it, as needed.
                this.veiculosTableAdapter.Fill(this.aMDDataSet.Veiculos);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de veiculos. Por favor tente mais tarde.");
            }           

        }

        private void criarComer_MouseClick(object sender, MouseEventArgs e)
        {
            //Insert in the database
            try
            {
                // Insert in database
                string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                // SqlConnection sc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\USERS\ZE\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\AMDManager\AMDManager\AMD.MDF;Integrated Security=True");
                SqlCommand com = new SqlCommand("INSERT INTO Comerciais (Nome, Veiculo, \"Custo_por_hora\", Zonas) VALUES (@Nome, @Veiculo, @CustoHora, @Zonas)", con);
                com.CommandType = CommandType.Text;
   
                com.Parameters.AddWithValue("@Nome", maskedTextBox1.Text);
                com.Parameters.AddWithValue("@CustoHora", maskedTextBox3.Text);

                DataRowView drv2 = (DataRowView)comboBox3.SelectedItem;
                String cb3 = drv2["Matricula"].ToString();
                com.Parameters.AddWithValue("@Veiculo", cb3);

                
                string checkedItem = "";

                foreach (DataRowView it in distanciasListBox.SelectedItems)
                {
                    //convert item to string
                    checkedItem += " " + it["Zona"].ToString();
                }

                com.Parameters.AddWithValue("@Zonas", checkedItem); //add item
                
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();

                //Confirmation Message 
                MessageBox.Show("Comercial adicionado com sucesso!");

                //Clear the fields
                maskedTextBox1.Clear();
                maskedTextBox3.Clear();
                comboBox3.ResetText();


            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar comercial. Por favor tente novamente.");
            }

        }

        private void criarComer_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());
        }
        
    }
}
