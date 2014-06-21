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
        PocetnaForma pocetna;

        public bool Validacija { get { return validacija; } set { validacija = value; } }
        public string KorisnickoIme { get { return korisnickoIme; } set { korisnickoIme = value; } }
        public string Lozinka { get { return lozinka; } set { lozinka = value; } }
        public int TipKorisnika { get { return tipKorisnika; } set { tipKorisnika = value; } }

        public Int64 OibKorisnika { get { return oibKorisnika; } set { oibKorisnika = value; } }

        public PrijavaForma(PocetnaForma forma)
        {
            InitializeComponent();
            pocetna = forma;
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
                    MessageBox.Show("Pogrešno uneseni podaci ili nemate pravo pristupa");

                    
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

                using (T34_DBEntities6 db = new T34_DBEntities6())
                {                                                                   //makni loz==pass    //&& status!=1
                    var upit = (from k in db.Korisnik where k.Username == korIme && k.Lozinka == password select k).SingleOrDefault<Korisnik>();
                    OibKorisnika = upit.OIB;
                  
                    // ili samo prije if (upit.Status==0) onda moze dalje, ako ne onda je false

                    if (upit.status == 0)
                    {
                        if (upit.Lozinka == password)
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
            }
            catch (Exception) 
            {
                Validacija = false;
                return false;
            }
            Validacija = false;
            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistracijaForma registracija = new RegistracijaForma(pocetna);
            registracija.Show();
            this.Close();

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pocetna.WindowState = FormWindowState.Normal;
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

        private void PrijavaForma_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void PrijavaForma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                this.Location = mousePos; //move the form to the desired location
            }
        }








    }
}
