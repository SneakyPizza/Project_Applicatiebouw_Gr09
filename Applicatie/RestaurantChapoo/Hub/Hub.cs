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
                    btn_TableOverview.Visible = true;
                    btn_Checkout.Visible = false;
                    btn_TableOverview.BackColor = Color.SkyBlue;
                    btn_Bar.Visible = false;
                    btn_Keuken.Visible = false;
                    btn_BestellingOpnemen.Visible = false;
                    btn_TableOverview.Location = new Point(175, 57);
                    Tafeloverzicht to = Tafeloverzicht.GetTafeloverzichtScreen();
                    to.Show();
                    break;
                case 2:
                    btn_Keuken.Visible = true;
                    btn_Checkout.Visible = false;
                    btn_TableOverview.Visible = false;
                    btn_Bar.Visible = false;
                    btn_Keuken.BackColor = Color.SkyBlue;
                    btn_BestellingOpnemen.Visible = false;
                    btn_Keuken.Location = new Point(175, 57);
                    KeukenBar kb = KeukenBar.GetKeukenBar();
                    kb.Show();
                    kb.ReloadPage("Keuken");
                    break;
                case 3:
                    btn_Bar.Visible = true;
                    btn_Checkout.Visible = false;
                    btn_TableOverview.Visible = false;
                    btn_Bar.BackColor = Color.SkyBlue;
                    btn_Keuken.Visible = false;
                    btn_BestellingOpnemen.Visible = false;
                    btn_Bar.Location = new Point(175, 57);
                    KeukenBar kb1 = KeukenBar.GetKeukenBar();
                    kb1.Show();
                    kb1.ReloadPage("Bar");
                    this.Hide(); break;
                case 4:
                    btn_Bar.Visible = true;
                    btn_Checkout.Visible = false;
                    btn_TableOverview.Visible = false;
                    btn_Bar.BackColor = Color.SkyBlue;
                    btn_Keuken.Visible = false;
                    btn_BestellingOpnemen.Visible = false;
                    btn_Bar.Location = new Point(175, 57);
                    KeukenBar kb2 = KeukenBar.GetKeukenBar();
                    kb2.Show();
                    kb2.ReloadPage("Bar");
                    this.Hide(); break;
                case 5:
                    btn_TableOverview.Visible = true;
                    btn_Bar.Visible = true;
                    btn_Keuken.Visible = true;
                    btn_Checkout.Visible = false;
                    btn_TableOverview.BackColor = Color.SkyBlue;
                    btn_Bar.BackColor = Color.SkyBlue;
                    btn_Keuken.BackColor = Color.SkyBlue;
                    btn_BestellingOpnemen.Visible = false;
                    btn_Bar.Location = new Point(10, 57);
                    btn_TableOverview.Location = new Point(175, 57);
                    btn_Keuken.Location = new Point(350, 57);
                    break;
            }

        }

        private void Btn_BestellingOpnemen_Click(object sender, EventArgs e)
        {
            Login_Service service = Login_Service.GetLoginService();
            if (service.CurrentEmployee.FunctionID == 1 || service.CurrentEmployee.FunctionID == 5)
            {
                BestellingOpnemen bestellingOpnemen = BestellingOpnemen.GetOrderScreen();
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
                //kb.MakeKitchenOrders();
                kb.ReloadPage("Keuken");
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
                kb.ReloadPage("Bar");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Je hebt geen toestemming tot het 'Bar' scherm.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_TableOverview_Click(object sender, EventArgs e)
        {
            Login_Service service = Login_Service.GetLoginService();
            if(service.CurrentEmployee.FunctionID == 1 || service.CurrentEmployee.FunctionID == 5)
            {
                Tafeloverzicht to = Tafeloverzicht.GetTafeloverzichtScreen();
                to.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Je hebt geen toestemming om op het 'Tafeloverzicht' te komen.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            Login_Service service = Login_Service.GetLoginService();
            if (service.CurrentEmployee.FunctionID == 1 || service.CurrentEmployee.FunctionID == 5)
            {
                Afreken co = Afreken.GetAfrekenScreen();
                co.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Je hebt geen toestemming om op het 'Betaalscherm' te komen.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
