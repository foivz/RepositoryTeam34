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
    public partial class ZaprimljeneNarudzbe : Form
    {
        private int idNarudzbe;
        private bool provjera = false;

        public int IdNarudzbe { get { return idNarudzbe; } set { idNarudzbe = value; } }
        public bool Provjera { get { return provjera; } set { provjera = value; } }
        public ZaprimljeneNarudzbe()
        {
            InitializeComponent();
        }

        private void ZaprimljeneNarudzbe_Load(object sender, EventArgs e)
        {
            PrikaziZaprimljeneNarudzbe();
        }

        private void PrikaziZaprimljeneNarudzbe() 
        {
            using (T34_DBEntities6 db = new T34_DBEntities6())
            {


                var upit = (from n in db.Narudzba join k in db.Korisnik on n.IDnarucitelj equals k.OIB join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba
                            join h in db.Hrana on nh.IDhrana equals h.IDhrana  where n.Zavrseno != 1 
                            group new { n, k, nh, h } by new { n.IDnarudzba, n.DatumVrijemeZaprimanja, k.Ime, k.Prezime, k.Adresa } 
                            into grup select new { grup.Key.IDnarudzba, grup.Key.DatumVrijemeZaprimanja, Cijena = grup.Sum(h => h.h.Cijena), grup.Key.Ime, grup.Key.Prezime, grup.Key.Adresa }).OrderByDescending(n => n.IDnarudzba).ToList();

                BindingSource bindingSourceZaprimljeneNarudzbe = new BindingSource();
                bindingSourceZaprimljeneNarudzbe.DataSource = upit;
                dgvZaprimljeneNarudzbe.DataSource = bindingSourceZaprimljeneNarudzbe;
            }
        }

        private void PrikaziZaprimljeneNarudzbeDetalji(int id)
        {
            using (T34_DBEntities6 db = new T34_DBEntities6())
            {

                var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB join vh in db.VelicinaHrane on h.IDvelicinaHrane equals vh.IDvelicinaHrane where n.IDnarudzba == id select new { h.IDhrana, Hrana = h.Naziv, CijenaHrane = h.Cijena }).ToList();
                BindingSource bindingSourceZaprimljeneNarudzbeDetalji = new BindingSource();
                bindingSourceZaprimljeneNarudzbeDetalji.DataSource = upit;
                dgvZaprimljeneNarudzbeDetalji.DataSource = bindingSourceZaprimljeneNarudzbeDetalji;

            }
 
        }

        private void btnPromijenaStatusa_Click(object sender, EventArgs e)
        {
            if (Provjera)
            {
                PromjenaStatusa promjenaStatusa = new PromjenaStatusa(IdNarudzbe);
                promjenaStatusa.Show();
            }
            else
            {
                string naslov = "Upozorenje";
                string poruka = "Morate odabrati narudžbu";
                PorukeStatus upozorenje = new PorukeStatus(naslov, poruka);
                upozorenje.ShowDialog();
            }
            
        }

        private void dgvZaprimljeneNarudzbe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selektiraniRed = dgvZaprimljeneNarudzbe.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed > 0)
            {
                IdNarudzbe = int.Parse(dgvZaprimljeneNarudzbe.SelectedCells[0].Value.ToString());
                PrikaziZaprimljeneNarudzbeDetalji(IdNarudzbe);
                Provjera = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GlavnaFormaDjelatnik glavnaFormaDjelatnik = new GlavnaFormaDjelatnik();
            glavnaFormaDjelatnik.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Point mouse_offset;
        private void ZaprimljeneNarudzbe_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void ZaprimljeneNarudzbe_MouseMove(object sender, MouseEventArgs e)
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
