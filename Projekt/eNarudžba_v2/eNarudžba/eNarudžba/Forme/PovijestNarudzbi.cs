﻿using System;
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

        private Int64 oibKorisnika;
        private int idNarudzbe;
        private int idHrane;

        public Int64 OibKorisnika { get { return oibKorisnika; } set { oibKorisnika= value; } }
        public int IdNarudzbe { get { return idNarudzbe; } set { idNarudzbe = value; } }

        public int IdHrane { get { return idHrane; } set { idHrane = value; } }
        
        public PovijestNarudzbi(Int64 oib)
        {
            InitializeComponent();
            OibKorisnika = oib;
        }

        private void PovijestNarudzbi_Load(object sender, EventArgs e)
        {
            PrikaziPovijestNarudzbi();
        }
        private void PrikaziPovijestNarudzbi()
        {
            using (T34_DBEntities6 db = new T34_DBEntities6())
            {

                var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana where n.IDnarucitelj == OibKorisnika group new { n, nh, h } by new { n.IDnarudzba, n.DatumVrijemeZaprimanja } into grup select new { grup.Key.IDnarudzba, grup.Key.DatumVrijemeZaprimanja, Cijena = grup.Sum(h => h.h.Cijena) }).OrderByDescending(n => n.IDnarudzba).ToList();
            
                BindingSource bindingSourcePovijestNarudzbi = new BindingSource();
                bindingSourcePovijestNarudzbi.DataSource = upit;
                dgwPovijestNarudzbi.DataSource = bindingSourcePovijestNarudzbi;
                dgwPovijestNarudzbi.Columns[0].HeaderText = "Br. narudžbe";
                dgwPovijestNarudzbi.Columns[1].HeaderText = "Datum i vrijeme naručivanja";
            }
        }

        private void PrikaziDetaljeNarudzbe(int id) 
        {

            using (T34_DBEntities6 db = new T34_DBEntities6())
            {
              
                var upit = (from n in db.Narudzba join nh in db.NarudzbaHrana on n.IDnarudzba equals nh.IDnarudzba join h in db.Hrana on nh.IDhrana equals h.IDhrana join k in db.Korisnik on n.IDnarucitelj equals k.OIB join vh in db.VelicinaHrane on h.IDvelicinaHrane equals vh.IDvelicinaHrane where n.IDnarudzba == id select new { h.IDhrana,h.Naziv, vh.Opis,h.Cijena }).ToList();
                BindingSource bindingSourceDetalji = new BindingSource();
                bindingSourceDetalji.DataSource = upit;
                dgwPovijestNarudzbiDetalji.DataSource = bindingSourceDetalji;
                dgwPovijestNarudzbiDetalji.Columns[0].HeaderText = "Br. hrane";
          
            }
        }


        private void btnPracenjeStanjaNarudzbe_Click(object sender, EventArgs e)
        {
            PracenjeStanja pracenjeStanja = new PracenjeStanja(IdNarudzbe);
            pracenjeStanja.Show();
        }

        private void btnKomentiranje_Click(object sender, EventArgs e)
        {
            KomentiranjeHrane komentiranjeHrane = new KomentiranjeHrane(IdHrane);
            komentiranjeHrane.Show();
        }


        private void dgwPovijestNarudzbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selektiraniRed = dgwPovijestNarudzbi.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed > 0)
            {

                IdNarudzbe = int.Parse(dgwPovijestNarudzbi.SelectedCells[0].Value.ToString());
                PrikaziDetaljeNarudzbe(IdNarudzbe);
            }
            else
            {
                MessageBox.Show("Nije odabran red");
            }
        }

        private void dgwPovijestNarudzbiDetalji_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selektiraniRed2 = dgwPovijestNarudzbiDetalji.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed2 > 0)
            {
                IdHrane = int.Parse(dgwPovijestNarudzbiDetalji.SelectedCells[0].Value.ToString());

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
