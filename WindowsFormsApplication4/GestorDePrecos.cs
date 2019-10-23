using System;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class GestorDePrecos : Form
    {
        public GestorDePrecos()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            BDpage Check = new BDpage();
            Check.Show();
            this.Hide();
        }

        private void GestorDePrecos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.Transportadoras' table. You can move, or remove it, as needed.
                this.transportadorasTableAdapter.Fill(this.aMDDataSet.Transportadoras);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de transportadoras. Por favor tente mais tarde.");
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
                // TODO: This line of code loads data into the 'aMDDataSet.Precos' table. You can move, or remove it, as needed.
                this.PrecosTableAdapter.Fill(this.aMDDataSet.Precos);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de preços. Por favor tente mais tarde.");
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)         // why isn't this working??? string null???
        {
            

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void PrecosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.PrecosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.aMDDataSet);
            }
            catch (Exception ex)
            {
                
            }

        }
    }
}
