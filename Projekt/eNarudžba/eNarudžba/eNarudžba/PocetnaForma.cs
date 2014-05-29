using eNarudžba.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNarudžba
{
    public partial class PocetnaForma : Form
    {
        
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            PrijavaForma prijavaForma = new PrijavaForma();
            prijavaForma.Show();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            RegistracijaForma registracijaForma = new RegistracijaForma();
            registracijaForma.Show();
        }
    }
}
