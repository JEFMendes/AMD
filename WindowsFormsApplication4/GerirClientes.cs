using System;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class GerirClientes : Form
    {
        public GerirClientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.aMDDataSet);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos efetuar as alterações. Por favor tente mais tarde.");
            }
        }

        private void GerirClientes_Load(object sender, EventArgs e)
        {

            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.Clientes' table. You can move, or remove it, as needed.
                this.clientesTableAdapter.Fill(this.aMDDataSet.Clientes);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de clientes. Por favor tente mais tarde.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());
        }
    }
}
