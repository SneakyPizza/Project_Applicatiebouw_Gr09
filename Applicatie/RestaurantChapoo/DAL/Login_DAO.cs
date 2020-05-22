using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class Login_DAO: Base
    {
        public bool AuthenticateUser(string username, string password)
        {
            SqlParameter sp1 = new SqlParameter("", username);
            SqlParameter sp2 = new SqlParameter("", password);
            SqlParameter[] sps = new SqlParameter[] { sp1, sp2 };

            DataTable dt = ExecuteQuery("", sps);

            if(password == dt.Rows[1].Field<string>("Password"))
            {
                return true;
            }
            return false;
        }
    }
}
