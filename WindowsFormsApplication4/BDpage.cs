using System;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class BDpage : Form
    {
        public BDpage()
        {
            InitializeComponent();

            System.Windows.Forms.Form log = System.Windows.Forms.Application.OpenForms["Login"];

            string ID = ((Login)log).textBox1.Text;

            if (ID == "Admin" || ID == "admin")
            {
                
            }

            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                GerirVeiculos.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label11.Visible = false;
            }
        }

        private void AddCliente_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddCliente());
        }

    

        private void AddComer_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddComercial());

        }

        private void AddVeiculo_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddVeiculo());

        }

        private void AddTrans_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new AddTransp());

        }

        private void tabelaPrecos_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GestorDePrecos());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirVeiculos());
        }

        private void GerirZonas_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirZonas());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirClientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirTransportadoras());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirComerciais());
        }

        private void AddCliente_MouseHover(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirUtilizadores());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirPlanoSemanal());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirEncomendas());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirArmazens());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new GerirPaletes());
        }
    }
}
