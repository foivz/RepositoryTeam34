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
        private int idHrane;
        public int IdHrane { get { return idHrane; } set { idHrane = value; } }
        public bool ProvjeraHrane { get { return provjeraHrane; } set { provjeraHrane = value; } }
        public bool ProvjeraPica { get { return provjeraPica; } set { provjeraPica = value; } }

        public PonudaJelovnika()
        {
            InitializeComponent();
        }


        private void PonudaJelovnikaa()
        {
            using (T34_DBEntities5 db = new T34_DBEntities5())
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
           // Komentari();

            DataGridViewCheckBoxColumn chkh = new DataGridViewCheckBoxColumn();
            dgvPonudaJelovnika.Columns.Add(chkh);
            chkh.HeaderText = "Naruciti";
            chkh.Name = "chk";
            //dgvPonudaJelovnika.Rows[2].Cells[3].Value = true;
        }
        private void dgvPonudaJelovnika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void PrikaziKomentare(int id)
        {
            using (T34_DBEntities5 db = new T34_DBEntities5())
            {
                var upit = (from k in db.komentariHrana join h in db.Hrana on k.hranaID equals h.IDhrana where h.IDhrana==id select new { k.komentarHrana }).ToList();
                BindingSource bindingSourceKomentari = new BindingSource();
                bindingSourceKomentari.DataSource = upit;
                dgvKomentari.DataSource = bindingSourceKomentari;
            }
        }

        private void dgvPonudaJelovnika_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selektiraniRed = dgvPonudaJelovnika.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selektiraniRed > 0)
            {
                IdHrane = int.Parse(dgvPonudaJelovnika.SelectedCells[0].Value.ToString());
                PrikaziKomentare(IdHrane);
            }
            else
            {
                MessageBox.Show("Nije odabran red");
            }
        }



    }
}
