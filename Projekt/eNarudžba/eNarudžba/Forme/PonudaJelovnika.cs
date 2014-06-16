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
        private bool provjeraHrane = false;
        private bool provjeraPica = false;

        public bool ProvjeraHrane { get { return provjeraHrane; } set { provjeraHrane = value; } }
        public bool ProvjeraPica { get { return provjeraPica; } set { provjeraPica = value; } }

        public PonudaJelovnika()
        {
            InitializeComponent();
        }

        private void PonudaJelovnikaa() 
        {
            using (T34_DBEntities3 db = new T34_DBEntities3())
            {
                var upit = (from h in db.Hrana join v in db.VelicinaHrane on h.IDvelicinaHrane equals v.IDvelicinaHrane select new { h.IDhrana, h.Naziv, h.Cijena, v.Opis }).ToList();
                
                BindingSource bindingSourcePonudaJelovnika = new BindingSource();
                bindingSourcePonudaJelovnika.DataSource = upit;
                dgvPonudaJelovnika.DataSource = bindingSourcePonudaJelovnika;
            }
        }

        private void PonudaJelovnika_Load(object sender, EventArgs e)
        {
            PonudaJelovnikaa();
            PonudaPica();

            DataGridViewCheckBoxColumn chkh = new DataGridViewCheckBoxColumn();
            dgvPonudaJelovnika.Columns.Add(chkh);
            chkh.HeaderText = "Naruciti";
            chkh.Name = "chk";
            //dgvPonudaJelovnika.Rows[2].Cells[3].Value = true;
          
            DataGridViewCheckBoxColumn chkp = new DataGridViewCheckBoxColumn();
            dgvPonudapica.Columns.Add(chkp);
            chkp.HeaderText = "Naruciti";
            chkp.Name = "chk";
            //dgvPonudapica.Rows[2].Cells[3].Value = true;

           
        }

        private void dgvPonudaJelovnika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void PonudaPica()
        {
            using (T34_DBEntities3 db = new T34_DBEntities3())
            {
                var upit = (from p in db.Pice select new {p.IDpice, p.Naziv, p.Cijena, p.Kolicina }).ToList();
                BindingSource bindingSourcePonudaPica = new BindingSource();
                bindingSourcePonudaPica.DataSource = upit;
                dgvPonudapica.DataSource = bindingSourcePonudaPica;
            }
        }

        List<int> IDnarudzbaHLista=new List<int>();
        List<string> NazivHranaLista = new List<string>();
        List<decimal> CijenaHranaLista = new List<decimal>();
        List<string> OpisLista = new List<string>();
        List<int> IDnarudzbaPLista = new List<int>();
        List<string> NazivPiceLista=new List<string>();
        List<decimal> CijenaPiceLista = new List<decimal>();
        List<string> KolicinaLista=new List<string>();

        Dictionary<string, string> naruceno = new Dictionary<string, string>();


        private void btnNaruci_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> potvrdeni_redovi = new List<DataGridViewRow>();
            using (var db = new T34_DBEntities3())
            {
                PrivremenaTablica privremenaTablica = new PrivremenaTablica();

                foreach (DataGridViewRow row in dgvPonudaJelovnika.Rows)
                {
                   
                    if (Convert.ToBoolean(row.Cells[4].Value) == true)
                    {
               
                            naruceno.Add("IDHrana", row.Cells[0].Value.ToString());
                            naruceno.Add("NazivHrane", row.Cells[1].Value.ToString());
                            naruceno.Add("CijenaHrane", row.Cells[2].Value.ToString());
                            naruceno.Add("OpisHrana", row.Cells[3].Value.ToString());

                             /*IDnarudzbaHLista.Add(int.Parse(row.Cells[0].Value.ToString()));
                             NazivHranaLista.Add(row.Cells[1].Value.ToString());
                             CijenaHranaLista.Add(decimal.Parse(row.Cells[2].Value.ToString()));
                             OpisLista.Add(row.Cells[3].Value.ToString()); */

                             ProvjeraHrane = true;

                    }
                    
                    
                    //potvrdeni_redovi.Add(row);
                }
                

                foreach (DataGridViewRow row in dgvPonudapica.Rows)
                {
                    
                    if (Convert.ToBoolean(row.Cells[4].Value) == true)
                    {

                        /*IDnarudzbaPLista.Add(int.Parse(row.Cells[0].Value.ToString()));
                        NazivPiceLista.Add(row.Cells[1].Value.ToString());
                        CijenaPiceLista.Add(decimal.Parse(row.Cells[2].Value.ToString()));
                        KolicinaLista.Add(row.Cells[3].Value.ToString());*/

                        naruceno.Add("IDPice", row.Cells[0].Value.ToString());
                        naruceno.Add("NazivPice", row.Cells[1].Value.ToString());
                        naruceno.Add("CijenaPice", row.Cells[2].Value.ToString());
                        naruceno.Add("KolicinaPice", row.Cells[3].Value.ToString());

                        /*privremenaTablica.IDnarudzbaP = int.Parse(row.Cells[0].Value.ToString());
                        privremenaTablica.NazivPice = row.Cells[1].Value.ToString();
                        privremenaTablica.CijenaPice = decimal.Parse(row.Cells[2].Value.ToString());
                        privremenaTablica.Kolicina = row.Cells[3].Value.ToString();*/

                        ProvjeraPica = true;

                        //potvrdeni_redovi.Add(row);
                    }
                    
                }

                if (ProvjeraHrane || ProvjeraPica)
                {
                    //db.PrivremenaTablica.Add(privremenaTablica);
                    //db.SaveChanges();

                    PotvrdaNarudzbe potvrdiNarudzbu = new PotvrdaNarudzbe(naruceno);
                    potvrdiNarudzbu.Show();
                    this.Close();
                }
                else 
                { 
                    MessageBox.Show("Niste odabrali niti hranu niti piće!");
                }
            }
            
        }
    }
}
