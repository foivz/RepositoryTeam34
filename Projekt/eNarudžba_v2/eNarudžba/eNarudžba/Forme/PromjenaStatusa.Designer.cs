namespace eNarudžba.Forme
{
    partial class PromjenaStatusa
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
            this.btnPromijeniStatus = new System.Windows.Forms.Button();
            this.rdbNarudzbaZaprimljena = new System.Windows.Forms.RadioButton();
            this.rdbNarudzbaNaRedu = new System.Windows.Forms.RadioButton();
            this.rdbNarudzbaGotova = new System.Windows.Forms.RadioButton();
            this.rdbDostavljaSe = new System.Windows.Forms.RadioButton();
            this.rdbDostavljena = new System.Windows.Forms.RadioButton();
            this.lblNarudzbaDOstavljena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPromijeniStatus
            // 
            this.btnPromijeniStatus.Location = new System.Drawing.Point(155, 247);
            this.btnPromijeniStatus.Name = "btnPromijeniStatus";
            this.btnPromijeniStatus.Size = new System.Drawing.Size(117, 23);
            this.btnPromijeniStatus.TabIndex = 10;
            this.btnPromijeniStatus.Text = "Promijeni status";
            this.btnPromijeniStatus.UseVisualStyleBackColor = true;
            this.btnPromijeniStatus.Click += new System.EventHandler(this.btnPromijeniStatus_Click);
            // 
            // rdbNarudzbaZaprimljena
            // 
            this.rdbNarudzbaZaprimljena.AutoSize = true;
            this.rdbNarudzbaZaprimljena.Location = new System.Drawing.Point(35, 42);
            this.rdbNarudzbaZaprimljena.Name = "rdbNarudzbaZaprimljena";
            this.rdbNarudzbaZaprimljena.Size = new System.Drawing.Size(137, 17);
            this.rdbNarudzbaZaprimljena.TabIndex = 11;
            this.rdbNarudzbaZaprimljena.TabStop = true;
            this.rdbNarudzbaZaprimljena.Text = "Narudžba je zaprimljena";
            this.rdbNarudzbaZaprimljena.UseVisualStyleBackColor = true;
            // 
            // rdbNarudzbaNaRedu
            // 
            this.rdbNarudzbaNaRedu.AutoSize = true;
            this.rdbNarudzbaNaRedu.Location = new System.Drawing.Point(35, 85);
            this.rdbNarudzbaNaRedu.Name = "rdbNarudzbaNaRedu";
            this.rdbNarudzbaNaRedu.Size = new System.Drawing.Size(121, 17);
            this.rdbNarudzbaNaRedu.TabIndex = 12;
            this.rdbNarudzbaNaRedu.TabStop = true;
            this.rdbNarudzbaNaRedu.Text = "Narudžba je na redu";
            this.rdbNarudzbaNaRedu.UseVisualStyleBackColor = true;
            // 
            // rdbNarudzbaGotova
            // 
            this.rdbNarudzbaGotova.AutoSize = true;
            this.rdbNarudzbaGotova.Location = new System.Drawing.Point(35, 129);
            this.rdbNarudzbaGotova.Name = "rdbNarudzbaGotova";
            this.rdbNarudzbaGotova.Size = new System.Drawing.Size(118, 17);
            this.rdbNarudzbaGotova.TabIndex = 13;
            this.rdbNarudzbaGotova.TabStop = true;
            this.rdbNarudzbaGotova.Text = "Narudžba je gotova";
            this.rdbNarudzbaGotova.UseVisualStyleBackColor = true;
            // 
            // rdbDostavljaSe
            // 
            this.rdbDostavljaSe.AutoSize = true;
            this.rdbDostavljaSe.Location = new System.Drawing.Point(35, 171);
            this.rdbDostavljaSe.Name = "rdbDostavljaSe";
            this.rdbDostavljaSe.Size = new System.Drawing.Size(83, 17);
            this.rdbDostavljaSe.TabIndex = 14;
            this.rdbDostavljaSe.TabStop = true;
            this.rdbDostavljaSe.Text = "Dostavlja se";
            this.rdbDostavljaSe.UseVisualStyleBackColor = true;
            // 
            // rdbDostavljena
            // 
            this.rdbDostavljena.AutoSize = true;
            this.rdbDostavljena.Location = new System.Drawing.Point(35, 213);
            this.rdbDostavljena.Name = "rdbDostavljena";
            this.rdbDostavljena.Size = new System.Drawing.Size(81, 17);
            this.rdbDostavljena.TabIndex = 15;
            this.rdbDostavljena.TabStop = true;
            this.rdbDostavljena.Text = "Dostavljena";
            this.rdbDostavljena.UseVisualStyleBackColor = true;
            // 
            // lblNarudzbaDOstavljena
            // 
            this.lblNarudzbaDOstavljena.AutoSize = true;
            this.lblNarudzbaDOstavljena.Location = new System.Drawing.Point(32, 26);
            this.lblNarudzbaDOstavljena.Name = "lblNarudzbaDOstavljena";
            this.lblNarudzbaDOstavljena.Size = new System.Drawing.Size(121, 13);
            this.lblNarudzbaDOstavljena.TabIndex = 16;
            this.lblNarudzbaDOstavljena.Text = "Narudžba je dostavljena";
            this.lblNarudzbaDOstavljena.Visible = false;
            // 
            // PromjenaStatusa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.lblNarudzbaDOstavljena);
            this.Controls.Add(this.rdbDostavljena);
            this.Controls.Add(this.rdbDostavljaSe);
            this.Controls.Add(this.rdbNarudzbaGotova);
            this.Controls.Add(this.rdbNarudzbaNaRedu);
            this.Controls.Add(this.rdbNarudzbaZaprimljena);
            this.Controls.Add(this.btnPromijeniStatus);
            this.Name = "PromjenaStatusa";
            this.Text = "PromjenaStatusa";
            this.Load += new System.EventHandler(this.PromjenaStatusa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPromijeniStatus;
        private System.Windows.Forms.RadioButton rdbNarudzbaZaprimljena;
        private System.Windows.Forms.RadioButton rdbNarudzbaNaRedu;
        private System.Windows.Forms.RadioButton rdbNarudzbaGotova;
        private System.Windows.Forms.RadioButton rdbDostavljaSe;
        private System.Windows.Forms.RadioButton rdbDostavljena;
        private System.Windows.Forms.Label lblNarudzbaDOstavljena;

    }
}