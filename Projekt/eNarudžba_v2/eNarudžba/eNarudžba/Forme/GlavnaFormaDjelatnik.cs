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
    public partial class GlavnaFormaDjelatnik : Form
    {
        public GlavnaFormaDjelatnik()
        {
            InitializeComponent();
        }

        private void btnPregledZaprimljenihNarudzbi_Click(object sender, EventArgs e)
        {
            ZaprimljeneNarudzbe zaprimljeneNarudzbe = new ZaprimljeneNarudzbe();
            zaprimljeneNarudzbe.Show();
        }

        private void btnUpravljanjeKorisnikom_Click(object sender, EventArgs e)
        {
            UpravljanjeKorisnikom upravljanjeKorisnikom = new UpravljanjeKorisnikom();
            upravljanjeKorisnikom.Show();
        }
    }
}
