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
            this.dgwPovijestNarudzbi = new System.Windows.Forms.DataGridView();
            this.dgwPovijestNarudzbiDetalji = new System.Windows.Forms.DataGridView();
            this.btnPonovnoNarucivanje = new System.Windows.Forms.Button();
            this.btnOcjenjivanjeHrane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPovijestNarudzbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPovijestNarudzbiDetalji)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPracenjeStanjaNarudzbe
            // 
            this.btnPracenjeStanjaNarudzbe.Location = new System.Drawing.Point(10, 358);
            this.btnPracenjeStanjaNarudzbe.Name = "btnPracenjeStanjaNarudzbe";
            this.btnPracenjeStanjaNarudzbe.Size = new System.Drawing.Size(132, 23);
            this.btnPracenjeStanjaNarudzbe.TabIndex = 1;
            this.btnPracenjeStanjaNarudzbe.Text = "Praćenje stanja narudžbe";
            this.btnPracenjeStanjaNarudzbe.UseVisualStyleBackColor = true;
            this.btnPracenjeStanjaNarudzbe.Click += new System.EventHandler(this.btnPracenjeStanjaNarudzbe_Click);
            // 
            // dgwPovijestNarudzbi
            // 
            this.dgwPovijestNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPovijestNarudzbi.Location = new System.Drawing.Point(14, 10);
            this.dgwPovijestNarudzbi.Name = "dgwPovijestNarudzbi";
            this.dgwPovijestNarudzbi.Size = new System.Drawing.Size(426, 129);
            this.dgwPovijestNarudzbi.TabIndex = 4;
            this.dgwPovijestNarudzbi.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwPovijestNarudzbi_RowHeaderMouseClick);
            // 
            // dgwPovijestNarudzbiDetalji
            // 
            this.dgwPovijestNarudzbiDetalji.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwPovijestNarudzbiDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPovijestNarudzbiDetalji.Location = new System.Drawing.Point(12, 145);
            this.dgwPovijestNarudzbiDetalji.Name = "dgwPovijestNarudzbiDetalji";
            this.dgwPovijestNarudzbiDetalji.Size = new System.Drawing.Size(426, 207);
            this.dgwPovijestNarudzbiDetalji.TabIndex = 5;
            // 
            // btnPonovnoNarucivanje
            // 
            this.btnPonovnoNarucivanje.Location = new System.Drawing.Point(308, 358);
            this.btnPonovnoNarucivanje.Name = "btnPonovnoNarucivanje";
            this.btnPonovnoNarucivanje.Size = new System.Drawing.Size(130, 23);
            this.btnPonovnoNarucivanje.TabIndex = 3;
            this.btnPonovnoNarucivanje.Text = "Ponovno naručivanje";
            this.btnPonovnoNarucivanje.UseVisualStyleBackColor = true;
            // 
            // btnOcjenjivanjeHrane
            // 
            this.btnOcjenjivanjeHrane.Location = new System.Drawing.Point(161, 358);
            this.btnOcjenjivanjeHrane.Name = "btnOcjenjivanjeHrane";
            this.btnOcjenjivanjeHrane.Size = new System.Drawing.Size(130, 23);
            this.btnOcjenjivanjeHrane.TabIndex = 2;
            this.btnOcjenjivanjeHrane.Text = "Ocjenjivanje hrane";
            this.btnOcjenjivanjeHrane.UseVisualStyleBackColor = true;
            // 
            // PovijestNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 391);
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
        private System.Windows.Forms.DataGridView dgwPovijestNarudzbi;
        private System.Windows.Forms.DataGridView dgwPovijestNarudzbiDetalji;
        private System.Windows.Forms.Button btnPonovnoNarucivanje;
        private System.Windows.Forms.Button btnOcjenjivanjeHrane;



    }
}