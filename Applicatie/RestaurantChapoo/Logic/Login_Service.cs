using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class Login_Service
    {
        private Login_DAO login_DAO = new Login_DAO();
        public void ValidateUser(string username, string password)
        {
            //validate the user
            if(login_DAO.AuthenticateUser(username, password))
            {
                //Authenticate user
            } else
            {
                throw new Exception("Incorrect login!");
            }
            
        }

        private void CheckRole(Employee e) 
        { 

        }

        public Employee CurrentEmployee { get; set; }
    }
}
