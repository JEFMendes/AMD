using System;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class GerirVeiculos : Form
    {
        public GerirVeiculos()
        {
            InitializeComponent();
        }

        private void veiculosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.veiculosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.aMDDataSet);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos efetuar as alterações. Por favor tente mais tarde.");
            }
            

        }

        private void GerirVeiculos_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());
        }
    }
}
