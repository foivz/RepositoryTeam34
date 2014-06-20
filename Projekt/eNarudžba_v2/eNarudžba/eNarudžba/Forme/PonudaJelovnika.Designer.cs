namespace eNarudžba.Forme
{
    partial class PonudaJelovnika
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
            this.dgvPonudaJelovnika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKomentari = new System.Windows.Forms.DataGridView();
            this.btnNaruci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudaJelovnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPonudaJelovnika
            // 
            this.dgvPonudaJelovnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonudaJelovnika.Location = new System.Drawing.Point(41, 51);
            this.dgvPonudaJelovnika.Name = "dgvPonudaJelovnika";
            this.dgvPonudaJelovnika.Size = new System.Drawing.Size(655, 160);
            this.dgvPonudaJelovnika.TabIndex = 0;
            this.dgvPonudaJelovnika.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPonudaJelovnika_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ponuda jelovnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Komentari";
            // 
            // dgvKomentari
            // 
            this.dgvKomentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomentari.Location = new System.Drawing.Point(41, 270);
            this.dgvKomentari.Name = "dgvKomentari";
            this.dgvKomentari.Size = new System.Drawing.Size(655, 150);
            this.dgvKomentari.TabIndex = 3;
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(598, 461);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(98, 32);
            this.btnNaruci.TabIndex = 4;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = true;
            // 
            // PonudaJelovnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 516);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.dgvKomentari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPonudaJelovnika);
            this.Name = "PonudaJelovnika";
            this.Text = "PonudaJelovnika";
            this.Load += new System.EventHandler(this.PonudaJelovnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudaJelovnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPonudaJelovnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKomentari;
        private System.Windows.Forms.Button btnNaruci;
    }
}