namespace AMDManager
{
    partial class GerirVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirVeiculos));
            this.aMDDataSet = new AMDManager.AMDDataSet();
            this.veiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculosTableAdapter = new AMDManager.AMDDataSetTableAdapters.VeiculosTableAdapter();
            this.tableAdapterManager = new AMDManager.AMDDataSetTableAdapters.TableAdapterManager();
            this.veiculosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.veiculosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.veiculosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aMDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingNavigator)).BeginInit();
            this.veiculosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aMDDataSet
            // 
            this.aMDDataSet.DataSetName = "AMDDataSet";
            this.aMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComerciaisTableAdapter = null;
            this.tableAdapterManager.DistanciasTableAdapter = null;
            this.tableAdapterManager.EncomendasTableAdapter = null;
            this.tableAdapterManager.PlanoSemanalTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AMDManager.AMDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeiculosTableAdapter = this.veiculosTableAdapter;
            // 
            // veiculosBindingNavigator
            // 
            this.veiculosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.veiculosBindingNavigator.BindingSource = this.veiculosBindingSource;
            this.veiculosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.veiculosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.veiculosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.veiculosBindingNavigatorSaveItem});
            this.veiculosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.veiculosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.veiculosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.veiculosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.veiculosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.veiculosBindingNavigator.Name = "veiculosBindingNavigator";
            this.veiculosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.veiculosBindingNavigator.Size = new System.Drawing.Size(1484, 25);
            this.veiculosBindingNavigator.TabIndex = 0;
            this.veiculosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // veiculosBindingNavigatorSaveItem
            // 
            this.veiculosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.veiculosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("veiculosBindingNavigatorSaveItem.Image")));
            this.veiculosBindingNavigatorSaveItem.Name = "veiculosBindingNavigatorSaveItem";
            this.veiculosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.veiculosBindingNavigatorSaveItem.Text = "Save Data";
            this.veiculosBindingNavigatorSaveItem.Click += new System.EventHandler(this.veiculosBindingNavigatorSaveItem_Click);
            // 
            // veiculosDataGridView
            // 
            this.veiculosDataGridView.AutoGenerateColumns = false;
            this.veiculosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veiculosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.veiculosDataGridView.DataSource = this.veiculosBindingSource;
            this.veiculosDataGridView.Location = new System.Drawing.Point(384, 128);
            this.veiculosDataGridView.Name = "veiculosDataGridView";
            this.veiculosDataGridView.Size = new System.Drawing.Size(645, 349);
            this.veiculosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Secos";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Secos";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Frescos";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Frescos";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Congelados";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Congelados";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Limite de peso";
            this.dataGridViewTextBoxColumn2.HeaderText = "Limite de peso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Classe";
            this.dataGridViewTextBoxColumn3.HeaderText = "Classe";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AMDManager.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 56);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GerirVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.veiculosDataGridView);
            this.Controls.Add(this.veiculosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirVeiculos";
            this.Text = "GerirVeiculos";
            this.Load += new System.EventHandler(this.GerirVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aMDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingNavigator)).EndInit();
            this.veiculosBindingNavigator.ResumeLayout(false);
            this.veiculosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AMDDataSet aMDDataSet;
        private System.Windows.Forms.BindingSource veiculosBindingSource;
        private AMDDataSetTableAdapters.VeiculosTableAdapter veiculosTableAdapter;
        private AMDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator veiculosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton veiculosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView veiculosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}