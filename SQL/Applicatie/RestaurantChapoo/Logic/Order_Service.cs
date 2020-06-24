using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logic
{
    public class Order_Service
    {
        Order_DAO Order_DAO = new Order_DAO();
        private static Order_Service _uniqueOrderService;

        public static Order_Service GetOrderService()
        {
            if(_uniqueOrderService == null)
            {
                _uniqueOrderService = new Order_Service();
            }
            return _uniqueOrderService;
        }

        public bool PlaceOrder(int reservationID, int currentemployeeID)
        {
            Order_DAO dao = Order_DAO.GetOrderDAO();
            try
            {
                dao.PlaceOrder(1, reservationID, 1, currentemployeeID);
            } catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public int GetMostRecentOrderID()
        {
            try
            {
                return Order_DAO.GetMostRecentOrderID();
            }
            catch (Exception e)
            {
                return 1;
            }
        }


    }
}
