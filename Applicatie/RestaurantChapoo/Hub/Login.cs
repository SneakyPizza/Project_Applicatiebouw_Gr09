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
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            if(!string.IsNullOrWhiteSpace(txt_Username.Text) && !string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                login_Service.ValidateUser(username, password);
            } else
            {
                //Display incorrect validation
            }
            
        }
    }
}
