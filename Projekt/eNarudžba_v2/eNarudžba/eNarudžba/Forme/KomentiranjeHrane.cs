using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNarudžba.Forme
{
    public partial class KomentiranjeHrane : Form
    {
        int idHrane;
        public KomentiranjeHrane(int id)
        {
            InitializeComponent();
            idHrane = id;
        }

        private void PohraniKomentar() 
        {
            using (var db = new T34_DBEntities6())
            {
                komentariHrana komentarHrane = new komentariHrana
                {
                    komentarHrana=txtKomentari.Text,
                    hranaID=idHrane
                };
                db.komentariHrana.Add(komentarHrane);
                db.SaveChanges();
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            PohraniKomentar();
            this.Close();
        }

        private Point mouse_offset;

        private void KomentiranjeHrane_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void KomentiranjeHrane_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
