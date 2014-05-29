namespace eNarudžba.Forme
{
    partial class GlavnaForma
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
            this.btnPonudaJelovnika = new System.Windows.Forms.Button();
            this.btnPovijestNarudžbi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPonudaJelovnika
            // 
            this.btnPonudaJelovnika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPonudaJelovnika.Location = new System.Drawing.Point(50, 60);
            this.btnPonudaJelovnika.Name = "btnPonudaJelovnika";
            this.btnPonudaJelovnika.Size = new System.Drawing.Size(191, 47);
            this.btnPonudaJelovnika.TabIndex = 0;
            this.btnPonudaJelovnika.Text = "Ponuda jelovnika";
            this.btnPonudaJelovnika.UseVisualStyleBackColor = true;
            // 
            // btnPovijestNarudžbi
            // 
            this.btnPovijestNarudžbi.Location = new System.Drawing.Point(51, 134);
            this.btnPovijestNarudžbi.Name = "btnPovijestNarudžbi";
            this.btnPovijestNarudžbi.Size = new System.Drawing.Size(191, 47);
            this.btnPovijestNarudžbi.TabIndex = 1;
            this.btnPovijestNarudžbi.Text = "Povijest narudžbi";
            this.btnPovijestNarudžbi.UseVisualStyleBackColor = true;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPovijestNarudžbi);
            this.Controls.Add(this.btnPonudaJelovnika);
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPonudaJelovnika;
        private System.Windows.Forms.Button btnPovijestNarudžbi;
    }
}