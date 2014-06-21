namespace eNarudžba.Forme
{
    partial class PracenjeStanja
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
            this.dgvPracenjeStanja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracenjeStanja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPracenjeStanja
            // 
            this.dgvPracenjeStanja.AllowUserToAddRows = false;
            this.dgvPracenjeStanja.AllowUserToDeleteRows = false;
            this.dgvPracenjeStanja.AllowUserToResizeColumns = false;
            this.dgvPracenjeStanja.AllowUserToResizeRows = false;
            this.dgvPracenjeStanja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPracenjeStanja.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPracenjeStanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracenjeStanja.GridColor = System.Drawing.SystemColors.Window;
            this.dgvPracenjeStanja.Location = new System.Drawing.Point(19, 38);
            this.dgvPracenjeStanja.Name = "dgvPracenjeStanja";
            this.dgvPracenjeStanja.ReadOnly = true;
            this.dgvPracenjeStanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPracenjeStanja.Size = new System.Drawing.Size(320, 237);
            this.dgvPracenjeStanja.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stanja narudžbe";
            // 
            // PracenjeStanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPracenjeStanja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PracenjeStanja";
            this.Text = "eNarudžba";
            this.Load += new System.EventHandler(this.PracenjeStanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracenjeStanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPracenjeStanja;
        private System.Windows.Forms.Label label1;
    }
}