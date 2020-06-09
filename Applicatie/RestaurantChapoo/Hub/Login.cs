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
        private Login_Service login_Service = new Login_Service();
        private static Login _uniqueLogin;
        public Login()
        {
            _uniqueLogin = this;
            InitializeComponent();
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
            if(!string.IsNullOrWhiteSpace(txt_Username.Text) && !string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                string username = txt_Username.Text;
                string password = txt_Password.Text;
                if(login_Service.ValidateUser(username, password))
                {
                    //check role
                    //redirect user
                    RedirectLogin(login_Service.CurrentEmployee);
                    txt_Username.Text = String.Empty;
                    txt_Password.Text = String.Empty;
                }
            } else
            {
                //Display Incorrect login error
            }
            
        }

        private void RedirectLogin(Employee e)
        {
            int i = e.FunctionID;
            switch (i)
            {
                case 1: //Owner
                    Hub o1 = Hub.GetHubScreen();
                    o1.Show();
                    this.Hide();
                    break;
                case 2: //Waiter
                    Hub o2 = Hub.GetHubScreen();
                    o2.Show();
                    this.Hide();
                    break;
                case 3: //Chef
                    break;
                case 4: //Wine-Expert
                    break;
                case 5: //Barman
                    break;
                default:
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
