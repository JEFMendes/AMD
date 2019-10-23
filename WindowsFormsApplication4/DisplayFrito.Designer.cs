namespace AMDManager
{
    partial class DisplayFrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayFrito));
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.planoFritoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.planoFritoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.encomendasFritasDataGridView = new System.Windows.Forms.DataGridView();
            this.encomendasFritasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aMDDataSet = new AMDManager.AMDDataSet();
            this.tableAdapterManager = new AMDManager.AMDDataSetTableAdapters.TableAdapterManager();
            this.encomendasFritasTableAdapter = new AMDManager.AMDDataSetTableAdapters.EncomendasFritasTableAdapter();
            this.planoFritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.planoFritoBindingNavigator)).BeginInit();
            this.planoFritoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encomendasFritasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendasFritasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoFritoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
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
            // planoFritoBindingNavigatorSaveItem
            // 
            this.planoFritoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.planoFritoBindingNavigatorSaveItem.Enabled = false;
            this.planoFritoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("planoFritoBindingNavigatorSaveItem.Image")));
            this.planoFritoBindingNavigatorSaveItem.Name = "planoFritoBindingNavigatorSaveItem";
            this.planoFritoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.planoFritoBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // planoFritoBindingNavigator
            // 
            this.planoFritoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.planoFritoBindingNavigator.BindingSource = this.planoFritoBindingSource;
            this.planoFritoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.planoFritoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.planoFritoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.planoFritoBindingNavigatorSaveItem,
            this.toolStripDropDownButton1});
            this.planoFritoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.planoFritoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.planoFritoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.planoFritoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.planoFritoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.planoFritoBindingNavigator.Name = "planoFritoBindingNavigator";
            this.planoFritoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.planoFritoBindingNavigator.Size = new System.Drawing.Size(1484, 25);
            this.planoFritoBindingNavigator.TabIndex = 0;
            this.planoFritoBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // encomendasFritasDataGridView
            // 
            this.encomendasFritasDataGridView.AutoGenerateColumns = false;
            this.encomendasFritasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.encomendasFritasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Tipo,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.encomendasFritasDataGridView.DataSource = this.encomendasFritasBindingSource;
            this.encomendasFritasDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.encomendasFritasDataGridView.Location = new System.Drawing.Point(12, 28);
            this.encomendasFritasDataGridView.Name = "encomendasFritasDataGridView";
            this.encomendasFritasDataGridView.RowHeadersVisible = false;
            this.encomendasFritasDataGridView.Size = new System.Drawing.Size(1460, 651);
            this.encomendasFritasDataGridView.TabIndex = 1;
            this.encomendasFritasDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.encomendasFritasDataGridView_CellContentClick);
            // 
            // encomendasFritasBindingSource
            // 
            this.encomendasFritasBindingSource.DataMember = "EncomendasFritas";
            this.encomendasFritasBindingSource.DataSource = this.aMDDataSet;
            // 
            // aMDDataSet
            // 
            this.aMDDataSet.DataSetName = "AMDDataSet";
            this.aMDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArmazensTableAdapter = null;
            this.tableAdapterManager.ArquivoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComerciaisTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DistanciasTableAdapter = null;
            this.tableAdapterManager.EncomendasAttalensTableAdapter = null;
            this.tableAdapterManager.EncomendasFritasTableAdapter = null;
            this.tableAdapterManager.EncomendasTableAdapter = null;
            this.tableAdapterManager.LoginsTableAdapter = null;
            this.tableAdapterManager.PaletesTableAdapter = null;
            this.tableAdapterManager.PlanoSemanalTableAdapter = null;
            this.tableAdapterManager.PrecosTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.TotalPaletesTableAdapter = null;
            this.tableAdapterManager.TransportadorasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AMDManager.AMDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VeiculosTableAdapter = null;
            // 
            // encomendasFritasTableAdapter
            // 
            this.encomendasFritasTableAdapter.ClearBeforeFill = true;
            // 
            // planoFritoBindingSource
            // 
            this.planoFritoBindingSource.DataSource = typeof(AMDManager.Algos.PlanoFrito);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Plano";
            this.dataGridViewTextBoxColumn1.HeaderText = "Camiao";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Paletes";
            this.dataGridViewTextBoxColumn3.HeaderText = "Paletes";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Rolli";
            this.dataGridViewTextBoxColumn4.HeaderText = "Rolli";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "SemAcesso";
            this.dataGridViewCheckBoxColumn1.HeaderText = "SemAcesso";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Ridelle";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Ridelle";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Encomenda";
            this.dataGridViewTextBoxColumn6.HeaderText = "IDEncomenda";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Semana";
            this.dataGridViewTextBoxColumn8.HeaderText = "Semana";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // DisplayFrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 691);
            this.Controls.Add(this.encomendasFritasDataGridView);
            this.Controls.Add(this.planoFritoBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayFrito";
            this.Text = "DisplayFrito";
            this.Load += new System.EventHandler(this.DisplayFrito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planoFritoBindingNavigator)).EndInit();
            this.planoFritoBindingNavigator.ResumeLayout(false);
            this.planoFritoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encomendasFritasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encomendasFritasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aMDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planoFritoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource planoFritoBindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton planoFritoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator planoFritoBindingNavigator;
        private AMDDataSet aMDDataSet;
        private System.Windows.Forms.BindingSource encomendasFritasBindingSource;
        private AMDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private AMDDataSetTableAdapters.EncomendasFritasTableAdapter encomendasFritasTableAdapter;
        private System.Windows.Forms.DataGridView encomendasFritasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}