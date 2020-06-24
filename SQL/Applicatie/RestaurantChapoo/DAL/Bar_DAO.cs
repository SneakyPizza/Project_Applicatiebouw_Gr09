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
            return ExecuteQuery("GetKitchenBarOrders");
        }

        public void UpdateOrder(int orderID, int newstatusID)
        {
            SqlParameter[] p = new SqlParameter[] { new SqlParameter("@statusID", newstatusID), new SqlParameter("@orderID", orderID) };
            ExecuteEditQuery("UpdateOrder", p);
        }
    }
}
