using System;
using System.Collections.Generic;
using System.Data;
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
        public bool ValidateUser(string username, string password)
        {
            DataTable dt = login_DAO.GetEmployee(username, password);
            if(CheckUser(password, dt))
            {
                //create new employee
                //set as curret login
                //set parameters
                //check the role
                CurrentEmployee = new Employee(dt.Rows[0].Field<int>("EmployeeID"),
                    dt.Rows[0].Field<string>("FirstName"), 
                    dt.Rows[0].Field<string>("LastName"), 
                    dt.Rows[0].Field<string>("Email"), 
                    //dt.Rows[0].Field<string>("Password"), 
                    dt.Rows[0].Field<int>("FunctionID"), 
                    dt.Rows[0].Field<string>("FunctionName"));

                //CheckRole(CurrentEmployee);
                return true;
            }

            return false;
            
        }

        private bool CheckUser(string password, DataTable dt)
        {
            if (password == dt.Rows[1].Field<string>("Password"))
            {
                return true;
            }
            return false;
        }

        public void RedirectUser(Employee e) 
        {
            int i = e.FunctionID;
            switch (i)
            {
                
                case 1: //Owner
                    break;
                case 2: //Waiter
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

        public Employee CurrentEmployee { get; private set; }
    }
}
