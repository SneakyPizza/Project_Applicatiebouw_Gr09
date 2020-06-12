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
        public void GetColor() //bepaald kleuren voor hub knoppen
        {
            Login_Service service = Login_Service.GetLoginService();
            lbl_Ingelogd.Text = "Ingelogd: " + service.CurrentEmployee.Firstname + " " + service.CurrentEmployee.Lastname;
            int functionID = service.CurrentEmployee.FunctionID;
            switch (functionID)
            {
                case 1:
                    btn_Bar.BackColor = Color.Red;
                    btn_Keuken.BackColor = Color.Red;
                    btn_BestellingOpnemen.BackColor = Color.SkyBlue;
                    break;
                case 2:
                    btn_Bar.BackColor = Color.Red;
                    btn_Keuken.BackColor = Color.SkyBlue;
                    btn_BestellingOpnemen.BackColor = Color.Red;
                    break;
                case 3:
                    btn_Bar.BackColor = Color.SkyBlue;
                    btn_Keuken.BackColor = Color.Red;
                    btn_BestellingOpnemen.BackColor = Color.Red;
                    break;
                case 4:
                    btn_Bar.BackColor = Color.SkyBlue;
                    btn_Keuken.BackColor = Color.Red;
                    btn_BestellingOpnemen.BackColor = Color.Red;
                    break;
                case 5:
                    btn_Bar.BackColor = Color.SkyBlue;
                    btn_Keuken.BackColor = Color.SkyBlue;
                    btn_BestellingOpnemen.BackColor = Color.SkyBlue;
                    break;
            }

        }

        private void Btn_BestellingOpnemen_Click(object sender, EventArgs e)
        {
            Login_Service service = Login_Service.GetLoginService();
            if (service.CurrentEmployee.FunctionID == 1 || service.CurrentEmployee.FunctionID == 5)
            {
                BestellingOpnemen bestellingOpnemen = new BestellingOpnemen();
                bestellingOpnemen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Je hebt geen toestemming tot het 'Bestelling opnemen' scherm.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

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
            Login_Service service = Login_Service.GetLoginService();
            if (service.CurrentEmployee.FunctionID == 2 || service.CurrentEmployee.FunctionID == 5)
            {
                KeukenBar kb = KeukenBar.GetKeukenBar();
                kb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Je hebt geen toestemming tot het 'Keuken' scherm.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = Login.GetLoginScreen();
            Login_Service loginservice = Login_Service.GetLoginService();
            loginservice.LogoutEmployee();
            login.Show();
            this.Hide();
        }

        private void btn_Bar_Click(object sender, EventArgs e)
        {
            Login_Service service = Login_Service.GetLoginService();
            if (service.CurrentEmployee.FunctionID == 3 || service.CurrentEmployee.FunctionID == 4 || service.CurrentEmployee.FunctionID == 5)
            {
                KeukenBar kb = KeukenBar.GetKeukenBar();
                kb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Je hebt geen toestemming tot het 'Bar' scherm.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
