using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace Logic
{
    public class PendingOrder_Service
    {
        Order_DAO order_DAO = new Order_DAO();

        public List<PendingOrder> GetAllPendingOrders()
        {
            try
            {
                return order_DAO.GetPendingOrders();
            }
            catch (Exception e)
            {
                List<PendingOrder> pendingOrders = new List<PendingOrder>();
                PendingOrder pendingorder = new PendingOrder(99, 99, "Failed");
                pendingOrders.Add(pendingorder);
                return pendingOrders;
            }
        }
    }
}
