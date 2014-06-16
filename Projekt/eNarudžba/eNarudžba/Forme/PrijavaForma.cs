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
        private int tipKorisnika;
        private Int64 oibKorisnika;
        

        public bool Validacija { get { return validacija; } set { validacija = value; } }
        public string KorisnickoIme { get { return korisnickoIme; } set { korisnickoIme = value; } }
        public string Lozinka { get { return lozinka; } set { lozinka = value; } }
        public int TipKorisnika { get { return tipKorisnika; } set { tipKorisnika = value; } }

        public Int64 OibKorisnika { get { return oibKorisnika; } set { oibKorisnika = value; } }

        public PrijavaForma()
        {
            InitializeComponent();
        }


        private void btnPrijavaPrijava_Click(object sender, EventArgs e)
        {
            Prijava();
        }


        /// <summary>
        /// Metoda prijava služi za provjeru validnosti autentikacijskih podataka,
        /// za provjeru koristi metodu autentikacija
        /// </summary>
        public void Prijava ()
        {
            if (txtBoxKorisnickoIme.Text.Length > 0 && txtBoxLozinka.Text.Length > 0)
            {
                if (Autentikacija(txtBoxKorisnickoIme.Text, txtBoxLozinka.Text))
                {
                    Validacija = true;
                    if (TipKorisnika == 1)
                    {
                        GlavnaFormaDjelatnik glavnaFormaDjelatnik = new GlavnaFormaDjelatnik();
                        glavnaFormaDjelatnik.Show();
                        this.Close();
                    }
                    else 
                    {
                        GlavnaFormaNarucitelj glavnaFormaNarucitelj = new GlavnaFormaNarucitelj(OibKorisnika);//makni this
                        glavnaFormaNarucitelj.Show();
                        this.Close();
                    }

                    
                }
                else 
                {
                    Validacija = false;
                    MessageBox.Show("Pogrešno uneseni podaci");

                    
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

                using (T34_DBEntities3 db = new T34_DBEntities3())
                {
                    var upit = (from k in db.Korisnik where k.Username == korIme && k.Lozinka == password select k).SingleOrDefault<Korisnik>();
                    OibKorisnika = upit.OIB;
                  
                    if(upit.Lozinka==password)
                    {
                        Validacija = true;
                        if (upit.TipKorisnika == 1)
                        {
                            TipKorisnika = 1;
                            
                        }
                        else 
                        {
                            TipKorisnika = 2;
                            

                        }
                        
                       
                        
                        return true;
                    }

                }      
            }
            catch (Exception) 
            {
                Validacija = false;
                return false;
            }
            Validacija = false;
            return false;
        }


    }
}
