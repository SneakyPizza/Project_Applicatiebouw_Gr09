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
