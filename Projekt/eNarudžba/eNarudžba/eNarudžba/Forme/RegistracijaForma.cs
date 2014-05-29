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
    public partial class RegistracijaForma : Form
    {
        private bool validacija = false;
        private bool provjera = false;
        private string ime = "";
        private string prezime = "";
        private Int64 oib;
        private string korIme = "";
        private string lozinka = "";
        private string potvrdaLozinke = "";
        private string email = "";
        private string adresa = "";
        private bool student;

        public bool Validacija { get { return validacija; } set { validacija = value; } }
        public bool Provjera { get { return provjera; } set { provjera = value; } }
        public string Ime { get { return ime; } set { ime = value; } }
        public string Prezime { get { return prezime; } set { prezime = value; } }
        public Int64 Oib { get { return oib; } set { oib = value; } }
        public string KorIme { get { return korIme; } set { korIme = value; } }
        public string Lozinka { get { return lozinka; } set { lozinka = value; } }
        public string PotrdaLozinke { get { return potvrdaLozinke; } set { potvrdaLozinke = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Adresa { get { return adresa; } set { adresa = value; } }
        public bool Student { get { return student; } set { student = value; } }


        public RegistracijaForma()
        {
            InitializeComponent();
        }
        private void Registracija() 
        {
            bool radbtn;
            
           
            if (txtBoxIme.Text.Length > 0 && txtBoxPrezime.Text.Length > 0 && txtBoxOIB.Text.Length>0 && txtBoxRegKorIme.Text.Length > 0 && txtBoxRegLozinka.Text.Length > 0 && txtBoxPotvrdaLozinke.Text.Length > 0 && txtBoxEmail.Text.Length > 0 && txtBoxAdresa.Text.Length > 0 && (radioBtnDa.Checked || radioBtnNe.Checked))
            {




                if (!ProvjeraKorisnickogImena(txtBoxRegKorIme.Text) )
                {
                    MessageBox.Show("Korisnicko ime je zauzeto");
                    Provjera = false;
                    Validacija = false;
                }
                else if (txtBoxRegLozinka.Text != txtBoxPotvrdaLozinke.Text) 
                {
                    MessageBox.Show("Lozinka nije jednaka");
                }
                else
                {
                    if (radioBtnDa.Checked)   //ne funkcionira?  
                    {
                        radbtn = true;
                    }
                    radbtn = false;

                    using (var db = new T34_DBEntities())
                    {
                        Korisnik korisnik = new Korisnik
                        {
                            Ime = txtBoxIme.Text,
                            Prezime = txtBoxPrezime.Text,
                            OIB = Int64.Parse(txtBoxOIB.Text),
                            Username = txtBoxRegKorIme.Text,
                            Lozinka = txtBoxRegLozinka.Text,
                            Email = txtBoxEmail.Text,
                            Adresa = txtBoxAdresa.Text,
                            Student = radbtn,
                            TipKorisnika = 2 //2 je naručitelj 
                        };
                        db.Korisnik.Add(korisnik);
                        db.SaveChanges();
                    }

                    validacija = true;
                    MessageBox.Show("Uspješno ste se registrirali");
                    this.Close();
                }
              
            }
            else 
            {
                Validacija = false;
                MessageBox.Show("Niste unijeli podatke za registraciju", "Greška kod registracije");
            }
        }

        private void btnRegRegistracija_Click(object sender, EventArgs e)
        {
            Registracija();
        }


        private bool ProvjeraKorisnickogImena(string korIme) 
        {
            try
            {

                using (T34_DBEntities db = new T34_DBEntities())
                {
                    var upit = (from k in db.Korisnik where k.Username == korIme  select k).ToList();

                    if (upit.Count() == 0)  //ako nema korImena
                    {
                        Provjera = true;
                        return true;
                       // MessageBox.Show("Uspješno ste se registrirali");
                    }
                }
            }
            catch (Exception)
            {
               Provjera= false;
               return false;
            }
            Provjera = false;    //ako je 0 'podataka' validacija je false
            return false;
        }
    }
}
