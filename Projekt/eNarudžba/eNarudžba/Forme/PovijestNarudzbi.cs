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
        private int idNarudzbe;
        
        public int IdNarudzbe { get { return idNarudzbe; } set { idNarudzbe = value; } }
        
        public PovijestNarudzbi(Int64 oib)
        {
            InitializeComponent();
            oibKorisnika = oib;


        }

        private void PovijestNarudzbi_Load(object sender, EventArgs e)
        {

            PrikaziPovijestNarudzbi();
           // PrikaziDetaljeNarudzbe(/*IdNarudzbe*/);
          //  PrikaziDetaljeNarudzbe(IdNarudzbe);

        }
        private void PrikaziPovijestNarudzbi()
        {
            using (T34_DBEntities2 db = new T34_DBEntities2())
            {

             //var upit = db.Narudzba.SqlQuery("Select IDnarudzba,DatumVrijemeZaprimanja,CijenaNarudzbe from Narudzba group by IDnarudzba,DatumVrijemeZaprimanja,CijenaNarudzbe").ToList();

               // var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarucitelj == oibKorisnika select new {n.IDnarudzba, n.DatumVrijemeZaprimanja, h.Naziv,h.IDvelicinaHrane ,n.CijenaNarudzbe }).ToList();
                
              //  var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarucitelj == oibKorisnika group n.IDnarudzba by n.IDnarudzba into grup select grup).ToList();
             // ok   var upit=(from n in db.Narudzba where n.IDnarucitelj==oibKorisnika group n by n.IDnarudzba into grup  select grup).ToList();

               // var upit = (from n in db.Narudzba where n.IDnarucitelj == oibKorisnika group n by n.IDnarudzba into grup select new { grup.Key, UkupnaCijena = grup.Sum(n => n.CijenaNarudzbe), DatumNarudzbe = grup.(n => n.DatumVrijemeZaprimanja) }).ToList();
                var upit = (from n in db.Narudzba where n.IDnarucitelj == oibKorisnika group n by new { n.IDnarudzba, n.DatumVrijemeZaprimanja, n.CijenaNarudzbe } into grup select new { grup.Key.IDnarudzba,grup.Key.DatumVrijemeZaprimanja,Cijena=grup.Sum(n => n.CijenaNarudzbe) }).ToList();
            

                BindingSource bindingSourcePovijestNarudzbi = new BindingSource();
                bindingSourcePovijestNarudzbi.DataSource = upit;
                dgwPovijestNarudzbi.DataSource = bindingSourcePovijestNarudzbi;
            }
        }

        private void PrikaziDetaljeNarudzbe(/*List<int> idnarudzba*/ int id) 
        {
           
            using (T34_DBEntities2 db = new T34_DBEntities2())
            {
              /*  var upit=(Object)null;
                foreach (var item in idnarudzba)
                {
                   var tmp = item;
                   upit =(from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB where n.IDnarudzba == 10 select new { n.IDnarudzba, n.DatumVrijemeZaprimanja, h.Naziv, h.IDvelicinaHrane, n.CijenaNarudzbe }).ToList();
                    
                } */

                var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB join vh in db.VelicinaHrane on h.IDvelicinaHrane equals vh.IDvelicinaHrane where n.IDnarudzba == id select new { h.Naziv, vh.Opis, n.CijenaNarudzbe }).ToList();
                BindingSource bindingSourceDetalji = new BindingSource();
                bindingSourceDetalji.DataSource = upit;
                dgwPovijestNarudzbiDetalji.DataSource = bindingSourceDetalji;

                //db.Narudzba.Attach(narudzba);
                
            }
        }

        

        private void dgwPovijestNarudzbi_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selektiraniRed = dgwPovijestNarudzbi.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed > 0)
            {
               /* int id;
                id = int.Parse(dgwPovijestNarudzbi.SelectedCells[0].Value.ToString()); */
                IdNarudzbe = int.Parse(dgwPovijestNarudzbi.SelectedCells[0].Value.ToString());
              //  MessageBox.Show(id);
                PrikaziDetaljeNarudzbe(IdNarudzbe);
            }
            else
            {
                MessageBox.Show("Nije odabran red");
            }
        }

        private void btnPracenjeStanjaNarudzbe_Click(object sender, EventArgs e)
        {
            PracenjeStanja pracenjeStanja = new PracenjeStanja(idNarudzbe);
            pracenjeStanja.Show();
        }

      

      

    }
}
