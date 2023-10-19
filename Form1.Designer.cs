namespace Kafeterija
{
    partial class frmPocetna
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
            this.btnUAP = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnPP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUAP
            // 
            this.btnUAP.Location = new System.Drawing.Point(114, 112);
            this.btnUAP.Name = "btnUAP";
            this.btnUAP.Size = new System.Drawing.Size(324, 47);
            this.btnUAP.TabIndex = 0;
            this.btnUAP.Text = "UNOS I AZURIRANJE PODATAKA";
            this.btnUAP.UseVisualStyleBackColor = true;
            this.btnUAP.Click += new System.EventHandler(this.btnUAP_Click);
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(114, 160);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(324, 44);
            this.btnUP.TabIndex = 1;
            this.btnUP.Text = "POKRETANJE UPITA";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnPP
            // 
            this.btnPP.Location = new System.Drawing.Point(114, 205);
            this.btnPP.Name = "btnPP";
            this.btnPP.Size = new System.Drawing.Size(324, 46);
            this.btnPP.TabIndex = 4;
            this.btnPP.Text = "POKRETANJE FUNKCIJE";
            this.btnPP.UseVisualStyleBackColor = true;
            this.btnPP.Click += new System.EventHandler(this.btnPP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(120, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Izaberite opciju";
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPP);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnUAP);
            this.Name = "frmPocetna";
            this.Text = "Pocetna Forma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUAP;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnPP;
        private System.Windows.Forms.Label label1;
    }
}

