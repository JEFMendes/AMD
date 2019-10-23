using System;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class GerirComerciais : Form
    {
        public GerirComerciais()
        {
            InitializeComponent();
        }

        private void comerciaisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.comerciaisBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.aMDDataSet);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos efetuar as alterações. Por favor tente mais tarde.");
            }
        }

        private void GerirComerciais_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.Comerciais' table. You can move, or remove it, as needed.
                this.comerciaisTableAdapter.Fill(this.aMDDataSet.Comerciais);
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
