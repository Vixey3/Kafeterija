namespace Kafeterija
{
    partial class frmUpiti
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
            this.btnKvalif = new System.Windows.Forms.Button();
            this.txtKvalif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvMeni = new System.Windows.Forms.DataGridView();
            this.cmbMeni = new System.Windows.Forms.ComboBox();
            this.kafeterijaDataSet = new Kafeterija.KafeterijaDataSet();
            this.mENIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mENITableAdapter = new Kafeterija.KafeterijaDataSetTableAdapters.MENITableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafeterijaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKvalif
            // 
            this.btnKvalif.Location = new System.Drawing.Point(32, 89);
            this.btnKvalif.Name = "btnKvalif";
            this.btnKvalif.Size = new System.Drawing.Size(202, 31);
            this.btnKvalif.TabIndex = 0;
            this.btnKvalif.Text = "Pretrazi";
            this.btnKvalif.UseVisualStyleBackColor = true;
            this.btnKvalif.Click += new System.EventHandler(this.btnKvalif_Click);
            // 
            // txtKvalif
            // 
            this.txtKvalif.Location = new System.Drawing.Point(32, 51);
            this.txtKvalif.Name = "txtKvalif";
            this.txtKvalif.Size = new System.Drawing.Size(202, 20);
            this.txtKvalif.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime zaposlenog:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(380, 161);
            this.dataGridView1.TabIndex = 3;
            // 
            // dgvMeni
            // 
            this.dgvMeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeni.Location = new System.Drawing.Point(424, 144);
            this.dgvMeni.Name = "dgvMeni";
            this.dgvMeni.Size = new System.Drawing.Size(365, 161);
            this.dgvMeni.TabIndex = 5;
            // 
            // cmbMeni
            // 
            this.cmbMeni.DataSource = this.mENIBindingSource;
            this.cmbMeni.DisplayMember = "opisMenija";
            this.cmbMeni.FormattingEnabled = true;
            this.cmbMeni.Location = new System.Drawing.Point(492, 67);
            this.cmbMeni.Name = "cmbMeni";
            this.cmbMeni.Size = new System.Drawing.Size(240, 21);
            this.cmbMeni.TabIndex = 6;
            this.cmbMeni.ValueMember = "IDMenija";
            this.cmbMeni.SelectedIndexChanged += new System.EventHandler(this.cmbMeni_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Izaberi opciju menija:";
            // 
            // frmUpiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMeni);
            this.Controls.Add(this.dgvMeni);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKvalif);
            this.Controls.Add(this.btnKvalif);
            this.Name = "frmUpiti";
            this.Text = "frmUpiti";
            this.Load += new System.EventHandler(this.frmUpiti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kafeterijaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mENIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKvalif;
        private System.Windows.Forms.TextBox txtKvalif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvMeni;
        private System.Windows.Forms.ComboBox cmbMeni;
        private KafeterijaDataSet kafeterijaDataSet;
        private System.Windows.Forms.BindingSource mENIBindingSource;
        private KafeterijaDataSetTableAdapters.MENITableAdapter mENITableAdapter;
        private System.Windows.Forms.Label label2;
    }
}