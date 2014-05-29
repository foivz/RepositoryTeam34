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
            this.btnUpravljanjeNaruciteljem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPregledZaprimljenihNarudzbi
            // 
            this.btnPregledZaprimljenihNarudzbi.Location = new System.Drawing.Point(72, 48);
            this.btnPregledZaprimljenihNarudzbi.Name = "btnPregledZaprimljenihNarudzbi";
            this.btnPregledZaprimljenihNarudzbi.Size = new System.Drawing.Size(117, 39);
            this.btnPregledZaprimljenihNarudzbi.TabIndex = 0;
            this.btnPregledZaprimljenihNarudzbi.Text = "Pregled zaprimljenih narudžbi";
            this.btnPregledZaprimljenihNarudzbi.UseVisualStyleBackColor = true;
            // 
            // btnUpravljanjeNaruciteljem
            // 
            this.btnUpravljanjeNaruciteljem.Location = new System.Drawing.Point(72, 113);
            this.btnUpravljanjeNaruciteljem.Name = "btnUpravljanjeNaruciteljem";
            this.btnUpravljanjeNaruciteljem.Size = new System.Drawing.Size(117, 40);
            this.btnUpravljanjeNaruciteljem.TabIndex = 1;
            this.btnUpravljanjeNaruciteljem.Text = "Upravljanje naručiteljem";
            this.btnUpravljanjeNaruciteljem.UseVisualStyleBackColor = true;
            // 
            // GlavnaFormaDjelatnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnUpravljanjeNaruciteljem);
            this.Controls.Add(this.btnPregledZaprimljenihNarudzbi);
            this.Name = "GlavnaFormaDjelatnik";
            this.Text = "GlavnaFormaDjelatnik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPregledZaprimljenihNarudzbi;
        private System.Windows.Forms.Button btnUpravljanjeNaruciteljem;
    }
}