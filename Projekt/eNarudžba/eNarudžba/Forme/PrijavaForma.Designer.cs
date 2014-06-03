namespace eNarudžba.Forme
{
    partial class PrijavaForma
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
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijavaPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(26, 36);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 0;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(26, 71);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtBoxKorisnickoIme
            // 
            this.txtBoxKorisnickoIme.Location = new System.Drawing.Point(107, 33);
            this.txtBoxKorisnickoIme.Name = "txtBoxKorisnickoIme";
            this.txtBoxKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKorisnickoIme.TabIndex = 2;
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Location = new System.Drawing.Point(107, 68);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLozinka.TabIndex = 3;
            this.txtBoxLozinka.UseSystemPasswordChar = true;
            // 
            // btnPrijavaPrijava
            // 
            this.btnPrijavaPrijava.Location = new System.Drawing.Point(107, 110);
            this.btnPrijavaPrijava.Name = "btnPrijavaPrijava";
            this.btnPrijavaPrijava.Size = new System.Drawing.Size(100, 23);
            this.btnPrijavaPrijava.TabIndex = 4;
            this.btnPrijavaPrijava.Text = "Prijava";
            this.btnPrijavaPrijava.UseVisualStyleBackColor = true;
            this.btnPrijavaPrijava.Click += new System.EventHandler(this.btnPrijavaPrijava_Click);
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.btnPrijavaPrijava);
            this.Controls.Add(this.txtBoxLozinka);
            this.Controls.Add(this.txtBoxKorisnickoIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Name = "PrijavaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrijavaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtBoxKorisnickoIme;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.Button btnPrijavaPrijava;
    }
}