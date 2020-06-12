using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Order_DAO : Base
    {
        private static Order_DAO _uniqueOrderDAO;

        public static Order_DAO GetOrderDAO()
        {
            if(_uniqueOrderDAO == null)
            {
                _uniqueOrderDAO = new Order_DAO();
            }
            return _uniqueOrderDAO;
        }

        public void PlaceOrder(int orderStatus, int reservationID, int paymentID, int employeeID)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@orderStatus", orderStatus);
            SqlParameter sqlParameter2 = new SqlParameter("@reservationID", reservationID);
            SqlParameter sqlParameter3 = new SqlParameter("@paymentID", paymentID);
            SqlParameter sqlParameter4 = new SqlParameter("@employeeID", employeeID);
            SqlParameter sqlParameter5 = new SqlParameter("@orderTime", DateTime.Now);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5 };
            ExecuteEditQuery("PlaceOrder", sqlp);
        }
        public int GetMostRecentOrderID()
        {
           return GetOrderIDInt(ExecuteQuery("GetMostRecentOrderID"));
        }
        private int GetOrderIDInt(DataTable dataTable)
        {
            int ID = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ID = (int)dataRow["OrderID"];
            }
            return ID;
        }
    }
}
