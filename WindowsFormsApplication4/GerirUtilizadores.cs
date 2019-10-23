using System;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class GerirUtilizadores : Form
    {
        public GerirUtilizadores()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.aMDDataSet);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos efetuar as alterações. Por favor tente mais tarde.");
            }
        }

        private void GerirUtilizadores_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.Users' table. You can move, or remove it, as needed.
                this.usersTableAdapter1.Fill(this.aMDDataSet.Users);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de utilizadores. Por favor tente mais tarde.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());
        }
    }
}
