namespace eNarudžba.Forme
{
    partial class PovijestNarudzbi
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
            this.btnPracenjeStanjaNarudzbe = new System.Windows.Forms.Button();
            this.btnOcjenjivanjeHrane = new System.Windows.Forms.Button();
            this.btnPonovnoNarucivanje = new System.Windows.Forms.Button();
            this.dgwPovijestNarudzbi = new System.Windows.Forms.DataGridView();
            this.dgwPovijestNarudzbiDetalji = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPovijestNarudzbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPovijestNarudzbiDetalji)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPracenjeStanjaNarudzbe
            // 
            this.btnPracenjeStanjaNarudzbe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPracenjeStanjaNarudzbe.Location = new System.Drawing.Point(215, 34);
            this.btnPracenjeStanjaNarudzbe.Name = "btnPracenjeStanjaNarudzbe";
            this.btnPracenjeStanjaNarudzbe.Size = new System.Drawing.Size(129, 23);
            this.btnPracenjeStanjaNarudzbe.TabIndex = 1;
            this.btnPracenjeStanjaNarudzbe.Text = "Praćenje stanja narudžbe";
            this.btnPracenjeStanjaNarudzbe.UseVisualStyleBackColor = true;
            // 
            // btnOcjenjivanjeHrane
            // 
            this.btnOcjenjivanjeHrane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOcjenjivanjeHrane.Location = new System.Drawing.Point(215, 63);
            this.btnOcjenjivanjeHrane.Name = "btnOcjenjivanjeHrane";
            this.btnOcjenjivanjeHrane.Size = new System.Drawing.Size(129, 23);
            this.btnOcjenjivanjeHrane.TabIndex = 2;
            this.btnOcjenjivanjeHrane.Text = "Ocjenjivanje hrane";
            this.btnOcjenjivanjeHrane.UseVisualStyleBackColor = true;
            // 
            // btnPonovnoNarucivanje
            // 
            this.btnPonovnoNarucivanje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPonovnoNarucivanje.Location = new System.Drawing.Point(215, 92);
            this.btnPonovnoNarucivanje.Name = "btnPonovnoNarucivanje";
            this.btnPonovnoNarucivanje.Size = new System.Drawing.Size(129, 23);
            this.btnPonovnoNarucivanje.TabIndex = 3;
            this.btnPonovnoNarucivanje.Text = "Ponovno naručivanje";
            this.btnPonovnoNarucivanje.UseVisualStyleBackColor = true;
            // 
            // dgwPovijestNarudzbi
            // 
            this.dgwPovijestNarudzbi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPovijestNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPovijestNarudzbi.Location = new System.Drawing.Point(12, 10);
            this.dgwPovijestNarudzbi.Name = "dgwPovijestNarudzbi";
            this.dgwPovijestNarudzbi.Size = new System.Drawing.Size(152, 134);
            this.dgwPovijestNarudzbi.TabIndex = 4;
            // 
            // dgwPovijestNarudzbiDetalji
            // 
            this.dgwPovijestNarudzbiDetalji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPovijestNarudzbiDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPovijestNarudzbiDetalji.Location = new System.Drawing.Point(14, 150);
            this.dgwPovijestNarudzbiDetalji.Name = "dgwPovijestNarudzbiDetalji";
            this.dgwPovijestNarudzbiDetalji.Size = new System.Drawing.Size(404, 144);
            this.dgwPovijestNarudzbiDetalji.TabIndex = 5;
            // 
            // PovijestNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 346);
            this.Controls.Add(this.dgwPovijestNarudzbiDetalji);
            this.Controls.Add(this.dgwPovijestNarudzbi);
            this.Controls.Add(this.btnPonovnoNarucivanje);
            this.Controls.Add(this.btnOcjenjivanjeHrane);
            this.Controls.Add(this.btnPracenjeStanjaNarudzbe);
            this.Name = "PovijestNarudzbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PovijestNarudzbi";
            this.Load += new System.EventHandler(this.PovijestNarudzbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPovijestNarudzbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPovijestNarudzbiDetalji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPracenjeStanjaNarudzbe;
        private System.Windows.Forms.Button btnOcjenjivanjeHrane;
        private System.Windows.Forms.Button btnPonovnoNarucivanje;
        private System.Windows.Forms.DataGridView dgwPovijestNarudzbi;
        private System.Windows.Forms.DataGridView dgwPovijestNarudzbiDetalji;



    }
}