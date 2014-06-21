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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PonudaJelovnika));
            this.dgvPonudaJelovnika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvKomentari = new System.Windows.Forms.DataGridView();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.dgvSastojci = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudaJelovnika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPonudaJelovnika
            // 
            this.dgvPonudaJelovnika.AllowUserToAddRows = false;
            this.dgvPonudaJelovnika.AllowUserToDeleteRows = false;
            this.dgvPonudaJelovnika.AllowUserToResizeColumns = false;
            this.dgvPonudaJelovnika.AllowUserToResizeRows = false;
            this.dgvPonudaJelovnika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPonudaJelovnika.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPonudaJelovnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonudaJelovnika.GridColor = System.Drawing.SystemColors.Window;
            this.dgvPonudaJelovnika.Location = new System.Drawing.Point(19, 65);
            this.dgvPonudaJelovnika.Name = "dgvPonudaJelovnika";
            this.dgvPonudaJelovnika.ReadOnly = true;
            this.dgvPonudaJelovnika.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPonudaJelovnika.Size = new System.Drawing.Size(501, 160);
            this.dgvPonudaJelovnika.TabIndex = 0;
            this.dgvPonudaJelovnika.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPonudaJelovnika_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ponuda jelovnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(276, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Komentari";
            // 
            // dgvKomentari
            // 
            this.dgvKomentari.AllowUserToAddRows = false;
            this.dgvKomentari.AllowUserToDeleteRows = false;
            this.dgvKomentari.AllowUserToResizeColumns = false;
            this.dgvKomentari.AllowUserToResizeRows = false;
            this.dgvKomentari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKomentari.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKomentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomentari.GridColor = System.Drawing.SystemColors.Window;
            this.dgvKomentari.Location = new System.Drawing.Point(279, 245);
            this.dgvKomentari.Name = "dgvKomentari";
            this.dgvKomentari.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKomentari.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKomentari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomentari.Size = new System.Drawing.Size(241, 160);
            this.dgvKomentari.TabIndex = 3;
            // 
            // btnNaruci
            // 
            this.btnNaruci.BackColor = System.Drawing.Color.White;
            this.btnNaruci.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNaruci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNaruci.Location = new System.Drawing.Point(422, 424);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(98, 32);
            this.btnNaruci.TabIndex = 4;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = false;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // dgvSastojci
            // 
            this.dgvSastojci.AllowUserToAddRows = false;
            this.dgvSastojci.AllowUserToDeleteRows = false;
            this.dgvSastojci.AllowUserToResizeColumns = false;
            this.dgvSastojci.AllowUserToResizeRows = false;
            this.dgvSastojci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSastojci.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSastojci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastojci.GridColor = System.Drawing.SystemColors.Window;
            this.dgvSastojci.Location = new System.Drawing.Point(19, 245);
            this.dgvSastojci.Name = "dgvSastojci";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSastojci.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSastojci.Size = new System.Drawing.Size(243, 160);
            this.dgvSastojci.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sastojci";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PonudaJelovnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(545, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvSastojci);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.dgvKomentari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPonudaJelovnika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PonudaJelovnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eNaruždba";
            this.Load += new System.EventHandler(this.PonudaJelovnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonudaJelovnika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPonudaJelovnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvKomentari;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.DataGridView dgvSastojci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}