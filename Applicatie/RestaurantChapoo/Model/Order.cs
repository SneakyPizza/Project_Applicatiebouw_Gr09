using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {

        public Order(int orderID, int orderstatus, int tableID, List<MenuItem> orderItems)
        {
            OrderID = orderID;
            Orderstatus = orderstatus;
            TableID = tableID;
            OrderItems = orderItems;
        }

        public int OrderID { get; }
        public int Orderstatus { get; }
        public int TableID { get; }
        public List<MenuItem> OrderItems { get; }
    }
}
