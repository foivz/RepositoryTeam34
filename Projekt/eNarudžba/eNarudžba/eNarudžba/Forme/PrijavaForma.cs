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
    public partial class PrijavaForma : Form
    {
        private bool validacija=false;
        private string korisnickoIme="";
        private string lozinka="";

        public bool Validacija { get { return validacija; } set { validacija = value; } }
        public string KorisnickoIme { get { return korisnickoIme; } set { korisnickoIme = value; } }
        public string Lozinka { get { return lozinka; } set { lozinka = value; } }

        public PrijavaForma()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda prijava služi za provjeru validnosti autentikacijskih podataka,
        /// za provjeru koristi metodu autentikacija
        /// </summary>
        private void Prijava ()
        {
            if (txtBoxKorisnickoIme.Text.Length > 0 && txtBoxLozinka.Text.Length > 0)
            {
                if (Autentikacija(txtBoxKorisnickoIme.Text, txtBoxLozinka.Text))
                {
                    Validacija = true;
                    MessageBox.Show("Prošlo Validaciju"); //za provjeru
                    GlavnaForma glavnaForma = new GlavnaForma();
                    glavnaForma.Show();
                    this.Close();

                }
                else 
                {
                    Validacija = false;
                    MessageBox.Show("Nije prošlo validaciju"); //za provjeru
                    this.Close();

                }
            }
            else 
            {
                Validacija = false;
                MessageBox.Show("Niste unijeli podatke za prijavu", "Greška kod prijave");
            }
        }

        /// <summary>
        /// Provjera ispravnosti korisničkih podataka potrebnih za uspješnu prijavu
        /// </summary>
        /// <param name="korIme">uneseno korisničko ime</param>
        /// <param name="password">unesena lozinka</param>
        /// <returns>True-kada su podaci pronadjeni u bazi (ispravni); False-kada podaci nisu pronadjeni u bazi (neispravni) </returns>
        private bool Autentikacija(string korIme, string password)
        {
            try
            {
                
                using (T34_DBEntities db=new T34_DBEntities())
                {
                    var upit = (from k in db.Korisnik where k.Username == korIme && k.Lozinka == password select k).ToList();
                    foreach (var x  in upit)   
                    {
                        MessageBox.Show(x.Ime+" "+x.Prezime); //za provjeru dal je pronadjen korisnik
                    }
                    if (upit.Count()>0)  //select vraca 0 ako nema podataka ili 1 (u nasem slucaju jer budu jedinstveni username i pass u db) ako ima podataka
                    {
                        Validacija = true;
                        return true;
                    }

                }      
            }
            catch (Exception) 
            {
                Validacija = false;
                return false;
            }
            Validacija = false;    //ako je 0 'podataka' validacija je false
            return false;
        }

        private void btnPrijavaPrijava_Click(object sender, EventArgs e)
        {
            Prijava(); 
        }
        

    }
}
