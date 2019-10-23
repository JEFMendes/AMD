using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class AddCliente : Form
    {
        public AddCliente()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BDpage Check = new BDpage();
            Check.Show();
            this.Hide();
        }

        private void labes_Click(object sender, EventArgs e)
        {

        }

        private void AddCliente_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'AMDDataSet.Encomendas' table. You can move, or remove it, as needed.
                this.encomendasTableAdapter.Fill(this.AMDDataSet.Encomendas);
            }
            catch
            {
                MessageBox.Show("Não conseguimos carregar a tabela de clientes. Por favor tente mais tarde.");
            }

            try
            {
                // TODO: This line of code loads data into the 'AMDDataSet.Distancias' table. You can move, or remove it, as needed.
                this.distanciasTableAdapter.Fill(this.AMDDataSet.Distancias);
            }
            catch
            {
                MessageBox.Show("Não conseguimos carregar a tabela de localidades. Por favor tente mais tarde.");
            }

            try
            {
                // TODO: This line of code loads data into the 'AMDDataSet.Comerciais' table. You can move, or remove it, as needed.
                this.comerciaisTableAdapter.Fill(this.AMDDataSet.Comerciais);
            }
            catch
            {
                MessageBox.Show("Não conseguimos carregar a tabela de comerciais. Por favor tente mais tarde.");
            }

            
            

            //Clear the fields
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox1.ResetText();
            checkBox1.Checked = false;
            checkBox2.Checked = false;

        }


        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.checkBox1, "Atenção: Apenas disponivel para comerciais");
        }

        private void CriarCliente_Click(object sender, EventArgs e)
        {
            //Insert in the database
            try
            {
                // Insert in database
                string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                // SqlConnection sc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\USERS\ZE\DOCUMENTS\VISUAL STUDIO 2015\PROJECTS\AMDManager\AMDManager\AMD.MDF;Integrated Security=True");
                SqlCommand com = new SqlCommand("INSERT INTO Clientes (Numero, Nome, Morada, Telefone, Zona, Comercial, Ridelle, \"Entrega_pelo_comercial\", Email, \"Entrada_sem_acesso\", \"Codigo_postal\", \"Opcao_zona_2\", \"Opcao_zona_3\", \"Entrega_Attalens\") VALUES (@Numero, @Nome, @Morada, @Telefone, @Zona, @Comercial, @Ridelle, @entregaComercial, @Email, @entradaSemAcesso, @codigoPostal, @opZona2, @opZona3, @entregaAttalens)", con);
                com.CommandType = CommandType.Text;

                com.Parameters.AddWithValue("@Numero", maskedTextBox2.Text);
                com.Parameters.AddWithValue("@Nome", maskedTextBox1.Text);
                com.Parameters.AddWithValue("@Morada", maskedTextBox3.Text);
                com.Parameters.AddWithValue("@Telefone", maskedTextBox4.Text);

                DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                String cb1 = drv["Zona"].ToString();
                com.Parameters.AddWithValue("@Zona", cb1);

                DataRowView drv3 = (DataRowView)comboBox2.SelectedItem;
                String cb2 = drv3["Nome"].ToString();
                com.Parameters.AddWithValue("@Comercial", cb2);

                com.Parameters.AddWithValue("@Ridelle", checkBox2.Checked);
                com.Parameters.AddWithValue("@entregaComercial", checkBox1.Checked);
                com.Parameters.AddWithValue("@Email", maskedTextBox5.Text);
                com.Parameters.AddWithValue("@entradaSemAcesso", checkBox3.Checked);
                com.Parameters.AddWithValue("@codigoPostal", maskedTextBox6.Text);
                com.Parameters.AddWithValue("@entregaAttalens", checkBox4.Checked);

                DataRowView drv1 = (DataRowView)comboBox3.SelectedItem;
                String cb3 = drv1["Zona"].ToString();
                com.Parameters.AddWithValue("@opZona2", cb3);

                DataRowView drv2 = (DataRowView)comboBox4.SelectedItem;
                String cb4 = drv2["Zona"].ToString();
                com.Parameters.AddWithValue("@opZona3", cb4);


                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();


                //Confirmation Message 
                MessageBox.Show("Cliente adicionado com sucesso!");

                //Clear the fields
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                maskedTextBox4.Clear();
                maskedTextBox5.Clear();
                maskedTextBox6.Clear();
                comboBox2.ResetText();
                comboBox3.ResetText();
                comboBox4.ResetText();
                comboBox1.ResetText();
                checkBox1.Checked = false;
                checkBox2.Checked = false;

            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar cliente. Por favor tente novamente.");
            }   

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
                comboBox4.Visible = false;
                comercial.Visible = false;
                zona.Visible = false;
                zonaOp2.Visible = false;
                zonaOp3.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
            }
            else
            {
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comercial.Visible = true;
                zona.Visible = true;
                zonaOp2.Visible = true;
                zonaOp3.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;

            }
            
        }
    }
}
