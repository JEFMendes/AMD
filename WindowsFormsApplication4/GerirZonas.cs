using System;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class GerirZonas : Form
    {
        public GerirZonas()
        {
            InitializeComponent();
        }

        private void distanciasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.distanciasBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.AMDDataSet);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos efetuar as alterações. Por favor tente mais tarde.");
            }
        }

        private void GerirZonas_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'AMDDataSet.Distancias' table. You can move, or remove it, as needed.
                this.distanciasTableAdapter.Fill(this.AMDDataSet.Distancias);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de zonas. Por favor tente mais tarde.");
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());
        }
    }
}
