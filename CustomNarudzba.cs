using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrittoMisto
{
    public partial class CustomNarudzba : Form
    {
        public CustomNarudzba()
        {
            InitializeComponent();
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            CustomNarudzbaPrilog customPrilog = new CustomNarudzbaPrilog();
            customPrilog.Show();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            Narudzba narudzba = new Narudzba();
            narudzba.Show();
            this.Close();
        }
    }
}
