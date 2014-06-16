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
            this.dgvPonudapica = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNaruci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudaJelovnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudapica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPonudaJelovnika
            // 
            this.dgvPonudaJelovnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonudaJelovnika.Location = new System.Drawing.Point(15, 50);
            this.dgvPonudaJelovnika.Name = "dgvPonudaJelovnika";
            this.dgvPonudaJelovnika.Size = new System.Drawing.Size(483, 160);
            this.dgvPonudaJelovnika.TabIndex = 0;
            this.dgvPonudaJelovnika.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPonudaJelovnika_CellContentClick);
            // 
            // dgvPonudapica
            // 
            this.dgvPonudapica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonudapica.Location = new System.Drawing.Point(15, 253);
            this.dgvPonudapica.Name = "dgvPonudapica";
            this.dgvPonudapica.Size = new System.Drawing.Size(483, 164);
            this.dgvPonudapica.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PONUDA HRANE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PONUDA PIĆA:";
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(324, 423);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(174, 40);
            this.btnNaruci.TabIndex = 4;
            this.btnNaruci.Text = "Naručiti";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // PonudaJelovnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 475);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPonudapica);
            this.Controls.Add(this.dgvPonudaJelovnika);
            this.Name = "PonudaJelovnika";
            this.Text = "PonudaJelovnika";
            this.Load += new System.EventHandler(this.PonudaJelovnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudaJelovnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudapica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPonudaJelovnika;
        private System.Windows.Forms.DataGridView dgvPonudapica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNaruci;
    }
}