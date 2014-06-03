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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPracenjeStanjaNarudzbe
            // 
            this.btnPracenjeStanjaNarudzbe.Location = new System.Drawing.Point(12, 225);
            this.btnPracenjeStanjaNarudzbe.Name = "btnPracenjeStanjaNarudzbe";
            this.btnPracenjeStanjaNarudzbe.Size = new System.Drawing.Size(129, 23);
            this.btnPracenjeStanjaNarudzbe.TabIndex = 1;
            this.btnPracenjeStanjaNarudzbe.Text = "Praćenje stanja narudžbe";
            this.btnPracenjeStanjaNarudzbe.UseVisualStyleBackColor = true;
            // 
            // btnOcjenjivanjeHrane
            // 
            this.btnOcjenjivanjeHrane.Location = new System.Drawing.Point(152, 225);
            this.btnOcjenjivanjeHrane.Name = "btnOcjenjivanjeHrane";
            this.btnOcjenjivanjeHrane.Size = new System.Drawing.Size(129, 23);
            this.btnOcjenjivanjeHrane.TabIndex = 2;
            this.btnOcjenjivanjeHrane.Text = "Ocjenjivanje hrane";
            this.btnOcjenjivanjeHrane.UseVisualStyleBackColor = true;
            // 
            // btnPonovnoNarucivanje
            // 
            this.btnPonovnoNarucivanje.Location = new System.Drawing.Point(291, 225);
            this.btnPonovnoNarucivanje.Name = "btnPonovnoNarucivanje";
            this.btnPonovnoNarucivanje.Size = new System.Drawing.Size(129, 23);
            this.btnPonovnoNarucivanje.TabIndex = 3;
            this.btnPonovnoNarucivanje.Text = "Ponovno naručivanje";
            this.btnPonovnoNarucivanje.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(408, 209);
            this.dataGridView1.TabIndex = 4;
            // 
            // PovijestNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 264);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPonovnoNarucivanje);
            this.Controls.Add(this.btnOcjenjivanjeHrane);
            this.Controls.Add(this.btnPracenjeStanjaNarudzbe);
            this.Name = "PovijestNarudzbi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PovijestNarudzbi";
            this.Load += new System.EventHandler(this.PovijestNarudzbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPracenjeStanjaNarudzbe;
        private System.Windows.Forms.Button btnOcjenjivanjeHrane;
        private System.Windows.Forms.Button btnPonovnoNarucivanje;
        private System.Windows.Forms.DataGridView dataGridView1;



    }
}