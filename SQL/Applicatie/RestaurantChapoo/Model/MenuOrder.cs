using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuOrder
    {
        public MenuOrder(int amount, int orderID, int menuItemID)
        {
            this.Amount = amount;
            this.OrderID = orderID;
            this.MenuItemID = menuItemID;
        }
        public int Amount { get; set; }
        public int OrderID { get; set; }
        public int MenuItemID { get; set; }
    }
}
