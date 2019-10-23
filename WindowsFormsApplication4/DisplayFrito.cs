using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class DisplayFrito : Form
    {
        public DisplayFrito()
        {
            InitializeComponent();
        }

        private void DisplayFrito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMDDataSet.EncomendasFritas' table. You can move, or remove it, as needed.
            this.encomendasFritasTableAdapter.Fill(this.aMDDataSet.EncomendasFritas);

            /*
            string connectionString = ConfigurationManager.ConnectionStrings["AMD"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("Select * from EncomendasFritas where Semana == @Estado", con);

            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();

    */
        }

        public int numCarga;

        private void encomendasFritasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var encomenda = int.Parse(encomendasFritasDataGridView[0, e.RowIndex].Value.ToString());
            VerEncomenda Check = new VerEncomenda(encomenda);
            Check.Show();



        }
    }
}
