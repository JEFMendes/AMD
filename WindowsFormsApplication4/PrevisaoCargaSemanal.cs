using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AMDManager.Models;

namespace AMDManager
{
    public partial class PrevisaoCargaSemanal : Form
    {
        public PrevisaoCargaSemanal()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu Check = new Menu();
            Check.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void capCarga_MouseHover(object sender, EventArgs e)
        {
   
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PlanoSemanal Check = new PlanoSemanal();
            Check.Show();
            this.Hide();
        }

        private void insrtPrev_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert in the database
                string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);

                comboBox1.ResetText();
                comboBox7.ResetText();

                if (trans==true)     // Transportadora
                {

                    SqlCommand com = new SqlCommand("INSERT INTO PlanoSemanal (Transportador, CapacidadePaletes, Zona, Secos, Frescos, Congelados, DiasDeCarga, HoraDeCarga, Cais, Ridelle, EntradaSemAcesso) VALUES (@Transportador, @CapacidadePaletes, @Zona, @Secos, @Frescos, @Congelados, @DiasDeCarga, @HoraDeCarga, @Cais, @Ridelle, @EntradaSemAcesso)", con);
                    com.CommandType = CommandType.Text;

                    DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                    String cb1 = drv["Nome"].ToString();
                    com.Parameters.AddWithValue("@Transportador", cb1);

                    com.Parameters.AddWithValue("@Cais", comboBox4.SelectedItem);

                    com.Parameters.AddWithValue("@HoraDeCarga", comboBox3.SelectedItem);

                    com.Parameters.AddWithValue("@DiasDeCarga", comboBox6.SelectedItem);

                    DataRowView drv5 = (DataRowView)comboBox2.SelectedItem;
                    String cb2 = drv5["Zona"].ToString();
                    com.Parameters.AddWithValue("@Zona", cb2);

                    com.Parameters.AddWithValue("@CapacidadePaletes", comboBox8.SelectedItem);

                    com.Parameters.AddWithValue("@Ridelle", checkBox2.Checked);
                    com.Parameters.AddWithValue("@EntradaSemAcesso", checkBox7.Checked);

                    com.Parameters.AddWithValue("@Secos", checkBox1.Checked);
                    com.Parameters.AddWithValue("@Frescos", checkBox3.Checked);
                    com.Parameters.AddWithValue("@Congelados", checkBox4.Checked);

                    // verificar se nesse dia e hora o cais ja esta usado
                    SqlCommand cmd = new SqlCommand("Select * From PlanoSemanal where DiasDeCarga = @DiasDeCarga and HoraDeCarga = @HoraDeCarga and Cais = @Cais", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Cais", comboBox4.SelectedItem);
                    cmd.Parameters.AddWithValue("@HoraDeCarga", comboBox3.SelectedItem);
                    cmd.Parameters.AddWithValue("@DiasDeCarga", comboBox6.SelectedItem);
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con.Close();
                    int count = ds.Tables[0].Rows.Count;

                    if (count > 0)
                    {
                        MessageBox.Show("Erro ao adicionar carga. Data e hora de carga já utilizados no cais pretendido. Por favor selecione outra data, hora ou cais.");
                        return;
                    }

                    else 
                    {
                        con.Open();
                        int i = com.ExecuteNonQuery();
                        con.Close();

                        // refresh na datagrid view com a nova previsao de carga
                        PrevisaoCargaSemanal_Load(sender, e);

                    }
                   
                }


                if (trans==false)     // Comercial
                {
                    SqlCommand com = new SqlCommand("INSERT INTO PlanoSemanal (Comercial, Zona, Secos, Frescos, Congelados, DiasDeCarga, Veiculo) VALUES (@Comercial, @Zona, @Secos, @Frescos, @Congelados, @DiasDeCarga, @Veiculo)", con);
                    com.CommandType = CommandType.Text;

                    DataRowView drv4 = (DataRowView)comboBox7.SelectedItem;
                    String cb7 = drv4["Nome"].ToString();
                    com.Parameters.AddWithValue("@Comercial", cb7);

                    DataRowView drv6 = (DataRowView)comboBox5.SelectedItem;
                    String cb5 = drv6["Matricula"].ToString();
                    com.Parameters.AddWithValue("@Veiculo", cb5);

                    com.Parameters.AddWithValue("@DiasDeCarga", comboBox6.SelectedItem);

                    DataRowView drv5 = (DataRowView)comboBox2.SelectedItem;
                    String cb2 = drv5["Zona"].ToString();
                    com.Parameters.AddWithValue("@Zona", cb2);

                    com.Parameters.AddWithValue("@Secos", checkBox1.Checked);
                    com.Parameters.AddWithValue("@Frescos", checkBox3.Checked);
                    com.Parameters.AddWithValue("@Congelados", checkBox4.Checked);

                    con.Open();
                    int i = com.ExecuteNonQuery();
                    con.Close();

                    PrevisaoCargaSemanal_Load(sender, e);
                }
                


                //Confirmation Message 
                MessageBox.Show("Carga adicionada com sucesso!");

                //Clear the fields
                comboBox1.ResetText();
                comboBox8.ResetText();
                comboBox2.ResetText();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox7.Checked = false;
                comboBox4.ResetText();
                comboBox5.ResetText();
                comboBox3.ResetText();
                comboBox6.ResetText();
                comboBox7.ResetText();
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar carga. Por favor tente novamente.");
            }         
            
        }

        private void PrevisaoCargaSemanal_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.Comerciais' table. You can move, or remove it, as needed.
                this.comerciaisTableAdapter.Fill(this.aMDDataSet.Comerciais);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de Comerciais. Por favor tente mais tarde.");
            }
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.Distancias' table. You can move, or remove it, as needed.
                this.distanciasTableAdapter.Fill(this.aMDDataSet.Distancias);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de zonas. Por favor tente mais tarde.");
            }
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.Veiculos' table. You can move, or remove it, as needed.
                this.veiculosTableAdapter.Fill(this.aMDDataSet.Veiculos);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de Veiculos. Por favor tente mais tarde.");
            }
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.Transportadoras' table. You can move, or remove it, as needed.
                this.transportadorasTableAdapter1.Fill(this.aMDDataSet.Transportadoras);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de Transportadoras. Por favor tente mais tarde.");
            }
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.PlanoSemanal' table. You can move, or remove it, as needed.
                this.planoSemanalTableAdapter.Fill(this.aMDDataSet.PlanoSemanal);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de transportes. Por favor tente mais tarde.");
            }
            
            //Clear the fields
            comboBox1.ResetText();
            comboBox8.ResetText();
            comboBox2.ResetText();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox7.Checked = false;
            comboBox4.ResetText();
            comboBox5.ResetText();
            comboBox3.ResetText();
            comboBox6.ResetText();
            comboBox7.ResetText();


        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        bool trans = false;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            trans = true;

            comboBox6.Visible = true;
            diasCarga.Visible = true;
            comboBox2.Visible = true;
            zonaLabl.Visible = true;
            checkBox1.Visible = true;
            checkBox4.Visible = true;
            checkBox3.Visible = true;
            comboBox8.Visible = true;
            cais.Visible = true;
            capPale.Visible = true;
            comboBox4.Visible = true;
            checkBox2.Visible = true;
            checkBox7.Visible = true;
            horaCarga.Visible = true;
            comboBox3.Visible = true;
            comboBox8.Visible = true;
            comboBox4.Visible = true;

            comboBox5.Visible = false;
            label1.Visible = false;

            comboBox5.ResetText();
            comboBox7.ResetText();
        }

        private void comboBox7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            trans = false;

            comboBox6.Visible = true;
            diasCarga.Visible = true;
            comboBox2.Visible = true;
            zonaLabl.Visible = true;
            checkBox1.Visible = true;
            checkBox4.Visible = true;
            checkBox3.Visible = true;
            comboBox8.Visible = true;
            comboBox5.Visible = true;
            label1.Visible = true;

            cais.Visible = false;
            capPale.Visible = false;
            comboBox4.Visible = false;
            checkBox2.Visible = false;
            checkBox7.Visible = false;
            horaCarga.Visible = false;
            comboBox3.Visible = false;
            comboBox8.Visible = false;
            comboBox4.Visible = false;

            comboBox3.ResetText();
            comboBox2.ResetText();
            comboBox5.ResetText();
            comboBox1.ResetText();
            comboBox8.ResetText();
            comboBox4.ResetText();
            checkBox2.Checked = false;
            checkBox7.Checked = false;
            
        }
    }
}
