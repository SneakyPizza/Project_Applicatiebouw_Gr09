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
    public class MenuOrder_DAO : Base
    {
        public void PlaceMenuOrder(int amount, int orderID, int menuItemID)
        {
                SqlParameter sqlParameter1 = new SqlParameter("@amount", amount);
                SqlParameter sqlParameter2 = new SqlParameter("@orderID", orderID);
                SqlParameter sqlParameter3 = new SqlParameter("@menuItemID", menuItemID);
                SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1, sqlParameter2, sqlParameter3 };
                ExecuteEditQuery("PlaceMenuOrder", sqlp);
        }
    }
}
