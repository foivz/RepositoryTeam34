namespace eNarudžba.Forme
{
    partial class KomentiranjeHrane
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
            this.lblKomentar = new System.Windows.Forms.Label();
            this.txtKomentari = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(31, 37);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(86, 13);
            this.lblKomentar.TabIndex = 0;
            this.lblKomentar.Text = "Upišite komentar";
            // 
            // txtKomentari
            // 
            this.txtKomentari.Location = new System.Drawing.Point(34, 66);
            this.txtKomentari.Multiline = true;
            this.txtKomentari.Name = "txtKomentari";
            this.txtKomentari.Size = new System.Drawing.Size(302, 172);
            this.txtKomentari.TabIndex = 1;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(261, 261);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 2;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // KomentiranjeHrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 315);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.txtKomentari);
            this.Controls.Add(this.lblKomentar);
            this.Name = "KomentiranjeHrane";
            this.Text = "KomentiranjeHrane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.TextBox txtKomentari;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}