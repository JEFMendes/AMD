using System;
using System.Windows.Forms;

namespace AMDManager
{
    public partial class MainFormView : Form
    {
        static MainFormView Instance;

        static Button Back { get; set; }

        public static void ShowForm(Form m)
        {
            if (Instance == null)
                return;
            var controls = Instance.Controls;
            for(int i = 0; controls.Count > 1;)
            {
                if ( controls[i] != Back)
                    controls.RemoveAt(i);
                else
                {
                    i++;
                }
            }
            m.TopLevel = false;
            m.Dock = DockStyle.Fill;
            m.Parent = MainFormView.Instance;
            m.FormBorderStyle = FormBorderStyle.None;
            Instance.Text = m.Text;
            
            Instance.BackButton.Visible = !(m is Menu);
           

            if (m is AddCliente || m is GerirPlanoSemanal || m is GerirEncomendas || m is GerirArmazens || m is AddComercial || m is Login || m is GestorDePrecos || m is GerirClientes || m is GerirComerciais || m is GerirTransportadoras || m is GerirVeiculos || m is GerirZonas || m is AddTransp || m is AddVeiculo || m is Menu || m is GerirUtilizadores)
            {
                Instance.BackButton.Visible = false;
            }
      
            m.Show();
        }

      
        public MainFormView()
        {
            InitializeComponent();
            Instance = this;
            ShowForm(new Login());
            Back = this.BackButton;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ShowForm(new Menu());
        }

        private void MainFormView_Load(object sender, EventArgs e)
        {

        }
    }
}
