using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Hub
{
    public partial class Hub : Form
    {
        private static Hub _uniqueHub;
        public Hub()
        {
            _uniqueHub = this;
            InitializeComponent();
            lbl_Datum.Text = DateTime.Now.ToString("d");
        }

        public static Hub GetHubScreen()
        {
            Login_Service service = Login_Service.GetLoginService();

            if (_uniqueHub == null)
            {
                _uniqueHub = new Hub();
            }
            return _uniqueHub;
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
            Login login = Login.GetLoginScreen();
            login.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login login = Login.GetLoginScreen();
            Login_Service loginservice = Login_Service.GetLoginService();
            loginservice.LogoutEmployee();
            login.Show();
            this.Hide();
        }

        private void btn_Keuken_Click(object sender, EventArgs e)
        {
            KeukenBar kb = KeukenBar.GetKeukenBar();
            kb.Show();
            this.Hide();
        }
    }
}
