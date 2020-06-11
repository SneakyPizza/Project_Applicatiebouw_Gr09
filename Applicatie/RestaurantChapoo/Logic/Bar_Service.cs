using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Bar_Service
    {
        private Bar_DAO _bar_DAO = new Bar_DAO();
        private static Bar_Service _uniqueBarService;

        public static Bar_Service GetBarService()
        {
            if(_uniqueBarService == null)
            {
                _uniqueBarService = new Bar_Service();
            }
            return _uniqueBarService;
        }

        public List<Order> GetBarOrders()
        {
            List<Order> orders = new List<Order>();
            try
            {
                DataTable dt = _bar_DAO.GetOpenOrders();
                foreach(DataRow r in dt.Rows)
                {
                   

                }
            } catch(Exception e)
            {

            }
            return orders;
        }
    }
}
