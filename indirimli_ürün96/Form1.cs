using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirimli_ürün96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double tutar = Convert.ToDouble(txtTutar.Text);


            if (rb5.Checked)
            {
                tutar = tutar * 0.95; // yüzde 5 indirim
            }
            else if (rb10.Checked)
            {
                tutar = tutar * 0.90;
            }
            else if (rb15.Checked)
            {
                tutar = tutar * 0.85;
            }
            else if (rb25.Checked)
            {
                tutar = tutar * 0.75;
            }

            lblIndirim.Text = tutar.ToString();
        }
    }
}
