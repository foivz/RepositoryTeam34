using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eNarudžba.Forme;

namespace eNarudžba.Forme
{
    public partial class GlavnaFormaNarucitelj : Form
    {
        Int64 oib;
        public GlavnaFormaNarucitelj(Int64 prijava)
        {
            InitializeComponent();
            oib = prijava;
        }

        private void btnPovijestNarudžbi_Click(object sender, EventArgs e)
        {
            PovijestNarudzbi povijestNarudzbi = new PovijestNarudzbi(oib);
            povijestNarudzbi.Show();
            this.Close();
        }

        private void btnPonudaJelovnika_Click(object sender, EventArgs e)
        {
            PonudaJelovnika ponudaJelovnika = new PonudaJelovnika(oib);
            ponudaJelovnika.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
                
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
               
        }

        private Point mouse_offset;

        private void GlavnaFormaNarucitelj_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void GlavnaFormaNarucitelj_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos;
            }
        }

        

      
    }
}
