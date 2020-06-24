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
        private static Login_Service _uniqueLoginService;
        public bool ValidateUser(string username, string password)
        {
            DataTable dt = login_DAO.GetEmployee(username, password);
            if(CheckUser(password, dt))
            {
                //create new employee
                //set as curret login
                //set parameters
                //check the role
                CurrentEmployee = new Employee(
                    dt.Rows[0].Field<int>("EmployeeID"),
                    dt.Rows[0].Field<string>("FirstName"), 
                    dt.Rows[0].Field<string>("LastName"), 
                    dt.Rows[0].Field<string>("EmailAdress"), 
                    //dt.Rows[0].Field<string>("Password"), 
                    dt.Rows[0].Field<int>("FunctionID"), 
                    dt.Rows[0].Field<string>("FunctionName")
                    );

                //CheckRole(CurrentEmployee);
                return true;
            }
            return false;
        }

        public static Login_Service GetLoginService()
        {
            if (_uniqueLoginService == null)
            {
                _uniqueLoginService = new Login_Service();
            }
            return _uniqueLoginService;
        }

        public void LogoutEmployee()
        {
            CurrentEmployee = null;
        }

        private bool CheckUser(string password, DataTable dt)
        {
            try
            {
                if (password == dt.Rows[0].Field<string>("Password"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }

            return false;
        }

        public Employee CurrentEmployee { get; private set; }
    }
}
