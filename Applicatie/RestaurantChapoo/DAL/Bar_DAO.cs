using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Bar_DAO: Base
    {
        public DataTable GetOpenOrders()
        {
            //Getting all open orders.
            return ExecuteQuery("");
        }
    }
}
