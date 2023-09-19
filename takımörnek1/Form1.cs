using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takımörnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFenerbahce_Click(object sender, EventArgs e)
        {
            lbltakim.Text = "Fenerbahçe";
            lbltakim.ForeColor = Color.Yellow;
            lbltakim.BackColor = Color.Blue;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBesiktas_Click(object sender, EventArgs e)
        {
            lbltakim.Text = "Beşiktaş";
            lbltakim.ForeColor = Color.White;
            lbltakim.BackColor = Color.Black;

        }

        private void btnRealmadrid_Click(object sender, EventArgs e)
        {
            lbltakim.Text = "Real Madrid";
            lbltakim.ForeColor = Color.White;
            lbltakim.BackColor = Color.Aquamarine;



        }

        private void btnGalatasaray_Click(object sender, EventArgs e)
        {
            lbltakim.Text = "Galatasaray";
            lbltakim.ForeColor = Color.Yellow;
            lbltakim.BackColor = Color.Red;

        }
    }
}
