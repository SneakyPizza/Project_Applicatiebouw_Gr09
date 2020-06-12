using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public MenuItem(int menuItemID, string menuItemName, DateTime shelfLife, int stock, decimal pricePP, int menuTypeID)
        {
            this.MenuItemID= menuItemID;
            this.MenuTypeName = menuItemName;
            this.ShelfLife = shelfLife;
            this.Stock = stock;
            this.PricePP = pricePP;
            this.MenuTypeID = menuTypeID;
        }
        public int MenuItemID { get; private set; }
        public string MenuTypeName { get; private set; }
        public DateTime ShelfLife { get; private set; }
        public int Stock { get; private set; }
        public decimal PricePP { get; private set; }
        public int MenuTypeID { get; private set; }
    }
}
