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
    public partial class PracenjeStanja : Form
    {
        int idNarudzbe;
        public PracenjeStanja(int id)
        {
            InitializeComponent();
            idNarudzbe = id;
        }


        private void prikaziStatuse()
        {
            using (T34_DBEntities6 db = new T34_DBEntities6())
            {

                var upit = (from ns in db.NarudzbaStatus join n in db.Narudzba on ns.IDnarudzba equals n.IDnarudzba join s in db.Status on ns.IDstatus equals s.IDstatus where n.IDnarudzba==idNarudzbe select new { s.Naziv, ns.VrijemeKreiranjaStatusa}).ToList();

                BindingSource bindingSourcePracenjeStanja = new BindingSource();
                bindingSourcePracenjeStanja.DataSource = upit;
                dgvPracenjeStanja.DataSource = bindingSourcePracenjeStanja;
                dgvPracenjeStanja.Columns[0].HeaderText = "Status";
                dgvPracenjeStanja.Columns[0].HeaderText = "Vrijeme kreiranja statusa";
            }
        } 

        private void PracenjeStanja_Load(object sender, EventArgs e)
        {
            prikaziStatuse();
        }
    } 
}
