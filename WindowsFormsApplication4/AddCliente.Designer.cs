namespace AMDManager
{
    partial class AddCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCliente));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.nomeClient = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.numClient = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.Morada = new System.Windows.Forms.Label();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.telefone = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.email = new System.Windows.Forms.Label();
            this.zona = new System.Windows.Forms.Label();
            this.comercial = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.distanciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AMDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AMDDataSet = new AMDManager.AMDDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comerciaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CriarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.distanciasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zonaOp2 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.distanciasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zonaOp3 = new System.Windows.Forms.Label();
            this.comerciaisTableAdapter = new AMDManager.AMDDataSetTableAdapters.ComerciaisTableAdapter();
            this.distanciasTableAdapter = new AMDManager.AMDDataSetTableAdapters.DistanciasTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.encomendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.encomendasTableAdapter = new AMDManager.AMDDataSetTableAdapters.EncomendasTableAdapter();
            this.tableAdapterManager = new AMDManager.AMDDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comerciaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(194, 281);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(444, 22);
            this.maskedTextBox1.TabIndex = 19;
            // 
            // nomeClient
            // 
            this.nomeClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClient.Location = new System.Drawing.Point(124, 277);
            this.nomeClient.Name = "nomeClient";
            this.nomeClient.Size = new System.Drawing.Size(64, 23);
            this.nomeClient.TabIndex = 18;
            this.nomeClient.Text = "Nome:";
            this.nomeClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(905, 281);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PromptChar = ' ';
            this.maskedTextBox2.Size = new System.Drawing.Size(139, 22);
            this.maskedTextBox2.TabIndex = 21;
            // 
            // numClient
            // 
            this.numClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numClient.Location = new System.Drawing.Point(750, 281);
            this.numClient.Name = "numClient";
            this.numClient.Size = new System.Drawing.Size(149, 23);
            this.numClient.TabIndex = 20;
            this.numClient.Text = "Numero de cliente:";
            this.numClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(194, 323);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.PromptChar = ' ';
            this.maskedTextBox3.Size = new System.Drawing.Size(444, 22);
            this.maskedTextBox3.TabIndex = 23;
            // 
            // Morada
            // 
            this.Morada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Morada.Location = new System.Drawing.Point(120, 323);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(68, 23);
            this.Morada.TabIndex = 22;
            this.Morada.Text = "Morada:";
            this.Morada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox4.Location = new System.Drawing.Point(905, 322);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.PromptChar = ' ';
            this.maskedTextBox4.Size = new System.Drawing.Size(139, 22);
            this.maskedTextBox4.TabIndex = 25;
            // 
            // telefone
            // 
            this.telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(824, 322);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(75, 23);
            this.telefone.TabIndex = 24;
            this.telefone.Text = "Telefone:";
            this.telefone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.telefone.Click += new System.EventHandler(this.labes_Click);
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox5.Location = new System.Drawing.Point(1143, 321);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.PromptChar = ' ';
            this.maskedTextBox5.Size = new System.Drawing.Size(204, 22);
            this.maskedTextBox5.TabIndex = 27;
            this.maskedTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(1082, 321);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(55, 23);
            this.email.TabIndex = 26;
            this.email.Text = "Email:";
            this.email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zona
            // 
            this.zona.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zona.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zona.Location = new System.Drawing.Point(134, 406);
            this.zona.Name = "zona";
            this.zona.Size = new System.Drawing.Size(54, 23);
            this.zona.TabIndex = 28;
            this.zona.Text = "Zona:";
            this.zona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comercial
            // 
            this.comercial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comercial.Location = new System.Drawing.Point(100, 366);
            this.comercial.Name = "comercial";
            this.comercial.Size = new System.Drawing.Size(92, 23);
            this.comercial.TabIndex = 30;
            this.comercial.Text = "Comercial:";
            this.comercial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AccessibleDescription = "Apenas disponivel para comerciais";
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(878, 494);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 20);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Entrega pelo comercial";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // checkBox2
            // 
            this.checkBox2.AccessibleDescription = "";
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(878, 445);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 20);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "Camiao com Ridelle";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DataSource = this.distanciasBindingSource;
            this.comboBox1.DisplayMember = "Zona";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(194, 405);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // distanciasBindingSource
            // 
            this.distanciasBindingSource.DataMember = "Distancias";
            this.distanciasBindingSource.DataSource = this.AMDDataSetBindingSource;
            // 
            // AMDDataSetBindingSource
            // 
            this.AMDDataSetBindingSource.DataSource = this.AMDDataSet;
            this.AMDDataSetBindingSource.Position = 0;
            // 
            // AMDDataSet
            // 
            this.AMDDataSet.DataSetName = "AMDDataSet";
            this.AMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.DataSource = this.comerciaisBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(194, 365);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(248, 24);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.ValueMember = "Nome";
            // 
            // comerciaisBindingSource
            // 
            this.comerciaisBindingSource.DataMember = "Comerciais";
            this.comerciaisBindingSource.DataSource = this.AMDDataSetBindingSource;
            // 
            // CriarCliente
            // 
            this.CriarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CriarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CriarCliente.Location = new System.Drawing.Point(633, 611);
            this.CriarCliente.Name = "CriarCliente";
            this.CriarCliente.Size = new System.Drawing.Size(167, 63);
            this.CriarCliente.TabIndex = 49;
            this.CriarCliente.Text = "Adicionar Cliente";
            this.CriarCliente.UseVisualStyleBackColor = false;
            this.CriarCliente.Click += new System.EventHandler(this.CriarCliente_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Cod. Postal:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox6.Location = new System.Drawing.Point(905, 363);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.PromptChar = ' ';
            this.maskedTextBox6.Size = new System.Drawing.Size(139, 22);
            this.maskedTextBox6.TabIndex = 51;
            // 
            // checkBox3
            // 
            this.checkBox3.AccessibleDescription = "Apenas disponivel para comerciais";
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(1086, 444);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(218, 20);
            this.checkBox3.TabIndex = 52;
            this.checkBox3.Text = "Entrada sem acesso de camiao";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.DataSource = this.distanciasBindingSource1;
            this.comboBox3.DisplayMember = "Zona";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(198, 444);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(248, 24);
            this.comboBox3.TabIndex = 54;
            this.comboBox3.ValueMember = "Zona";
            // 
            // distanciasBindingSource1
            // 
            this.distanciasBindingSource1.DataMember = "Distancias";
            this.distanciasBindingSource1.DataSource = this.AMDDataSetBindingSource;
            // 
            // zonaOp2
            // 
            this.zonaOp2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zonaOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zonaOp2.Location = new System.Drawing.Point(75, 445);
            this.zonaOp2.Name = "zonaOp2";
            this.zonaOp2.Size = new System.Drawing.Size(117, 23);
            this.zonaOp2.TabIndex = 53;
            this.zonaOp2.Text = "Opção zona 2:";
            this.zonaOp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.DataSource = this.distanciasBindingSource2;
            this.comboBox4.DisplayMember = "Zona";
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(198, 481);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(248, 24);
            this.comboBox4.TabIndex = 56;
            this.comboBox4.ValueMember = "Zona";
            // 
            // distanciasBindingSource2
            // 
            this.distanciasBindingSource2.DataMember = "Distancias";
            this.distanciasBindingSource2.DataSource = this.AMDDataSet;
            // 
            // zonaOp3
            // 
            this.zonaOp3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zonaOp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zonaOp3.Location = new System.Drawing.Point(79, 482);
            this.zonaOp3.Name = "zonaOp3";
            this.zonaOp3.Size = new System.Drawing.Size(113, 23);
            this.zonaOp3.TabIndex = 55;
            this.zonaOp3.Text = "Opção zona 3:";
            this.zonaOp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comerciaisTableAdapter
            // 
            this.comerciaisTableAdapter.ClearBeforeFill = true;
            // 
            // distanciasTableAdapter
            // 
            this.distanciasTableAdapter.ClearBeforeFill = true;
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
            this.button1.TabIndex = 57;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AccessibleDescription = "Apenas disponivel para comerciais";
            this.checkBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(1086, 494);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(147, 20);
            this.checkBox4.TabIndex = 58;
            this.checkBox4.Text = "Entrega em Attalens";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // encomendasBindingSource
            // 
            this.encomendasBindingSource.DataMember = "Encomendas";
            this.encomendasBindingSource.DataSource = this.AMDDataSet;
            // 
            // encomendasTableAdapter
            // 
            this.encomendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArquivoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComerciaisTableAdapter = this.comerciaisTableAdapter;
            this.tableAdapterManager.DistanciasTableAdapter = this.distanciasTableAdapter;
            this.tableAdapterManager.EncomendasAttalensTableAdapter = null;
            this.tableAdapterManager.EncomendasFritasTableAdapter = null;
            this.tableAdapterManager.EncomendasTableAdapter = this.encomendasTableAdapter;
            this.tableAdapterManager.LoginsTableAdapter = null;
            this.tableAdapterManager.PlanoSemanalTableAdapter = null;
            this.tableAdapterManager.PrecosTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AMDManager.AMDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VeiculosTableAdapter = null;
            // 
            // AddCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 1053);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.zonaOp3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.zonaOp2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CriarCliente);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.comercial);
            this.Controls.Add(this.zona);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.Morada);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.numClient);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.nomeClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCliente";
            this.Text = "Adicionar Cliente";
            this.Load += new System.EventHandler(this.AddCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comerciaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label nomeClient;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label numClient;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label Morada;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label zona;
        private System.Windows.Forms.Label comercial;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button CriarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label zonaOp2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label zonaOp3;
        private System.Windows.Forms.BindingSource AMDDataSetBindingSource;
        private AMDDataSet AMDDataSet;
        private System.Windows.Forms.BindingSource comerciaisBindingSource;
        private AMDDataSetTableAdapters.ComerciaisTableAdapter comerciaisTableAdapter;
        private System.Windows.Forms.BindingSource distanciasBindingSource;
        private AMDDataSetTableAdapters.DistanciasTableAdapter distanciasTableAdapter;
        private System.Windows.Forms.BindingSource distanciasBindingSource1;
        private System.Windows.Forms.BindingSource distanciasBindingSource2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.BindingSource encomendasBindingSource;
        private AMDDataSetTableAdapters.EncomendasTableAdapter encomendasTableAdapter;
        private AMDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}