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
    public partial class PovijestNarudzbi : Form
    {

        Int64 oibKorisnika;
        public PovijestNarudzbi(Int64 oib)
        {
            InitializeComponent();
            oibKorisnika = oib;


        }

        private void PovijestNarudzbi_Load(object sender, EventArgs e)
        {

            PrikaziPovijestNarudzbi();
            

        }
        private void PrikaziPovijestNarudzbi()
        {
            using (T34_DBEntities1 db = new T34_DBEntities1())
            {

              /*  var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarucitelj == oibKorisnika select new { n, nh, h, k }).ToList();

                int i = 1;
                foreach (var item in upit)
                {
                    ListViewItem items = new ListViewItem();
                    items.Text = i++.ToString();
                    items.SubItems.Add(item.n.DatumVrijemeZaprimanja.ToString());
                    items.SubItems.Add(item.h.Naziv);
                    items.SubItems.Add(item.n.CijenaNarudzbe.ToString());
                    listView1.Items.Add(items);
                }*/

               // var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarucitelj == oibKorisnika select new {n.IDnarudzba, n.DatumVrijemeZaprimanja, h.Naziv,h.IDvelicinaHrane ,n.CijenaNarudzbe }).ToList();
                var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarucitelj == oibKorisnika group n.IDnarudzba by n.IDnarudzba into grup select grup).ToList();

               // var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarucitelj == oibKorisnika group n.IDnarudzba by n.IDnarudzba into grup select new()).ToList();

                BindingSource bindingSourcePovijestNarudzbi = new BindingSource();
                bindingSourcePovijestNarudzbi.DataSource = upit;
                dgwPovijestNarudzbi.DataSource = bindingSourcePovijestNarudzbi;
            }
        }

        private void PrikaziDetaljeNarudzbe() 
        {
            using (T34_DBEntities1 db = new T34_DBEntities1())
            {

              
                
                var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarucitelj == oibKorisnika select new { n.IDnarudzba, n.DatumVrijemeZaprimanja, h.Naziv, h.IDvelicinaHrane, n.CijenaNarudzbe }).ToList();


                BindingSource bindingSourceDetalji = new BindingSource();
                bindingSourceDetalji.DataSource = upit;
                dgwPovijestNarudzbiDetalji.DataSource = bindingSourceDetalji;
            }
        }

    }
}
