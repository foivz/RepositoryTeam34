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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudaJelovnika)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPonudaJelovnika
            // 
            this.dgvPonudaJelovnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonudaJelovnika.Location = new System.Drawing.Point(41, 67);
            this.dgvPonudaJelovnika.Name = "dgvPonudaJelovnika";
            this.dgvPonudaJelovnika.Size = new System.Drawing.Size(220, 160);
            this.dgvPonudaJelovnika.TabIndex = 0;
            // 
            // PonudaJelovnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dgvPonudaJelovnika);
            this.Name = "PonudaJelovnika";
            this.Text = "PonudaJelovnika";
            this.Load += new System.EventHandler(this.PonudaJelovnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudaJelovnika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPonudaJelovnika;
    }
}