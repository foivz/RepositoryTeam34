namespace eNarudžba.Forme
{
    partial class PotvrdaNarudzbe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPotvrdaNarudzbe = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.IDprivremenaTablica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDnarudzbaH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDnarudzbaP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivHrana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivPice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaHrana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaPice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDprivremenaTablica,
            this.IDnarudzbaH,
            this.IDnarudzbaP,
            this.NazivHrana,
            this.NazivPice,
            this.CijenaHrana,
            this.CijenaPice,
            this.Opis,
            this.Kolicina});
            this.dataGridView1.Location = new System.Drawing.Point(28, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(965, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPotvrdaNarudzbe
            // 
            this.btnPotvrdaNarudzbe.Location = new System.Drawing.Point(250, 200);
            this.btnPotvrdaNarudzbe.Name = "btnPotvrdaNarudzbe";
            this.btnPotvrdaNarudzbe.Size = new System.Drawing.Size(121, 39);
            this.btnPotvrdaNarudzbe.TabIndex = 1;
            this.btnPotvrdaNarudzbe.Text = "Naruči!!!!";
            this.btnPotvrdaNarudzbe.UseVisualStyleBackColor = true;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(28, 200);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 39);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // IDprivremenaTablica
            // 
            this.IDprivremenaTablica.HeaderText = "ID";
            this.IDprivremenaTablica.Name = "IDprivremenaTablica";
            // 
            // IDnarudzbaH
            // 
            this.IDnarudzbaH.HeaderText = "Hrana";
            this.IDnarudzbaH.Name = "IDnarudzbaH";
            // 
            // IDnarudzbaP
            // 
            this.IDnarudzbaP.HeaderText = "Piće";
            this.IDnarudzbaP.Name = "IDnarudzbaP";
            // 
            // NazivHrana
            // 
            this.NazivHrana.HeaderText = "Naziv hrane";
            this.NazivHrana.Name = "NazivHrana";
            // 
            // NazivPice
            // 
            this.NazivPice.HeaderText = "Naziv pića";
            this.NazivPice.Name = "NazivPice";
            // 
            // CijenaHrana
            // 
            this.CijenaHrana.HeaderText = "Cijena hrane";
            this.CijenaHrana.Name = "CijenaHrana";
            // 
            // CijenaPice
            // 
            this.CijenaPice.HeaderText = "Cijena pića";
            this.CijenaPice.Name = "CijenaPice";
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis hrane";
            this.Opis.Name = "Opis";
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina pića";
            this.Kolicina.Name = "Kolicina";
            // 
            // PotvrdaNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 261);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPotvrdaNarudzbe);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PotvrdaNarudzbe";
            this.Text = "PotvrdaNarudzbe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPotvrdaNarudzbe;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDprivremenaTablica;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDnarudzbaH;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDnarudzbaP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivHrana;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaHrana;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaPice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
    }
}