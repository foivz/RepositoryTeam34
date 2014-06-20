namespace eNarudžba.Forme
{
    partial class ZaprimljeneNarudzbe
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
            this.dgvZaprimljeneNarudzbe = new System.Windows.Forms.DataGridView();
            this.dgvZaprimljeneNarudzbeDetalji = new System.Windows.Forms.DataGridView();
            this.btnPromijenaStatusa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbeDetalji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaprimljeneNarudzbe
            // 
            this.dgvZaprimljeneNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaprimljeneNarudzbe.Location = new System.Drawing.Point(12, 12);
            this.dgvZaprimljeneNarudzbe.Name = "dgvZaprimljeneNarudzbe";
            this.dgvZaprimljeneNarudzbe.Size = new System.Drawing.Size(640, 109);
            this.dgvZaprimljeneNarudzbe.TabIndex = 0;
            this.dgvZaprimljeneNarudzbe.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvZaprimljeneNarudzbe_RowHeaderMouseClick);
            // 
            // dgvZaprimljeneNarudzbeDetalji
            // 
            this.dgvZaprimljeneNarudzbeDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaprimljeneNarudzbeDetalji.Location = new System.Drawing.Point(12, 127);
            this.dgvZaprimljeneNarudzbeDetalji.Name = "dgvZaprimljeneNarudzbeDetalji";
            this.dgvZaprimljeneNarudzbeDetalji.Size = new System.Drawing.Size(640, 192);
            this.dgvZaprimljeneNarudzbeDetalji.TabIndex = 1;
            // 
            // btnPromijenaStatusa
            // 
            this.btnPromijenaStatusa.Location = new System.Drawing.Point(257, 325);
            this.btnPromijenaStatusa.Name = "btnPromijenaStatusa";
            this.btnPromijenaStatusa.Size = new System.Drawing.Size(168, 55);
            this.btnPromijenaStatusa.TabIndex = 2;
            this.btnPromijenaStatusa.Text = "Promijeni status";
            this.btnPromijenaStatusa.UseVisualStyleBackColor = true;
            this.btnPromijenaStatusa.Click += new System.EventHandler(this.btnPromijenaStatusa_Click);
            // 
            // ZaprimljeneNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 392);
            this.Controls.Add(this.btnPromijenaStatusa);
            this.Controls.Add(this.dgvZaprimljeneNarudzbeDetalji);
            this.Controls.Add(this.dgvZaprimljeneNarudzbe);
            this.Name = "ZaprimljeneNarudzbe";
            this.Text = "ZaprimljeneNarudzbe";
            this.Load += new System.EventHandler(this.ZaprimljeneNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbeDetalji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaprimljeneNarudzbe;
        private System.Windows.Forms.DataGridView dgvZaprimljeneNarudzbeDetalji;
        private System.Windows.Forms.Button btnPromijenaStatusa;
    }
}