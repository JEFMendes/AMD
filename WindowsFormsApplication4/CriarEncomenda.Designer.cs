namespace AMDManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.laes = new System.Windows.Forms.Label();
            this.labes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AMDDataSet = new AMDManager.AMDDataSet();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CriarEntrega = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.IconCong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox11 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.clientesTableAdapter = new AMDManager.AMDDataSetTableAdapters.ClientesTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // laes
            // 
            this.laes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.laes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laes.Location = new System.Drawing.Point(113, 103);
            this.laes.Name = "laes";
            this.laes.Size = new System.Drawing.Size(100, 23);
            this.laes.TabIndex = 3;
            this.laes.Text = "Cliente:";
            this.laes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labes
            // 
            this.labes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labes.Location = new System.Drawing.Point(668, 103);
            this.labes.Name = "labes";
            this.labes.Size = new System.Drawing.Size(179, 23);
            this.labes.TabIndex = 4;
            this.labes.Text = "Codigo da encomenda:";
            this.labes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labes.Click += new System.EventHandler(this.labes_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade Paletes Secos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(668, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade Rolli Secos:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade Paletes Frescos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade Rolli Frescos:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantidade Paletes Congelados:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(628, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantidade Rolli Congelados:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AccessibleDescription = "Apenas disponivel para comerciais";
            this.label11.AccessibleName = "Apenas disponivel para comerciais";
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(264, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 23);
            this.label11.TabIndex = 15;
            this.label11.Text = "Peso (Kg):";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseHover += new System.EventHandler(this.label11_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.clientesBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.Location = new System.Drawing.Point(219, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(402, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "Nome";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.AMDDataSet;
            // 
            // AMDDataSet
            // 
            this.AMDDataSet.DataSetName = "AMDDataSet";
            this.AMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(853, 107);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 17;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(387, 155);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PromptChar = ' ';
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox2.TabIndex = 18;
            this.maskedTextBox2.Text = "0";
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox3.Location = new System.Drawing.Point(853, 155);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.PromptChar = ' ';
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox3.TabIndex = 19;
            this.maskedTextBox3.Text = "0";
            this.maskedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskedTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox4.Location = new System.Drawing.Point(387, 205);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.PromptChar = ' ';
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox4.TabIndex = 20;
            this.maskedTextBox4.Text = "0";
            this.maskedTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskedTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox5.Location = new System.Drawing.Point(853, 205);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.PromptChar = ' ';
            this.maskedTextBox5.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox5.TabIndex = 21;
            this.maskedTextBox5.Text = "0";
            this.maskedTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maskedTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox6.Location = new System.Drawing.Point(387, 250);
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.PromptChar = ' ';
            this.maskedTextBox6.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox6.TabIndex = 22;
            this.maskedTextBox6.Text = "0";
            this.maskedTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maskedTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox7.Location = new System.Drawing.Point(853, 250);
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox7.TabIndex = 23;
            this.maskedTextBox7.Text = "0";
            this.maskedTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.AccessibleDescription = "Apenas disponivel para comerciais";
            this.maskedTextBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox8.Location = new System.Drawing.Point(387, 298);
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.PromptChar = ' ';
            this.maskedTextBox8.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox8.TabIndex = 24;
            this.maskedTextBox8.MouseHover += new System.EventHandler(this.maskedTextBox8_MouseHover);
            // 
            // checkBox2
            // 
            this.checkBox2.AccessibleDescription = "";
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(645, 327);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 20);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "Camiao com Ridelle";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "6h",
            "7h",
            "8h",
            "9h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h"});
            this.comboBox4.Location = new System.Drawing.Point(387, 388);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 31;
            this.comboBox4.Text = "ate:";
            // 
            // comboBox5
            // 
            this.comboBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "6h",
            "7h",
            "8h",
            "9h",
            "10h",
            "11h",
            "12h",
            "13h",
            "14h",
            "15h",
            "16h",
            "17h"});
            this.comboBox5.Location = new System.Drawing.Point(250, 388);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 30;
            this.comboBox5.Text = "de:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(96, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Hora de descarga:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CriarEntrega
            // 
            this.CriarEntrega.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CriarEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CriarEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriarEntrega.Location = new System.Drawing.Point(701, 483);
            this.CriarEntrega.Name = "CriarEntrega";
            this.CriarEntrega.Size = new System.Drawing.Size(167, 63);
            this.CriarEntrega.TabIndex = 33;
            this.CriarEntrega.Text = "Criar encomenda";
            this.CriarEntrega.UseVisualStyleBackColor = false;
            this.CriarEntrega.Click += new System.EventHandler(this.CriarEntrega_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AccessibleDescription = "Apenas disponivel para comerciais";
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(598, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 20);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Entrega de comercial";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // IconCong
            // 
            this.IconCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IconCong.BackColor = System.Drawing.SystemColors.Control;
            this.IconCong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconCong.BackgroundImage")));
            this.IconCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconCong.FlatAppearance.BorderSize = 0;
            this.IconCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconCong.Location = new System.Drawing.Point(493, 241);
            this.IconCong.Name = "IconCong";
            this.IconCong.Size = new System.Drawing.Size(38, 35);
            this.IconCong.TabIndex = 35;
            this.IconCong.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(959, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(959, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 31);
            this.button3.TabIndex = 38;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(493, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 31);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(493, 151);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 30);
            this.button5.TabIndex = 41;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(959, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 30);
            this.button4.TabIndex = 42;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AccessibleDescription = "Apenas disponivel para comerciais";
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(800, 327);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(218, 20);
            this.checkBox3.TabIndex = 45;
            this.checkBox3.Text = "Entrada sem acesso de camiao";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AccessibleDescription = "";
            this.checkBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(666, 182);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(117, 24);
            this.checkBox4.TabIndex = 48;
            this.checkBox4.Text = "Congelados:";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AccessibleDescription = "";
            this.checkBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(532, 182);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(89, 24);
            this.checkBox5.TabIndex = 47;
            this.checkBox5.Text = "Frescos:";
            this.checkBox5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.Visible = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AccessibleDescription = "";
            this.checkBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(405, 181);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(77, 24);
            this.checkBox6.TabIndex = 46;
            this.checkBox6.Text = "Secos:";
            this.checkBox6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.Visible = false;
            // 
            // checkBox7
            // 
            this.checkBox7.AccessibleDescription = "";
            this.checkBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(773, 45);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(198, 20);
            this.checkBox7.TabIndex = 49;
            this.checkBox7.Text = "Armazem de saida adicional";
            this.checkBox7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(1387, 155);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 30);
            this.button6.TabIndex = 58;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1387, 205);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 31);
            this.button7.TabIndex = 57;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1387, 245);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(38, 35);
            this.button8.TabIndex = 56;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.maskedTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox9.Location = new System.Drawing.Point(1281, 254);
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.PromptChar = ' ';
            this.maskedTextBox9.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox9.TabIndex = 55;
            this.maskedTextBox9.Text = "0";
            this.maskedTextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox9.Visible = false;
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskedTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox10.Location = new System.Drawing.Point(1281, 209);
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.PromptChar = ' ';
            this.maskedTextBox10.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox10.TabIndex = 54;
            this.maskedTextBox10.Text = "0";
            this.maskedTextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox10.Visible = false;
            // 
            // maskedTextBox11
            // 
            this.maskedTextBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maskedTextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox11.Location = new System.Drawing.Point(1281, 159);
            this.maskedTextBox11.Name = "maskedTextBox11";
            this.maskedTextBox11.PromptChar = ' ';
            this.maskedTextBox11.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox11.TabIndex = 53;
            this.maskedTextBox11.Text = "0";
            this.maskedTextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox11.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1007, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 23);
            this.label7.TabIndex = 52;
            this.label7.Text = "Quantidade Paletes Congelados:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1007, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 23);
            this.label8.TabIndex = 51;
            this.label8.Text = "Quantidade Paletes Frescos:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1007, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "Quantidade Paletes Secos:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Transdis Sion",
            "Girardet Lausanne",
            "Transdis Dieticon"});
            this.comboBox2.Location = new System.Drawing.Point(1094, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(331, 24);
            this.comboBox2.TabIndex = 60;
            this.comboBox2.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(988, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 59;
            this.label12.Text = "Armazem:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "15h",
            "16h",
            "17h",
            "18h"});
            this.comboBox3.Location = new System.Drawing.Point(531, 415);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 62;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(405, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 23);
            this.label13.TabIndex = 61;
            this.label13.Text = "Hora de carga:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(701, 415);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 23);
            this.label14.TabIndex = 63;
            this.label14.Text = "Data de carga:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Visible = false;
            // 
            // comboBox6
            // 
            this.comboBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sabado"});
            this.comboBox6.Location = new System.Drawing.Point(822, 418);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(170, 21);
            this.comboBox6.TabIndex = 64;
            this.comboBox6.Visible = false;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1061, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 23);
            this.label15.TabIndex = 65;
            this.label15.Text = "Observações: ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1188, 328);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 193);
            this.textBox1.TabIndex = 66;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Apenas disponivel para Comerciais";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.maskedTextBox9);
            this.Controls.Add(this.maskedTextBox10);
            this.Controls.Add(this.maskedTextBox11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IconCong);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CriarEntrega);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.maskedTextBox8);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labes);
            this.Controls.Add(this.laes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Encomenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laes;
        private System.Windows.Forms.Label labes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button CriarEntrega;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button IconCong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox3;
        private AMDDataSet AMDDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox6;
        private AMDDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
    }
}

