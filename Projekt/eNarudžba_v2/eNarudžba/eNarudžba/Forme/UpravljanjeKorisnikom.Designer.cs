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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPasivni = new System.Windows.Forms.DataGridView();
            this.dgvAktivni = new System.Windows.Forms.DataGridView();
            this.btnAktiviraj = new System.Windows.Forms.Button();
            this.btnBlokiraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasivni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasivni korisnici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktivni korisnici";
            // 
            // dgvPasivni
            // 
            this.dgvPasivni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasivni.Location = new System.Drawing.Point(41, 55);
            this.dgvPasivni.MultiSelect = false;
            this.dgvPasivni.Name = "dgvPasivni";
            this.dgvPasivni.Size = new System.Drawing.Size(464, 150);
            this.dgvPasivni.TabIndex = 2;
            this.dgvPasivni.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPasivni_RowHeaderMouseClick);
            // 
            // dgvAktivni
            // 
            this.dgvAktivni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivni.Location = new System.Drawing.Point(41, 275);
            this.dgvAktivni.MultiSelect = false;
            this.dgvAktivni.Name = "dgvAktivni";
            this.dgvAktivni.Size = new System.Drawing.Size(464, 160);
            this.dgvAktivni.TabIndex = 3;
            this.dgvAktivni.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAktivni_RowHeaderMouseClick);
            // 
            // btnAktiviraj
            // 
            this.btnAktiviraj.Location = new System.Drawing.Point(430, 223);
            this.btnAktiviraj.Name = "btnAktiviraj";
            this.btnAktiviraj.Size = new System.Drawing.Size(75, 23);
            this.btnAktiviraj.TabIndex = 4;
            this.btnAktiviraj.Text = "Aktiviraj";
            this.btnAktiviraj.UseVisualStyleBackColor = true;
            this.btnAktiviraj.Click += new System.EventHandler(this.btnAktiviraj_Click);
            // 
            // btnBlokiraj
            // 
            this.btnBlokiraj.Location = new System.Drawing.Point(430, 452);
            this.btnBlokiraj.Name = "btnBlokiraj";
            this.btnBlokiraj.Size = new System.Drawing.Size(75, 23);
            this.btnBlokiraj.TabIndex = 5;
            this.btnBlokiraj.Text = "Blokiraj";
            this.btnBlokiraj.UseVisualStyleBackColor = true;
            this.btnBlokiraj.Click += new System.EventHandler(this.btnBlokiraj_Click);
            // 
            // UpravljanjeKorisnikom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 503);
            this.Controls.Add(this.btnBlokiraj);
            this.Controls.Add(this.btnAktiviraj);
            this.Controls.Add(this.dgvAktivni);
            this.Controls.Add(this.dgvPasivni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpravljanjeKorisnikom";
            this.Text = "UpravljanjeKorisnikom";
            this.Load += new System.EventHandler(this.UpravljanjeKorisnikom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasivni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivni)).EndInit();
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
    }
}