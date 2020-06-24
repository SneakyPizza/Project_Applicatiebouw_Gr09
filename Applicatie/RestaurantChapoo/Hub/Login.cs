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
using Model;

namespace Hub
{
    public partial class Login : Form
    {
        
        private static Login _uniqueLogin;
        private Login_Service _login_service;
        public Login()
        {
            _uniqueLogin = this;
            InitializeComponent();
            _login_service = Login_Service.GetLoginService();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            //Remove home button from loginscreen. user needs to log in. 
            /*
            Hub hub = Hub.GetHubScreen();
            hub.Show();
            this.Hide();
            */
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
             string username = txt_Username.Text;
             string password = txt_Password.Text;
             if(_login_service.ValidateUser(username, password))
             {
                 //check role
                 //redirect user
                 RedirectLogin(_login_service.CurrentEmployee);
                 txt_Username.Text = String.Empty;
                 txt_Password.Text = String.Empty;
             }
             else
             {
                 MessageBox.Show("Ongeldige gebruikersnaam en/of wachtwoord.", "Foutmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

        }

        private void RedirectLogin(Employee e)
        {
            int i = e.FunctionID;
            switch (i)
            {
                case 1: //Ober
                    Hub o1 = Hub.GetHubScreen();
                    o1.GetColor();
                    this.Hide();
                    break;
                case 2: //Chef-kok
                    Hub o2 = Hub.GetHubScreen();
                    o2.GetColor();
                    this.Hide();
                    break;
                case 3: //Wijn-expert
                    Hub o3 = Hub.GetHubScreen();
                    o3.GetColor();
                    this.Hide();
                    break;
                case 4: //Barman
                    Hub o4 = Hub.GetHubScreen();
                    o4.GetColor();
                    this.Hide();
                    break;
                case 5: //Eigenaar
                    Hub o5 = Hub.GetHubScreen();
                    o5.GetColor();
                    o5.Show();
                    this.Hide();
                    break;
                default:
                    Hub o = Hub.GetHubScreen();
                    o.GetColor();
                    o.Show();
                    this.Hide();
                    break;
            }
        }

        public static Login GetLoginScreen()
        {
            if(_uniqueLogin == null)
            {
                _uniqueLogin = new Login();
            }
            return _uniqueLogin;
        }
    }
}
