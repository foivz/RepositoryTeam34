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
            PonudaJelovnika ponudaJelovnika = new PonudaJelovnika();
            ponudaJelovnika.Show();
            this.Close();
        }

        

      
    }
}
