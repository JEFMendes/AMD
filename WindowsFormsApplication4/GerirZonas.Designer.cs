namespace AMDManager
{
    partial class GerirZonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirZonas));
            this.distanciasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.distanciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AMDDataSet = new AMDManager.AMDDataSet();
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
            this.distanciasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.distanciasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanciasTableAdapter = new AMDManager.AMDDataSetTableAdapters.DistanciasTableAdapter();
            this.tableAdapterManager = new AMDManager.AMDDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingNavigator)).BeginInit();
            this.distanciasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // distanciasBindingNavigator
            // 
            this.distanciasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.distanciasBindingNavigator.BindingSource = this.distanciasBindingSource;
            this.distanciasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.distanciasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.distanciasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.distanciasBindingNavigatorSaveItem});
            this.distanciasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.distanciasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.distanciasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.distanciasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.distanciasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.distanciasBindingNavigator.Name = "distanciasBindingNavigator";
            this.distanciasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.distanciasBindingNavigator.Size = new System.Drawing.Size(1484, 25);
            this.distanciasBindingNavigator.TabIndex = 0;
            this.distanciasBindingNavigator.Text = "bindingNavigator1";
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
            // distanciasBindingSource
            // 
            this.distanciasBindingSource.DataMember = "Distancias";
            this.distanciasBindingSource.DataSource = this.AMDDataSet;
            // 
            // AMDDataSet
            // 
            this.AMDDataSet.DataSetName = "AMDDataSet";
            this.AMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // distanciasBindingNavigatorSaveItem
            // 
            this.distanciasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.distanciasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("distanciasBindingNavigatorSaveItem.Image")));
            this.distanciasBindingNavigatorSaveItem.Name = "distanciasBindingNavigatorSaveItem";
            this.distanciasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.distanciasBindingNavigatorSaveItem.Text = "Save Data";
            this.distanciasBindingNavigatorSaveItem.Click += new System.EventHandler(this.distanciasBindingNavigatorSaveItem_Click);
            // 
            // distanciasDataGridView
            // 
            this.distanciasDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.distanciasDataGridView.AutoGenerateColumns = false;
            this.distanciasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distanciasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.distanciasDataGridView.DataSource = this.distanciasBindingSource;
            this.distanciasDataGridView.Location = new System.Drawing.Point(262, 95);
            this.distanciasDataGridView.Name = "distanciasDataGridView";
            this.distanciasDataGridView.RowHeadersVisible = false;
            this.distanciasDataGridView.Size = new System.Drawing.Size(894, 383);
            this.distanciasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Zona";
            this.dataGridViewTextBoxColumn1.HeaderText = "Zona";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Distancia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Distancia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // distanciasTableAdapter
            // 
            this.distanciasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComerciaisTableAdapter = null;
            this.tableAdapterManager.DistanciasTableAdapter = this.distanciasTableAdapter;
            this.tableAdapterManager.EncomendasTableAdapter = null;
            this.tableAdapterManager.PlanoSemanalTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AMDManager.AMDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeiculosTableAdapter = null;
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
            // GerirZonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.distanciasDataGridView);
            this.Controls.Add(this.distanciasBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirZonas";
            this.Text = "GerirZonas";
            this.Load += new System.EventHandler(this.GerirZonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingNavigator)).EndInit();
            this.distanciasBindingNavigator.ResumeLayout(false);
            this.distanciasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AMDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AMDDataSet AMDDataSet;
        private System.Windows.Forms.BindingSource distanciasBindingSource;
        private AMDDataSetTableAdapters.DistanciasTableAdapter distanciasTableAdapter;
        private AMDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator distanciasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton distanciasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView distanciasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
    }
}