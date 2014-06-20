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
    public partial class KomentiranjeHrane : Form
    {
        int idHrane;
        public KomentiranjeHrane(int id)
        {
            InitializeComponent();
            idHrane = id;
        }

        private void PohraniKomentar() 
        {
            using (var db = new T34_DBEntities5())
            {
                komentariHrana komentarHrane = new komentariHrana
                {
                    komentarHrana=txtKomentari.Text,
                    hranaID=idHrane
                };
                db.komentariHrana.Add(komentarHrane);
                db.SaveChanges();
            }
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            PohraniKomentar();
            this.Close();
        }
    }
}
