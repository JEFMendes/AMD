using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class AddRemovePaletes : Form
    {
        public AddRemovePaletes()
        {
            InitializeComponent();
        }

        private void transportadorasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transportadorasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aMDDataSet);

        }

        private void AddRemovePaletes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMDDataSet.Transportadoras' table. You can move, or remove it, as needed.
            this.transportadorasTableAdapter.Fill(this.aMDDataSet.Transportadoras);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new Menu());
        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            try
            {*/
               string trans = transportadorasListBox.SelectedValue.ToString();

                // Insert in database
                string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
                SqlConnection con = new SqlConnection(connectionString);
            
                SqlCommand com2 = new SqlCommand("SELECT Total FROM Paletes WHERE Transportadora = @trans", con);
                com2.CommandType = CommandType.Text;

                con.Open();

                int aefs = (Int32)com2.ExecuteScalar();
                
                //int aefs = Convert.ToInt32(SqlCommand.ExecuteScalar());
                int entrada = Convert.ToInt32(textBox1.Text);
                int saida = Convert.ToInt32(textBox2.Text);
                int total = 0;//aefs + entrada - saida;

                SqlCommand com = new SqlCommand("UPDATE Paletes SET Total=@Total, Entrada=@Entrada, Saida=@Saida, Data=@Data WHERE Transportadora = @Trans", con);
                com.CommandType = CommandType.Text;

                DateTime data = DateTime.Now;

                com.Parameters.AddWithValue("@Trans", trans);
                com.Parameters.AddWithValue("@Total", total);
                com.Parameters.AddWithValue("@Entrada", entrada);
                com.Parameters.AddWithValue("@Saida", saida);
                com.Parameters.AddWithValue("@Data", data);

                
                int i = com.ExecuteNonQuery();
                con.Close();


                //Confirmation Message 
                MessageBox.Show("Alteração realizada com sucesso!");
            /*
            }
            catch (Exception x)
            {
                //Error Message 
                MessageBox.Show("Erro ao adicionar/remover paletes. Por favor tente novamente.");
            }*/
        }
    }
}
