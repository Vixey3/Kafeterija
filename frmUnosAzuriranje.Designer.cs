namespace Kafeterija
{
    partial class frmUnosAzuriranje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnosAzuriranje));
            this.cmbMeni = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dodajStavku = new System.Windows.Forms.Button();
            this.kafeterijaDataSet = new Kafeterija.KafeterijaDataSet();
            this.sTAVKA_MENIJABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAVKA_MENIJATableAdapter = new Kafeterija.KafeterijaDataSetTableAdapters.STAVKA_MENIJATableAdapter();
            this.tableAdapterManager = new Kafeterija.KafeterijaDataSetTableAdapters.TableAdapterManager();
            this.sTAVKA_MENIJABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sTAVKA_MENIJABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sTAVKA_MENIJADataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mENIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mENITableAdapter = new Kafeterija.KafeterijaDataSetTableAdapters.MENITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kafeterijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAVKA_MENIJABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAVKA_MENIJABindingNavigator)).BeginInit();
            this.sTAVKA_MENIJABindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTAVKA_MENIJADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMeni
            // 
            this.cmbMeni.DataSource = this.mENIBindingSource;
            this.cmbMeni.DisplayMember = "opisMenija";
            this.cmbMeni.FormattingEnabled = true;
            this.cmbMeni.Location = new System.Drawing.Point(138, 36);
            this.cmbMeni.Name = "cmbMeni";
            this.cmbMeni.Size = new System.Drawing.Size(121, 21);
            this.cmbMeni.TabIndex = 1;
            this.cmbMeni.ValueMember = "IDMenija";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(461, 125);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(116, 37);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj Meni";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(138, 75);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 3;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(138, 154);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(121, 20);
            this.txtOpis.TabIndex = 4;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(138, 112);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(121, 20);
            this.txtCena.TabIndex = 5;
            this.txtCena.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Odaberi Meni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naziv Stavke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cena Stavke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opis Stavke";
            // 
            // dodajStavku
            // 
            this.dodajStavku.Location = new System.Drawing.Point(326, 125);
            this.dodajStavku.Name = "dodajStavku";
            this.dodajStavku.Size = new System.Drawing.Size(116, 37);
            this.dodajStavku.TabIndex = 10;
            this.dodajStavku.Text = "Dodaj Stavku";
            this.dodajStavku.UseVisualStyleBackColor = true;
            this.dodajStavku.Click += new System.EventHandler(this.dodajStavku_Click);
            // 
            // kafeterijaDataSet
            // 
            this.kafeterijaDataSet.DataSetName = "KafeterijaDataSet";
            this.kafeterijaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTAVKA_MENIJABindingSource
            // 
            this.sTAVKA_MENIJABindingSource.DataMember = "STAVKA_MENIJA";
            this.sTAVKA_MENIJABindingSource.DataSource = this.kafeterijaDataSet;
            // 
            // sTAVKA_MENIJATableAdapter
            // 
            this.sTAVKA_MENIJATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GOSTTableAdapter = null;
            this.tableAdapterManager.MENITableAdapter = this.mENITableAdapter;
            this.tableAdapterManager.Porudzbina_StavkaTableAdapter = null;
            this.tableAdapterManager.PORUDZBINATableAdapter = null;
            this.tableAdapterManager.REZERVACIJATableAdapter = null;
            this.tableAdapterManager.STAVKA_MENIJATableAdapter = this.sTAVKA_MENIJATableAdapter;
            this.tableAdapterManager.STOTableAdapter = null;
            this.tableAdapterManager.ULOGATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kafeterija.KafeterijaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZAPOSLENITableAdapter = null;
            // 
            // sTAVKA_MENIJABindingNavigator
            // 
            this.sTAVKA_MENIJABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sTAVKA_MENIJABindingNavigator.BindingSource = this.sTAVKA_MENIJABindingSource;
            this.sTAVKA_MENIJABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sTAVKA_MENIJABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sTAVKA_MENIJABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sTAVKA_MENIJABindingNavigatorSaveItem});
            this.sTAVKA_MENIJABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sTAVKA_MENIJABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sTAVKA_MENIJABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sTAVKA_MENIJABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sTAVKA_MENIJABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sTAVKA_MENIJABindingNavigator.Name = "sTAVKA_MENIJABindingNavigator";
            this.sTAVKA_MENIJABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sTAVKA_MENIJABindingNavigator.Size = new System.Drawing.Size(709, 25);
            this.sTAVKA_MENIJABindingNavigator.TabIndex = 11;
            this.sTAVKA_MENIJABindingNavigator.Text = "bindingNavigator1";
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
            // sTAVKA_MENIJABindingNavigatorSaveItem
            // 
            this.sTAVKA_MENIJABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sTAVKA_MENIJABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sTAVKA_MENIJABindingNavigatorSaveItem.Image")));
            this.sTAVKA_MENIJABindingNavigatorSaveItem.Name = "sTAVKA_MENIJABindingNavigatorSaveItem";
            this.sTAVKA_MENIJABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.sTAVKA_MENIJABindingNavigatorSaveItem.Text = "Save Data";
            this.sTAVKA_MENIJABindingNavigatorSaveItem.Click += new System.EventHandler(this.sTAVKA_MENIJABindingNavigatorSaveItem_Click);
            // 
            // sTAVKA_MENIJADataGridView
            // 
            this.sTAVKA_MENIJADataGridView.AutoGenerateColumns = false;
            this.sTAVKA_MENIJADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sTAVKA_MENIJADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.sTAVKA_MENIJADataGridView.DataSource = this.sTAVKA_MENIJABindingSource;
            this.sTAVKA_MENIJADataGridView.Location = new System.Drawing.Point(26, 222);
            this.sTAVKA_MENIJADataGridView.Name = "sTAVKA_MENIJADataGridView";
            this.sTAVKA_MENIJADataGridView.Size = new System.Drawing.Size(551, 296);
            this.sTAVKA_MENIJADataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDStavke";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDStavke";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDMenija";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDMenija";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nazivStavke";
            this.dataGridViewTextBoxColumn3.HeaderText = "nazivStavke";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cenaStavke";
            this.dataGridViewTextBoxColumn4.HeaderText = "cenaStavke";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "opisStavke";
            this.dataGridViewTextBoxColumn5.HeaderText = "opisStavke";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
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
            // frmUnosAzuriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 530);
            this.Controls.Add(this.sTAVKA_MENIJADataGridView);
            this.Controls.Add(this.sTAVKA_MENIJABindingNavigator);
            this.Controls.Add(this.dodajStavku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbMeni);
            this.Name = "frmUnosAzuriranje";
            this.Text = "UnosAzuriranje";
            this.Load += new System.EventHandler(this.frmUnosAzuriranje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kafeterijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAVKA_MENIJABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAVKA_MENIJABindingNavigator)).EndInit();
            this.sTAVKA_MENIJABindingNavigator.ResumeLayout(false);
            this.sTAVKA_MENIJABindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTAVKA_MENIJADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMeni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dodajStavku;
        private KafeterijaDataSet kafeterijaDataSet;
        private System.Windows.Forms.BindingSource sTAVKA_MENIJABindingSource;
        private KafeterijaDataSetTableAdapters.STAVKA_MENIJATableAdapter sTAVKA_MENIJATableAdapter;
        private KafeterijaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sTAVKA_MENIJABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sTAVKA_MENIJABindingNavigatorSaveItem;
        private KafeterijaDataSetTableAdapters.MENITableAdapter mENITableAdapter;
        private System.Windows.Forms.DataGridView sTAVKA_MENIJADataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource mENIBindingSource;
    }
}