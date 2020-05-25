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
    public partial class Login : Form
    {
        private Login_Service login_Service = new Login_Service();
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            Hub hub = new Hub();
            hub.Show();
            this.Close();
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
                }
            } else
            {
                //Display Incorrect login error
            }
            
        }
    }
}
