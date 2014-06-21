namespace eNarudžba.Forme
{
    partial class UpravljanjeKorisnikom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravljanjeKorisnikom));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPasivni = new System.Windows.Forms.DataGridView();
            this.dgvAktivni = new System.Windows.Forms.DataGridView();
            this.btnAktiviraj = new System.Windows.Forms.Button();
            this.btnBlokiraj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasivni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasivni korisnici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktivni korisnici";
            // 
            // dgvPasivni
            // 
            this.dgvPasivni.AllowUserToAddRows = false;
            this.dgvPasivni.AllowUserToDeleteRows = false;
            this.dgvPasivni.AllowUserToResizeColumns = false;
            this.dgvPasivni.AllowUserToResizeRows = false;
            this.dgvPasivni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPasivni.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPasivni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasivni.GridColor = System.Drawing.SystemColors.Window;
            this.dgvPasivni.Location = new System.Drawing.Point(39, 60);
            this.dgvPasivni.MultiSelect = false;
            this.dgvPasivni.Name = "dgvPasivni";
            this.dgvPasivni.ReadOnly = true;
            this.dgvPasivni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasivni.Size = new System.Drawing.Size(337, 150);
            this.dgvPasivni.TabIndex = 2;
            this.dgvPasivni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasivni_CellClick);
            // 
            // dgvAktivni
            // 
            this.dgvAktivni.AllowUserToResizeColumns = false;
            this.dgvAktivni.AllowUserToResizeRows = false;
            this.dgvAktivni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAktivni.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvAktivni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivni.GridColor = System.Drawing.SystemColors.Window;
            this.dgvAktivni.Location = new System.Drawing.Point(39, 262);
            this.dgvAktivni.MultiSelect = false;
            this.dgvAktivni.Name = "dgvAktivni";
            this.dgvAktivni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAktivni.Size = new System.Drawing.Size(337, 150);
            this.dgvAktivni.TabIndex = 3;
            this.dgvAktivni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAktivni_CellClick);
            // 
            // btnAktiviraj
            // 
            this.btnAktiviraj.BackColor = System.Drawing.SystemColors.Window;
            this.btnAktiviraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktiviraj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAktiviraj.Location = new System.Drawing.Point(301, 216);
            this.btnAktiviraj.Name = "btnAktiviraj";
            this.btnAktiviraj.Size = new System.Drawing.Size(75, 23);
            this.btnAktiviraj.TabIndex = 4;
            this.btnAktiviraj.Text = "Aktiviraj";
            this.btnAktiviraj.UseVisualStyleBackColor = false;
            this.btnAktiviraj.Click += new System.EventHandler(this.btnAktiviraj_Click);
            // 
            // btnBlokiraj
            // 
            this.btnBlokiraj.BackColor = System.Drawing.SystemColors.Window;
            this.btnBlokiraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlokiraj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBlokiraj.Location = new System.Drawing.Point(301, 418);
            this.btnBlokiraj.Name = "btnBlokiraj";
            this.btnBlokiraj.Size = new System.Drawing.Size(75, 23);
            this.btnBlokiraj.TabIndex = 5;
            this.btnBlokiraj.Text = "Blokiraj";
            this.btnBlokiraj.UseVisualStyleBackColor = false;
            this.btnBlokiraj.Click += new System.EventHandler(this.btnBlokiraj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UpravljanjeKorisnikom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(408, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBlokiraj);
            this.Controls.Add(this.btnAktiviraj);
            this.Controls.Add(this.dgvAktivni);
            this.Controls.Add(this.dgvPasivni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpravljanjeKorisnikom";
            this.Text = "eNarudžba";
            this.Load += new System.EventHandler(this.UpravljanjeKorisnikom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasivni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPasivni;
        private System.Windows.Forms.DataGridView dgvAktivni;
        private System.Windows.Forms.Button btnAktiviraj;
        private System.Windows.Forms.Button btnBlokiraj;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}