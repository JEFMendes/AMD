using System;
using System.Drawing;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class Arquivo : Form
    {
        public Arquivo()
        {
            InitializeComponent();
        }

        Bitmap bmpPrint;

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmpPrint = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmpPrint);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printDialog1.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu Check = new Menu();
            Check.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //VerEncomenda Check = new VerEncomenda();
            //Check.Show();
            this.Hide();
        }

        private void arquivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.arquivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aMDDataSet);

        }

        private void Arquivo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aMDDataSet.Arquivo'. Você pode movê-la ou removê-la conforme necessário.
            this.arquivoTableAdapter.Fill(this.aMDDataSet.Arquivo);

        }
    }
}
