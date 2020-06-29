using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderDetails
    {
        public OrderDetails(string menuitemname, int amount, decimal price, int menutypeid)
        {
            this.MenuItemName = menuitemname;
            this.Amount = amount;
            this.Price = price;
            this.MenuTypeID = menutypeid;
        }

        public string MenuItemName { get; private set; }
        public int Amount { get; private set; }
        public decimal Price { get; private set; }
        public int MenuTypeID { get; private set; }
    }
}
