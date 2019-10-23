using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class GerirArmazens : Form
    {
        public GerirArmazens()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormView.ShowForm(new BDpage());
        }

        private void armazensBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.armazensBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aMDDataSet);

        }

        private void GerirArmazens_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aMDDataSet.Armazens' table. You can move, or remove it, as needed.
            this.armazensTableAdapter.Fill(this.aMDDataSet.Armazens);

        }
    }
}
