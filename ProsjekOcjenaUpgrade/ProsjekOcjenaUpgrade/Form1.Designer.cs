namespace ProsjekOcjenaUpgrade
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
            this.cmbPredmeti = new System.Windows.Forms.ComboBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbPredmeti
            // 
            this.cmbPredmeti.FormattingEnabled = true;
            this.cmbPredmeti.Items.AddRange(new object[] {
            "Hrvatski jezik",
            "Matematika"});
            this.cmbPredmeti.Location = new System.Drawing.Point(46, 12);
            this.cmbPredmeti.Name = "cmbPredmeti";
            this.cmbPredmeti.Size = new System.Drawing.Size(320, 28);
            this.cmbPredmeti.TabIndex = 0;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(46, 105);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(320, 234);
            this.txtIspis.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(398, 82);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(92, 53);
            this.btnUnesi.TabIndex = 3;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(398, 164);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(92, 50);
            this.btnIspisi.TabIndex = 4;
            this.btnIspisi.Text = "Ispisi";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(398, 233);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(92, 50);
            this.btnUcitaj.TabIndex = 5;
            this.btnUcitaj.Text = "Ucitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(46, 60);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(124, 26);
            this.txtOcjena.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.btnUcitaj);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.cmbPredmeti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPredmeti;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.TextBox txtOcjena;
    }
}

