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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZaprimljeneNarudzbe));
            this.dgvZaprimljeneNarudzbe = new System.Windows.Forms.DataGridView();
            this.dgvZaprimljeneNarudzbeDetalji = new System.Windows.Forms.DataGridView();
            this.btnPromijenaStatusa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbeDetalji)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZaprimljeneNarudzbe
            // 
            this.dgvZaprimljeneNarudzbe.AllowUserToAddRows = false;
            this.dgvZaprimljeneNarudzbe.AllowUserToDeleteRows = false;
            this.dgvZaprimljeneNarudzbe.AllowUserToResizeColumns = false;
            this.dgvZaprimljeneNarudzbe.AllowUserToResizeRows = false;
            this.dgvZaprimljeneNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZaprimljeneNarudzbe.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvZaprimljeneNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaprimljeneNarudzbe.GridColor = System.Drawing.SystemColors.Window;
            this.dgvZaprimljeneNarudzbe.Location = new System.Drawing.Point(12, 57);
            this.dgvZaprimljeneNarudzbe.Name = "dgvZaprimljeneNarudzbe";
            this.dgvZaprimljeneNarudzbe.ReadOnly = true;
            this.dgvZaprimljeneNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaprimljeneNarudzbe.Size = new System.Drawing.Size(565, 160);
            this.dgvZaprimljeneNarudzbe.TabIndex = 0;
            this.dgvZaprimljeneNarudzbe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZaprimljeneNarudzbe_CellClick);
            // 
            // dgvZaprimljeneNarudzbeDetalji
            // 
            this.dgvZaprimljeneNarudzbeDetalji.AllowUserToAddRows = false;
            this.dgvZaprimljeneNarudzbeDetalji.AllowUserToDeleteRows = false;
            this.dgvZaprimljeneNarudzbeDetalji.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZaprimljeneNarudzbeDetalji.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvZaprimljeneNarudzbeDetalji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaprimljeneNarudzbeDetalji.GridColor = System.Drawing.SystemColors.Window;
            this.dgvZaprimljeneNarudzbeDetalji.Location = new System.Drawing.Point(12, 247);
            this.dgvZaprimljeneNarudzbeDetalji.Name = "dgvZaprimljeneNarudzbeDetalji";
            this.dgvZaprimljeneNarudzbeDetalji.ReadOnly = true;
            this.dgvZaprimljeneNarudzbeDetalji.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaprimljeneNarudzbeDetalji.Size = new System.Drawing.Size(565, 172);
            this.dgvZaprimljeneNarudzbeDetalji.TabIndex = 1;
            // 
            // btnPromijenaStatusa
            // 
            this.btnPromijenaStatusa.Location = new System.Drawing.Point(467, 425);
            this.btnPromijenaStatusa.Name = "btnPromijenaStatusa";
            this.btnPromijenaStatusa.Size = new System.Drawing.Size(110, 24);
            this.btnPromijenaStatusa.TabIndex = 2;
            this.btnPromijenaStatusa.Text = "Promijeni status";
            this.btnPromijenaStatusa.UseVisualStyleBackColor = true;
            this.btnPromijenaStatusa.Click += new System.EventHandler(this.btnPromijenaStatusa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zaprimljene narudžbe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detalji narudžbe";
            // 
            // ZaprimljeneNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPromijenaStatusa);
            this.Controls.Add(this.dgvZaprimljeneNarudzbeDetalji);
            this.Controls.Add(this.dgvZaprimljeneNarudzbe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ZaprimljeneNarudzbe";
            this.Text = "eNarudžba";
            this.Load += new System.EventHandler(this.ZaprimljeneNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneNarudzbeDetalji)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZaprimljeneNarudzbe;
        private System.Windows.Forms.DataGridView dgvZaprimljeneNarudzbeDetalji;
        private System.Windows.Forms.Button btnPromijenaStatusa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}