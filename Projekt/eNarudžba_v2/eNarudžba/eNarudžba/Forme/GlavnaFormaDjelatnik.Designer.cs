namespace eNarudžba.Forme
{
    partial class GlavnaFormaDjelatnik
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
            this.btnPregledZaprimljenihNarudzbi = new System.Windows.Forms.Button();
            this.btnUpravljanjeKorisnikom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPregledZaprimljenihNarudzbi
            // 
            this.btnPregledZaprimljenihNarudzbi.Location = new System.Drawing.Point(40, 40);
            this.btnPregledZaprimljenihNarudzbi.Name = "btnPregledZaprimljenihNarudzbi";
            this.btnPregledZaprimljenihNarudzbi.Size = new System.Drawing.Size(191, 59);
            this.btnPregledZaprimljenihNarudzbi.TabIndex = 0;
            this.btnPregledZaprimljenihNarudzbi.Text = "Pregled zaprimljenih narudžbi";
            this.btnPregledZaprimljenihNarudzbi.UseVisualStyleBackColor = true;
            this.btnPregledZaprimljenihNarudzbi.Click += new System.EventHandler(this.btnPregledZaprimljenihNarudzbi_Click);
            // 
            // btnUpravljanjeKorisnikom
            // 
            this.btnUpravljanjeKorisnikom.Location = new System.Drawing.Point(40, 128);
            this.btnUpravljanjeKorisnikom.Name = "btnUpravljanjeKorisnikom";
            this.btnUpravljanjeKorisnikom.Size = new System.Drawing.Size(191, 53);
            this.btnUpravljanjeKorisnikom.TabIndex = 1;
            this.btnUpravljanjeKorisnikom.Text = "Upravljanje korisnikom";
            this.btnUpravljanjeKorisnikom.UseVisualStyleBackColor = true;
            this.btnUpravljanjeKorisnikom.Click += new System.EventHandler(this.btnUpravljanjeKorisnikom_Click);
            // 
            // GlavnaFormaDjelatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnUpravljanjeKorisnikom);
            this.Controls.Add(this.btnPregledZaprimljenihNarudzbi);
            this.Name = "GlavnaFormaDjelatnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavnaFormaDjelatnik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPregledZaprimljenihNarudzbi;
        private System.Windows.Forms.Button btnUpravljanjeKorisnikom;
    }
}