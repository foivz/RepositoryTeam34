﻿namespace eNarudžba.Forme
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracenjeStanja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPracenjeStanja
            // 
            this.dgvPracenjeStanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPracenjeStanja.Location = new System.Drawing.Point(12, 12);
            this.dgvPracenjeStanja.Name = "dgvPracenjeStanja";
            this.dgvPracenjeStanja.Size = new System.Drawing.Size(430, 237);
            this.dgvPracenjeStanja.TabIndex = 0;
            // 
            // PracenjeStanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 261);
            this.Controls.Add(this.dgvPracenjeStanja);
            this.Name = "PracenjeStanja";
            this.Text = "PracenjeStanja";
            this.Load += new System.EventHandler(this.PracenjeStanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPracenjeStanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPracenjeStanja;
    }
}