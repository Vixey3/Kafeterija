namespace Kafeterija
{
    partial class frmMeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeni));
            this.kafeterijaDataSet = new Kafeterija.KafeterijaDataSet();
            this.mENIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mENITableAdapter = new Kafeterija.KafeterijaDataSetTableAdapters.MENITableAdapter();
            this.tableAdapterManager = new Kafeterija.KafeterijaDataSetTableAdapters.TableAdapterManager();
            this.mENIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mENIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mENIDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kafeterijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENIBindingNavigator)).BeginInit();
            this.mENIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mENIDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kafeterijaDataSet
            // 
            this.kafeterijaDataSet.DataSetName = "KafeterijaDataSet";
            this.kafeterijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mENIBindingSource
            // 
            this.mENIBindingSource.DataMember = "MENI";
            this.mENIBindingSource.DataSource = this.kafeterijaDataSet;
            // 
            // mENITableAdapter
            // 
            this.mENITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GOSTTableAdapter = null;
            this.tableAdapterManager.MENITableAdapter = this.mENITableAdapter;
            this.tableAdapterManager.Porudzbina_StavkaTableAdapter = null;
            this.tableAdapterManager.PORUDZBINATableAdapter = null;
            this.tableAdapterManager.REZERVACIJATableAdapter = null;
            this.tableAdapterManager.STAVKA_MENIJATableAdapter = null;
            this.tableAdapterManager.STOTableAdapter = null;
            this.tableAdapterManager.ULOGATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kafeterija.KafeterijaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZAPOSLENITableAdapter = null;
            // 
            // mENIBindingNavigator
            // 
            this.mENIBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mENIBindingNavigator.BindingSource = this.mENIBindingSource;
            this.mENIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mENIBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mENIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mENIBindingNavigatorSaveItem});
            this.mENIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mENIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mENIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mENIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mENIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mENIBindingNavigator.Name = "mENIBindingNavigator";
            this.mENIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mENIBindingNavigator.Size = new System.Drawing.Size(378, 25);
            this.mENIBindingNavigator.TabIndex = 0;
            this.mENIBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // mENIBindingNavigatorSaveItem
            // 
            this.mENIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mENIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mENIBindingNavigatorSaveItem.Image")));
            this.mENIBindingNavigatorSaveItem.Name = "mENIBindingNavigatorSaveItem";
            this.mENIBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.mENIBindingNavigatorSaveItem.Text = "Save Data";
            this.mENIBindingNavigatorSaveItem.Click += new System.EventHandler(this.mENIBindingNavigatorSaveItem_Click);
            // 
            // mENIDataGridView
            // 
            this.mENIDataGridView.AutoGenerateColumns = false;
            this.mENIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mENIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.mENIDataGridView.DataSource = this.mENIBindingSource;
            this.mENIDataGridView.Location = new System.Drawing.Point(58, 51);
            this.mENIDataGridView.Name = "mENIDataGridView";
            this.mENIDataGridView.Size = new System.Drawing.Size(246, 220);
            this.mENIDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDMenija";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDMenija";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "opisMenija";
            this.dataGridViewTextBoxColumn2.HeaderText = "opisMenija";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // frmMeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 291);
            this.Controls.Add(this.mENIDataGridView);
            this.Controls.Add(this.mENIBindingNavigator);
            this.Name = "frmMeni";
            this.Text = "frmMeni";
            this.Load += new System.EventHandler(this.frmMeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kafeterijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENIBindingNavigator)).EndInit();
            this.mENIBindingNavigator.ResumeLayout(false);
            this.mENIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mENIDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KafeterijaDataSet kafeterijaDataSet;
        private System.Windows.Forms.BindingSource mENIBindingSource;
        private KafeterijaDataSetTableAdapters.MENITableAdapter mENITableAdapter;
        private KafeterijaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mENIBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mENIBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mENIDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}