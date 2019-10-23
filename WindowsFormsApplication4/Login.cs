using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.Users' table. You can move, or remove it, as needed.
                this.usersTableAdapter.Fill(this.aMDDataSet.Users);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
                //MessageBox.Show("Não conseguimos carregar a tabela de utilizadores. Por favor tente mais tarde.");
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            
            string id = textBox1.Text;
            string password = textBox2.Text;
            
            SqlCommand cmd = new SqlCommand("Select * from Users where Id=@Id and Password=@Password", con);
            cmd.Parameters.AddWithValue("@Id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;

            //If count is equal to 1, then show Menu
            if (count == 1)
            {

                // update na BD dos logins
                SqlCommand com = new SqlCommand("INSERT INTO Logins (\"User\", DataLogin) VALUES (@User, @DataLogin)", con);
                com.CommandType = CommandType.Text;

                DateTime myDateTime = DateTime.Now;
                string sqlFormattedDate = myDateTime.ToString("u");

                com.Parameters.AddWithValue("@User", textBox1.Text);
                com.Parameters.AddWithValue("@DataLogin", sqlFormattedDate);

                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                
                MessageBox.Show("Bem vindo!");
                MainFormView.ShowForm(new Menu());
            }
            else
            {
                MessageBox.Show("Por favor verifique o seu Username e Password!");
            }

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(sender, e);
            }
}
    }
}
