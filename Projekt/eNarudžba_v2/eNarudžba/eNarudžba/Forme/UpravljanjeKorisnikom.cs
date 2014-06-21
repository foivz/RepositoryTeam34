using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace eNarudžba.Forme
{
    public partial class UpravljanjeKorisnikom : Form
    {
        private Int64 idPasivni;
        private Int64 idAktivni;

        public Int64 IdPasivni { get { return idPasivni; } set { idPasivni = value; } }

        public Int64 IdAktivni { get { return idAktivni; } set { idAktivni = value; } }
        public UpravljanjeKorisnikom()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(0, 140, 186);
        }

        private void UpravljanjeKorisnikom_Load(object sender, EventArgs e)
        {
            PrikaziPasivne();
            PrikaziAktivne();
        }

        private void PrikaziPasivne()
        {
            using (T34_DBEntities6 db=new T34_DBEntities6())
            {

                var upit = (from k in db.Korisnik where k.status == 1 && k.TipKorisnika==2 select new {OIB=k.OIB, Ime=k.Ime, Prezime=k.Prezime, KorisnickoIme=k.Username }).ToList();
                BindingSource bindingSourcePasivni = new BindingSource();
                bindingSourcePasivni.DataSource = upit;
                dgvPasivni.DataSource = bindingSourcePasivni;
            }
        }

        private void PrikaziAktivne()
        {
            using (T34_DBEntities6 db = new T34_DBEntities6())
            {

                var upit = (from k in db.Korisnik where k.status == 0 && k.TipKorisnika==2 select new {OIB=k.OIB, Ime = k.Ime, Prezime = k.Prezime, KorisnickoIme = k.Username }).ToList();
                BindingSource bindingSourceAktivni = new BindingSource();
                bindingSourceAktivni.DataSource = upit;
                dgvAktivni.DataSource = bindingSourceAktivni;
            }
        }


        private void Aktiviraj()
        {
            Korisnik korisnik;
            using (var dbSA = new T34_DBEntities6())
            {
                korisnik = dbSA.Korisnik.Where(k => k.OIB == IdPasivni).FirstOrDefault<Korisnik>();
            }
            if (korisnik!=null) 
            {
                korisnik.status = 0;
            }
            using (var dbUA = new T34_DBEntities6())
            {

                dbUA.Entry(korisnik).State = System.Data.Entity.EntityState.Modified;
                dbUA.SaveChanges();
            }
        }

        private void btnAktiviraj_Click(object sender, EventArgs e)
        {
            Aktiviraj();
          /*   dgvAktivni.Refresh();
            dgvPasivni.Refresh();
            this.Refresh(); */
            UpravljanjeKorisnikom_Load(this,null);
        }

        private void Deaktiviraj() 
        {
            Korisnik korisnik2;
            using (var dbSD = new T34_DBEntities6())
            {
                korisnik2 = dbSD.Korisnik.Where(k => k.OIB == IdAktivni).FirstOrDefault<Korisnik>();
            }
            if (korisnik2 != null)
            {
                korisnik2.status = 1;
            }
            using (var dbUD = new T34_DBEntities6())
            {

                dbUD.Entry(korisnik2).State = System.Data.Entity.EntityState.Modified;
                dbUD.SaveChanges();
            }
        }

        private void btnBlokiraj_Click(object sender, EventArgs e)
        {
            Deaktiviraj();
           /* dgvAktivni.Refresh();
            dgvPasivni.Refresh();
            this.Refresh(); */
            UpravljanjeKorisnikom_Load(this, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GlavnaFormaDjelatnik glavnaFormaDjelatnik = new GlavnaFormaDjelatnik();
            glavnaFormaDjelatnik.Show();
            this.Close();
        }

        private void dgvPasivni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selektiraniRed = dgvPasivni.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed > 0)
            {

                IdPasivni = Int64.Parse(dgvPasivni.SelectedCells[0].Value.ToString());

            }
            else
            {
                MessageBox.Show("Nije odabran red");
            }
        }

        private void dgvAktivni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selektiraniRed2 = dgvAktivni.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed2 > 0)
            {

                IdAktivni = Int64.Parse(dgvAktivni.SelectedCells[0].Value.ToString());

            }
            else
            {
                MessageBox.Show("Nije odabran red");
            }
        }
        
    }
}
