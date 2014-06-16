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
    public partial class PotvrdaNarudzbe : Form
        
    {
        Dictionary<string, string> narucen;
        public PotvrdaNarudzbe(Dictionary<string,string> naruceno)
        {
            InitializeComponent();
            narucen = naruceno;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (KeyValuePair<string, string> item in narucen)
	        {
                
	        }
            

            BindingSource bindingSourcePonudaJelovnika = new BindingSource();
            bindingSourcePonudaJelovnika.DataSource = narucen;
            dataGridView1.DataSource = bindingSourcePonudaJelovnika;
        }
    }
}
