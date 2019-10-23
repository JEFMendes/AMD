namespace WindowsFormsApplication4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolliSecs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalFrais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolliFrais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PalSurgele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolliSurgele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoExtra = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CamionRidelle = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zona = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Code,
            this.PalSec,
            this.RolliSecs,
            this.PalFrais,
            this.RolliFrais,
            this.PalSurgele,
            this.RolliSurgele,
            this.Peso,
            this.InfoExtra,
            this.CamionRidelle,
            this.Data,
            this.Zona});
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1451, 631);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Client
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Client.DefaultCellStyle = dataGridViewCellStyle1;
            this.Client.HeaderText = "Client";
            this.Client.MaxDropDownItems = 100;
            this.Client.Name = "Client";
            this.Client.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Client.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Code
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.Code.DefaultCellStyle = dataGridViewCellStyle2;
            this.Code.HeaderText = "Code nr.";
            this.Code.Name = "Code";
            this.Code.ToolTipText = "Codigo da encomenda";
            // 
            // PalSec
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.PalSec.DefaultCellStyle = dataGridViewCellStyle3;
            this.PalSec.HeaderText = "Pal Secs";
            this.PalSec.Name = "PalSec";
            this.PalSec.ToolTipText = "Number of pallets of fresh products";
            // 
            // RolliSecs
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.RolliSecs.DefaultCellStyle = dataGridViewCellStyle4;
            this.RolliSecs.HeaderText = "Rolli Secs";
            this.RolliSecs.Name = "RolliSecs";
            // 
            // PalFrais
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.PalFrais.DefaultCellStyle = dataGridViewCellStyle5;
            this.PalFrais.HeaderText = "Pal Frais";
            this.PalFrais.Name = "PalFrais";
            // 
            // RolliFrais
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.RolliFrais.DefaultCellStyle = dataGridViewCellStyle6;
            this.RolliFrais.HeaderText = "Rolli Frais";
            this.RolliFrais.Name = "RolliFrais";
            // 
            // PalSurgele
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            this.PalSurgele.DefaultCellStyle = dataGridViewCellStyle7;
            this.PalSurgele.HeaderText = "Pal Surgele";
            this.PalSurgele.Name = "PalSurgele";
            // 
            // RolliSurgele
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            this.RolliSurgele.DefaultCellStyle = dataGridViewCellStyle8;
            this.RolliSurgele.HeaderText = "Rolli Surgele";
            this.RolliSurgele.Name = "RolliSurgele";
            // 
            // Peso
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = "0,00";
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Peso.DefaultCellStyle = dataGridViewCellStyle9;
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // InfoExtra
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InfoExtra.DefaultCellStyle = dataGridViewCellStyle10;
            this.InfoExtra.HeaderText = "Info Horaires";
            this.InfoExtra.Name = "InfoExtra";
            this.InfoExtra.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InfoExtra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CamionRidelle
            // 
            this.CamionRidelle.HeaderText = "Camion Avec Ridelle";
            this.CamionRidelle.Name = "CamionRidelle";
            // 
            // Data
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle11;
            this.Data.HeaderText = "Dia entrega";
            this.Data.Name = "Data";
            // 
            // Zona
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Zona.DefaultCellStyle = dataGridViewCellStyle12;
            this.Zona.HeaderText = "Zona";
            this.Zona.Name = "Zona";
            this.Zona.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 700);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn PalSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolliSecs;
        private System.Windows.Forms.DataGridViewTextBoxColumn PalFrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolliFrais;
        private System.Windows.Forms.DataGridViewTextBoxColumn PalSurgele;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolliSurgele;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewComboBoxColumn InfoExtra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CamionRidelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewComboBoxColumn Zona;
    }
}

