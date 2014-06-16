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
    public partial class PromjenaStatusa : Form
    {
        int idNarudzbe;
        public PromjenaStatusa(int id)
        {
            InitializeComponent();
            idNarudzbe = id;
        }
        public void PrikaziStatuse()
        {
            using (var db = new T34_DBEntities2())
            {
                
                var upit = (from n in db.Narudzba join ns in db.NarudzbaStatus on n.IDnarudzba equals ns.IDnarudzba join s in db.Status on ns.IDstatus equals s.IDstatus where n.IDnarudzba == idNarudzbe select s.IDstatus).ToList();
                foreach (var status in upit)
                {
                    if (status == 1) 
                    {
                        rdbNarudzbaZaprimljena.Visible = false;
                    }
                    else if (status == 2) 
                    {
                        rdbNarudzbaNaRedu.Visible = false;
                    }
                    else if (status == 3)
                    {
                       rdbNarudzbaGotova.Visible = false;
                    }
                    else if (status == 4)
                    {
                        rdbDostavljaSe.Visible = false;
                    }
                    else if (status == 5)
                    {
                        rdbDostavljena.Visible = false;
                        lblNarudzbaDOstavljena.Visible = true;
                        btnPromijeniStatus.Visible = false;
                    }
                }
            }
        }

        public void PromijeniStatus()
        {
            using (var db = new T34_DBEntities2())
            {
                if (rdbNarudzbaZaprimljena.Checked == true)
                {
                    NarudzbaStatus narudzbaStatus = new NarudzbaStatus
                    {
                        IDnarudzba=idNarudzbe,
                        IDstatus=1,
                        VrijemeKreiranjaStatusa=DateTime.Now
                    };
                    db.NarudzbaStatus.Add(narudzbaStatus);
                    db.SaveChanges();

                }
                else if (rdbNarudzbaNaRedu.Checked == true)
                {
                    NarudzbaStatus narudzbaStatus = new NarudzbaStatus
                    {
                        IDnarudzba = idNarudzbe,
                        IDstatus = 2,
                        VrijemeKreiranjaStatusa = DateTime.Now
                    };
                    db.NarudzbaStatus.Add(narudzbaStatus);
                    db.SaveChanges();
                }
                else if (rdbNarudzbaGotova.Checked == true)
                {
                    NarudzbaStatus narudzbaStatus = new NarudzbaStatus
                    {
                        IDnarudzba = idNarudzbe,
                        IDstatus = 3,
                        VrijemeKreiranjaStatusa = DateTime.Now
                    };
                    db.NarudzbaStatus.Add(narudzbaStatus);
                    db.SaveChanges();
                }
                else if (rdbDostavljaSe.Checked == true)
                {
                    NarudzbaStatus narudzbaStatus = new NarudzbaStatus
                    {
                        IDnarudzba = idNarudzbe,
                        IDstatus = 4,
                        VrijemeKreiranjaStatusa = DateTime.Now
                    };
                    db.NarudzbaStatus.Add(narudzbaStatus);
                    db.SaveChanges();
                }
                else if (rdbDostavljena.Checked == true)
                {
                    NarudzbaStatus narudzbaStatus = new NarudzbaStatus
                    {
                        IDnarudzba = idNarudzbe,
                        IDstatus = 5,
                        VrijemeKreiranjaStatusa = DateTime.Now
                    };
                    db.NarudzbaStatus.Add(narudzbaStatus);
                    db.SaveChanges();
                }
            }
        } 

        private void PromjenaStatusa_Load(object sender, EventArgs e)
        {
            PrikaziStatuse();
        }

        private void btnPromijeniStatus_Click(object sender, EventArgs e)
        {
            PromijeniStatus();
            this.Close();
        }
    }
}
