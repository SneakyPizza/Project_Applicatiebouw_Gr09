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
        public void PlaceOrder(int orderStatus, int reservationID, int paymentID, int employeeID)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@orderStatus", orderStatus);
            SqlParameter sqlParameter2 = new SqlParameter("@reservationID", reservationID);
            SqlParameter sqlParameter3 = new SqlParameter("@paymentID", paymentID);
            SqlParameter sqlParameter4 = new SqlParameter("@employeeID", employeeID);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4 };
            ExecuteQuery("PlaceOrder", sqlp);
        }

        private List<PendingOrder> GetOrder(DataTable dataTable)
        {
            List<PendingOrder> orders = new List<PendingOrder>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int TableID = (int)dataRow["TableID"];
                string OrderStatusName = (string)dataRow["OrderStatusName"];
                PendingOrder order = new PendingOrder(TableID, OrderStatusName);
                orders.Add(order);
            }
            return orders;
        }
        public List<PendingOrder> GetPendingOrders()
        {
            return GetOrder(ExecuteQuery("GetTableIDAndStatus"));
        }
    }
}
