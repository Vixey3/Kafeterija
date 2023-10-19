namespace Kafeterija
{
    partial class frmKvalif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKvalif));
            this.kafeterijaDataSet = new Kafeterija.KafeterijaDataSet();
            this.funPretragaKvalifikacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funPretragaKvalifikacTableAdapter = new Kafeterija.KafeterijaDataSetTableAdapters.funPretragaKvalifikacTableAdapter();
            this.tableAdapterManager = new Kafeterija.KafeterijaDataSetTableAdapters.TableAdapterManager();
            this.funPretragaKvalifikacBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.funPretragaKvalifikacBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.kvalifToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.kvalifToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.funPretragaKvalifikacDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kafeterijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funPretragaKvalifikacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funPretragaKvalifikacBindingNavigator)).BeginInit();
            this.funPretragaKvalifikacBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funPretragaKvalifikacDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kafeterijaDataSet
            // 
            this.kafeterijaDataSet.DataSetName = "KafeterijaDataSet";
            this.kafeterijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funPretragaKvalifikacBindingSource
            // 
            this.funPretragaKvalifikacBindingSource.DataMember = "funPretragaKvalifikac";
            this.funPretragaKvalifikacBindingSource.DataSource = this.kafeterijaDataSet;
            // 
            // funPretragaKvalifikacTableAdapter
            // 
            this.funPretragaKvalifikacTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GOSTTableAdapter = null;
            this.tableAdapterManager.MENITableAdapter = null;
            this.tableAdapterManager.Porudzbina_StavkaTableAdapter = null;
            this.tableAdapterManager.PORUDZBINATableAdapter = null;
            this.tableAdapterManager.REZERVACIJATableAdapter = null;
            this.tableAdapterManager.STAVKA_MENIJATableAdapter = null;
            this.tableAdapterManager.STOTableAdapter = null;
            this.tableAdapterManager.ULOGATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kafeterija.KafeterijaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZAPOSLENITableAdapter = null;
            // 
            // funPretragaKvalifikacBindingNavigator
            // 
            this.funPretragaKvalifikacBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funPretragaKvalifikacBindingNavigator.BindingSource = this.funPretragaKvalifikacBindingSource;
            this.funPretragaKvalifikacBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funPretragaKvalifikacBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.funPretragaKvalifikacBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.funPretragaKvalifikacBindingNavigatorSaveItem});
            this.funPretragaKvalifikacBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funPretragaKvalifikacBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funPretragaKvalifikacBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funPretragaKvalifikacBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funPretragaKvalifikacBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funPretragaKvalifikacBindingNavigator.Name = "funPretragaKvalifikacBindingNavigator";
            this.funPretragaKvalifikacBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funPretragaKvalifikacBindingNavigator.Size = new System.Drawing.Size(726, 25);
            this.funPretragaKvalifikacBindingNavigator.TabIndex = 0;
            this.funPretragaKvalifikacBindingNavigator.Text = "bindingNavigator1";
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
            // funPretragaKvalifikacBindingNavigatorSaveItem
            // 
            this.funPretragaKvalifikacBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funPretragaKvalifikacBindingNavigatorSaveItem.Enabled = false;
            this.funPretragaKvalifikacBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funPretragaKvalifikacBindingNavigatorSaveItem.Image")));
            this.funPretragaKvalifikacBindingNavigatorSaveItem.Name = "funPretragaKvalifikacBindingNavigatorSaveItem";
            this.funPretragaKvalifikacBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.funPretragaKvalifikacBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kvalifToolStripLabel,
            this.kvalifToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(726, 25);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // kvalifToolStripLabel
            // 
            this.kvalifToolStripLabel.Name = "kvalifToolStripLabel";
            this.kvalifToolStripLabel.Size = new System.Drawing.Size(38, 22);
            this.kvalifToolStripLabel.Text = "kvalif:";
            // 
            // kvalifToolStripTextBox
            // 
            this.kvalifToolStripTextBox.Name = "kvalifToolStripTextBox";
            this.kvalifToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_4);
            // 
            // funPretragaKvalifikacDataGridView
            // 
            this.funPretragaKvalifikacDataGridView.AutoGenerateColumns = false;
            this.funPretragaKvalifikacDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.funPretragaKvalifikacDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.funPretragaKvalifikacDataGridView.DataSource = this.funPretragaKvalifikacBindingSource;
            this.funPretragaKvalifikacDataGridView.Location = new System.Drawing.Point(110, 94);
            this.funPretragaKvalifikacDataGridView.Name = "funPretragaKvalifikacDataGridView";
            this.funPretragaKvalifikacDataGridView.Size = new System.Drawing.Size(447, 220);
            this.funPretragaKvalifikacDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "imeZaposlenog";
            this.dataGridViewTextBoxColumn1.HeaderText = "imeZaposlenog";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "prezimeZaposlenog";
            this.dataGridViewTextBoxColumn2.HeaderText = "prezimeZaposlenog";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "telefonZaposlenog";
            this.dataGridViewTextBoxColumn3.HeaderText = "telefonZaposlenog";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "opisUloge";
            this.dataGridViewTextBoxColumn4.HeaderText = "opisUloge";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // frmKvalif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 400);
            this.Controls.Add(this.funPretragaKvalifikacDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.funPretragaKvalifikacBindingNavigator);
            this.Name = "frmKvalif";
            this.Text = "frmKvalif";
            ((System.ComponentModel.ISupportInitialize)(this.kafeterijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funPretragaKvalifikacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funPretragaKvalifikacBindingNavigator)).EndInit();
            this.funPretragaKvalifikacBindingNavigator.ResumeLayout(false);
            this.funPretragaKvalifikacBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funPretragaKvalifikacDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KafeterijaDataSet kafeterijaDataSet;
        private System.Windows.Forms.BindingSource funPretragaKvalifikacBindingSource;
        private KafeterijaDataSetTableAdapters.funPretragaKvalifikacTableAdapter funPretragaKvalifikacTableAdapter;
        private KafeterijaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funPretragaKvalifikacBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton funPretragaKvalifikacBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel kvalifToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox kvalifToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView funPretragaKvalifikacDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}