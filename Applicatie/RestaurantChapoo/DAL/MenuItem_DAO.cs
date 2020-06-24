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
            return GetAllData(ExecuteQuery("GetMenuItems", sqlP));
        }
        public List<MenuItem> GetMenuItemOnName(string MenuItemName)
        {
            SqlParameter sqlParameter = new SqlParameter("@menuItemName", MenuItemName);
            SqlParameter[] sqlP = new SqlParameter[] { sqlParameter };
            return GetAllData(ExecuteQuery("GetMenuItemOnName", sqlP));
        }
        private List<MenuItem> GetAllData(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int menuItemID = (int)dataRow["MenuItemID"];
                string menuItemName = (string)dataRow["MenuItemName"].ToString();
                DateTime shelfLife = (DateTime)dataRow["ShelfLife"];
                int stock = (int)dataRow["Stock"];
                decimal pricePP = (decimal)dataRow["PricePP"];
                int menuTypeID = (int)dataRow["MenuTypeID"];
                MenuItem menuItem = new MenuItem(menuItemID, menuItemName, shelfLife, stock, pricePP, menuTypeID);
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
        public int GetMenuItemID(string menuItemName)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@menuItemName", menuItemName);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1 };
            return GetMenuItemInt(ExecuteQuery("GetMenuItemID", sqlp));
        }
        private int GetReservationInt(DataTable dataTable)
        {
            int ID = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ID = (int)dataRow["ReservationID"];
            }
            return ID;
        }
        private int GetMenuItemInt(DataTable dataTable)
        {
            int ID = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ID = (int)dataRow["MenuItemID"];
            }
            return ID;
        }
        public int GetReservationID(int tableID)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@tableID", tableID);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1 };
            return GetReservationInt(ExecuteQuery("GetReservationID", sqlp));
        }
    }
}
