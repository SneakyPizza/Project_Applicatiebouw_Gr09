using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hub
{
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
            lbl_Datum.Text = DateTime.Now.ToString("d");
        }

        private void Btn_BestellingOpnemen_Click(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.Show();
            BestellingOpnemen bestellingOpnemen = new BestellingOpnemen();
            bestellingOpnemen.Show();
            this.Hide();
        }

        private void Btn_Management_Click(object sender, EventArgs e)
        {
            Tafeloverzicht tafeloverzicht = new Tafeloverzicht();
            tafeloverzicht.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afreken afreken = new Afreken();
            afreken.Show();
            this.Hide();
        }
    }
}
