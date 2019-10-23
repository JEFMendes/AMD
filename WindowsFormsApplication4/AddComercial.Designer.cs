namespace AMDManager
{
    partial class AddComercial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddComercial));
            this.zona = new System.Windows.Forms.Label();
            this.Morada = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.nomeClient = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.veiculosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aMDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMDDataSet = new AMDManager.AMDDataSet();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.custoH = new System.Windows.Forms.Label();
            this.criarComer = new System.Windows.Forms.Button();
            this.veiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculosTableAdapter = new AMDManager.AMDDataSetTableAdapters.VeiculosTableAdapter();
            this.distanciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distanciasTableAdapter = new AMDManager.AMDDataSetTableAdapters.DistanciasTableAdapter();
            this.tableAdapterManager = new AMDManager.AMDDataSetTableAdapters.TableAdapterManager();
            this.distanciasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.distanciasTableAdapter1 = new AMDManager.AMDDataSetTableAdapters.DistanciasTableAdapter();
            this.tableAdapterManager1 = new AMDManager.AMDDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.distanciasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.distanciasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.distanciasListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // zona
            // 
            this.zona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zona.Location = new System.Drawing.Point(561, 233);
            this.zona.Name = "zona";
            this.zona.Size = new System.Drawing.Size(54, 23);
            this.zona.TabIndex = 45;
            this.zona.Text = "Zona:";
            this.zona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Morada
            // 
            this.Morada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Morada.Location = new System.Drawing.Point(496, 171);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(68, 23);
            this.Morada.TabIndex = 43;
            this.Morada.Text = "Veiculo:";
            this.Morada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(570, 127);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(444, 22);
            this.maskedTextBox1.TabIndex = 42;
            // 
            // nomeClient
            // 
            this.nomeClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClient.Location = new System.Drawing.Point(500, 127);
            this.nomeClient.Name = "nomeClient";
            this.nomeClient.Size = new System.Drawing.Size(64, 23);
            this.nomeClient.TabIndex = 41;
            this.nomeClient.Text = "Nome:";
            this.nomeClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.veiculosBindingSource1;
            this.comboBox3.DisplayMember = "Matricula";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(570, 170);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(141, 24);
            this.comboBox3.TabIndex = 49;
            this.comboBox3.ValueMember = "Matricula";
            // 
            // veiculosBindingSource1
            // 
            this.veiculosBindingSource1.DataMember = "Veiculos";
            this.veiculosBindingSource1.DataSource = this.aMDDataSetBindingSource;
            // 
            // aMDDataSetBindingSource
            // 
            this.aMDDataSetBindingSource.DataSource = this.aMDDataSet;
            this.aMDDataSetBindingSource.Position = 0;
            // 
            // aMDDataSet
            // 
            this.aMDDataSet.DataSetName = "AMDDataSet";
            this.aMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(873, 172);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.PromptChar = ' ';
            this.maskedTextBox3.Size = new System.Drawing.Size(141, 22);
            this.maskedTextBox3.TabIndex = 53;
            // 
            // custoH
            // 
            this.custoH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.custoH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custoH.Location = new System.Drawing.Point(745, 171);
            this.custoH.Name = "custoH";
            this.custoH.Size = new System.Drawing.Size(122, 23);
            this.custoH.TabIndex = 52;
            this.custoH.Text = "Custo por hora:";
            this.custoH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // criarComer
            // 
            this.criarComer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criarComer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.criarComer.Location = new System.Drawing.Point(685, 478);
            this.criarComer.Name = "criarComer";
            this.criarComer.Size = new System.Drawing.Size(167, 63);
            this.criarComer.TabIndex = 55;
            this.criarComer.Text = "Adicionar comercial";
            this.criarComer.UseVisualStyleBackColor = false;
            this.criarComer.Click += new System.EventHandler(this.criarComer_Click);
            this.criarComer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.criarComer_MouseClick);
            // 
            // veiculosBindingSource
            // 
            this.veiculosBindingSource.DataMember = "Veiculos";
            this.veiculosBindingSource.DataSource = this.aMDDataSet;
            // 
            // veiculosTableAdapter
            // 
            this.veiculosTableAdapter.ClearBeforeFill = true;
            // 
            // distanciasBindingSource
            // 
            this.distanciasBindingSource.DataMember = "Distancias";
            this.distanciasBindingSource.DataSource = this.aMDDataSet;
            // 
            // distanciasTableAdapter
            // 
            this.distanciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArquivoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComerciaisTableAdapter = null;
            this.tableAdapterManager.DistanciasTableAdapter = this.distanciasTableAdapter;
            this.tableAdapterManager.EncomendasAttalensTableAdapter = null;
            this.tableAdapterManager.EncomendasFritasTableAdapter = null;
            this.tableAdapterManager.EncomendasTableAdapter = null;
            this.tableAdapterManager.LoginsTableAdapter = null;
            this.tableAdapterManager.PlanoSemanalTableAdapter = null;
            this.tableAdapterManager.PrecosTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AMDManager.AMDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VeiculosTableAdapter = null;
            // 
            // distanciasBindingSource1
            // 
            this.distanciasBindingSource1.DataMember = "Distancias";
            this.distanciasBindingSource1.DataSource = this.aMDDataSet;
            // 
            // distanciasTableAdapter1
            // 
            this.distanciasTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ArquivoTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientesTableAdapter = null;
            this.tableAdapterManager1.ComerciaisTableAdapter = null;
            this.tableAdapterManager1.DistanciasTableAdapter = this.distanciasTableAdapter1;
            this.tableAdapterManager1.EncomendasAttalensTableAdapter = null;
            this.tableAdapterManager1.EncomendasFritasTableAdapter = null;
            this.tableAdapterManager1.EncomendasTableAdapter = null;
            this.tableAdapterManager1.LoginsTableAdapter = null;
            this.tableAdapterManager1.PlanoSemanalTableAdapter = null;
            this.tableAdapterManager1.PrecosTableAdapter = null;
            this.tableAdapterManager1.TableTableAdapter = null;
            this.tableAdapterManager1.TransportadorasTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = AMDManager.AMDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            this.tableAdapterManager1.VeiculosTableAdapter = this.veiculosTableAdapter;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AMDManager.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 56);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // distanciasBindingSource2
            // 
            this.distanciasBindingSource2.DataMember = "Distancias";
            this.distanciasBindingSource2.DataSource = this.aMDDataSet;
            // 
            // distanciasBindingSource3
            // 
            this.distanciasBindingSource3.DataMember = "Distancias";
            this.distanciasBindingSource3.DataSource = this.aMDDataSet;
            // 
            // distanciasListBox
            // 
            this.distanciasListBox.AccessibleDescription = "Usar \"Ctrl\" para selecionar varias opcoes";
            this.distanciasListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.distanciasListBox.DataSource = this.distanciasBindingSource3;
            this.distanciasListBox.DisplayMember = "Zona";
            this.distanciasListBox.FormattingEnabled = true;
            this.distanciasListBox.Location = new System.Drawing.Point(621, 215);
            this.distanciasListBox.Name = "distanciasListBox";
            this.distanciasListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.distanciasListBox.Size = new System.Drawing.Size(300, 212);
            this.distanciasListBox.TabIndex = 58;
            this.distanciasListBox.ValueMember = "Zona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(658, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Para selecionar várias opções pressione \"Ctrl\"";
            // 
            // AddComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.distanciasListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.criarComer);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.custoH);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.zona);
            this.Controls.Add(this.Morada);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.nomeClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddComercial";
            this.Text = "Adicionar Comercial";
            this.Load += new System.EventHandler(this.AddComercial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label zona;
        private System.Windows.Forms.Label Morada;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label nomeClient;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label custoH;
        private System.Windows.Forms.Button criarComer;
        private AMDDataSet aMDDataSet;
        private System.Windows.Forms.BindingSource veiculosBindingSource;
        private AMDDataSetTableAdapters.VeiculosTableAdapter veiculosTableAdapter;
        private System.Windows.Forms.BindingSource aMDDataSetBindingSource;
        private AMDDataSet AMDDataSet;
        private System.Windows.Forms.BindingSource distanciasBindingSource;
        private AMDDataSetTableAdapters.DistanciasTableAdapter distanciasTableAdapter;
        private AMDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource distanciasBindingSource1;
        private AMDDataSetTableAdapters.DistanciasTableAdapter distanciasTableAdapter1;
        private AMDDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource veiculosBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource distanciasBindingSource2;
        private System.Windows.Forms.BindingSource distanciasBindingSource3;
        private System.Windows.Forms.ListBox distanciasListBox;
        private System.Windows.Forms.Label label1;
    }
}