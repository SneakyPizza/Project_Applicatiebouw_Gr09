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
    public class MenuItem_DAO : Base
    {
        public List<MenuItem> GetMenuItems(int MenuTypeID)
        {
            SqlParameter sqlParameter = new SqlParameter("@MenuTypeID", MenuTypeID);
            SqlParameter[] sqlP = new SqlParameter[] { sqlParameter };
            return GetData(ExecuteQuery("GetMenuItems", sqlP));
        }
        private List<MenuItem> GetData(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int menuItemID = (int)dataRow["MenuItemID"];
                string menuItemName = (string)dataRow["MenuItemName"].ToString();
                DateTime shelfLife = (DateTime)dataRow["ShelfLife"];
                decimal pricePP = (decimal)dataRow["PricePP"];
                MenuItem menuItem = new MenuItem(menuItemID, menuItemName, shelfLife, pricePP);
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
    }
}
