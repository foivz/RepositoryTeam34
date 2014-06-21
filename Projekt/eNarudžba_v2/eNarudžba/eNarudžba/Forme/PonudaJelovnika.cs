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

        private int idHrane;
        private Int64 oibKorisnika;
        private int idNarudzbe;
        private List<int> idHrana = new List<int>();

        public List<int> IdHrana { get { return idHrana; } set { idHrana = value; } }
        public Int64 OibKorisnika { get { return oibKorisnika; } set { oibKorisnika = value; } }
        public int IdNarudzbe { get { return idNarudzbe; } set { idNarudzbe = value; } }
        public int IdHrane { get { return idHrane; } set { idHrane = value; } }


        public PonudaJelovnika(Int64 oib)
        {
            InitializeComponent();
            OibKorisnika = oib;
        }


        private void PonudaHrane()
        {
            using (T34_DBEntities6 db = new T34_DBEntities6())
            {
                var upit = (from h in db.Hrana join v in db.VelicinaHrane on h.IDvelicinaHrane equals v.IDvelicinaHrane select new { h.IDhrana, h.Naziv, h.Cijena, v.Opis }).ToList();

                BindingSource bindingSourcePonudaJelovnika = new BindingSource();
                bindingSourcePonudaJelovnika.DataSource = upit;
                dgvPonudaJelovnika.DataSource = bindingSourcePonudaJelovnika;
                dgvPonudaJelovnika.Columns[0].HeaderText = "R.broj";
            }
        }

        private void PonudaJelovnika_Load(object sender, EventArgs e)
        {
            PonudaHrane();
        }



        private void PrikaziKomentare(int id)
        {
            using (T34_DBEntities6 db = new T34_DBEntities6())
            {
                var upit = (from k in db.komentariHrana join h in db.Hrana on k.hranaID equals h.IDhrana where h.IDhrana==id select new { Komentar=k.komentarHrana }).ToList();
                BindingSource bindingSourceKomentari = new BindingSource();
                bindingSourceKomentari.DataSource = upit;
                dgvKomentari.DataSource = bindingSourceKomentari;
            }
        }

        private void PrikaziSastojke(int id)
        {
            using (T34_DBEntities6 db = new T34_DBEntities6())
            {
                var upit = (from s in db.Sastojci join hs in db.HranaSastojci on s.IDsastojci equals hs.IDsastojci join h in db.Hrana on hs.IDhrana equals h.IDhrana where hs.IDhrana == id select new {s.Naziv }).ToList();
                BindingSource bindingSourceSastojci = new BindingSource();
                bindingSourceSastojci.DataSource = upit;
                dgvSastojci.DataSource = bindingSourceSastojci;
                dgvSastojci.Columns[0].HeaderText = "Naziv sastojka";

            }
        }
             
        private void PohraniNarudzbu()
        {

            if (IdHrana.Count > 0)
            {
                //pohranjujem narudžbu
                using (var db = new T34_DBEntities6())
                {
                    DateTime vrijemeNarudzbe = DateTime.Now;

                    Narudzba narudzba = new Narudzba
                    {
                        DatumVrijemeZaprimanja = vrijemeNarudzbe,
                        IDnarucitelj = oibKorisnika
                    };
                    db.Narudzba.Add(narudzba);
                    db.SaveChanges();


                    //dohvaćam ID te narudžbe
                    var upitID = (from n in db.Narudzba where n.IDnarucitelj == OibKorisnika select n).OrderByDescending(n => n.DatumVrijemeZaprimanja).FirstOrDefault();
                    IdNarudzbe = upitID.IDnarudzba;


                    //pohranjujem naručenu hranu za tu narudžbu

                    foreach (var item in IdHrana)
                    {
                        NarudzbaHrana narudzbaHrana = new NarudzbaHrana
                        {
                            IDnarudzba = IdNarudzbe,
                            IDhrana = item
                        };
                        db.NarudzbaHrana.Add(narudzbaHrana);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Uspješno ste naručili hranu");
            }
            else
            {
                MessageBox.Show("Morate odabrati hranu.");
            }
           
        }


        private void btnNaruci_Click(object sender, EventArgs e)
        {
            PohraniNarudzbu();
        }

        private void dgvPonudaJelovnika_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selektiraniRed = dgvPonudaJelovnika.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selektiraniRed > 0)
            {
                IdHrane = int.Parse(dgvPonudaJelovnika.SelectedCells[0].Value.ToString());
                PrikaziKomentare(IdHrane);
                PrikaziSastojke(IdHrane);

                IdHrana.Add(int.Parse(dgvPonudaJelovnika.SelectedCells[0].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Nije odabran red");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GlavnaFormaNarucitelj glavnaFormaNarucitelj = new GlavnaFormaNarucitelj(OibKorisnika);
            glavnaFormaNarucitelj.Show();
            this.Close();
        }

    }
}
