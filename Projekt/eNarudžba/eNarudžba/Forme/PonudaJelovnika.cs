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
    public partial class PonudaJelovnika : Form
    {
        public PonudaJelovnika()
        {
            InitializeComponent();
        }

        private void PonudaJelovnikaa() 
        {
            using (T34_DBEntities1 db = new T34_DBEntities1())
            {

                

                // var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarucitelj == oibKorisnika select new {n.IDnarudzba, n.DatumVrijemeZaprimanja, h.Naziv,h.IDvelicinaHrane ,n.CijenaNarudzbe }).ToList();
               // var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarucitelj == oibKorisnika group n.IDnarudzba by n.IDnarudzba into grup select grup).ToList();

                // var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarucitelj == oibKorisnika group n.IDnarudzba by n.IDnarudzba into grup select new()).ToList();
                var upit = (from h in db.Hrana select h).ToList();
                BindingSource bindingSourcePonudaJelovnika = new BindingSource();
                bindingSourcePonudaJelovnika.DataSource = upit;
                dgvPonudaJelovnika.DataSource = bindingSourcePonudaJelovnika;
            }
        }

        private void PonudaJelovnika_Load(object sender, EventArgs e)
        {
            PonudaJelovnikaa();
        }

    }
}
