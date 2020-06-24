using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class KitchenBarOrder
    {
        public KitchenBarOrder(int orderID, string orderstatus, int tableID, List<Model.MenuItem> orderItems, DateTime orderTime)
        {
            OrderID = orderID;
            Orderstatus = orderstatus;
            TableID = tableID;
            OrderItems = orderItems;
            OrderTime = orderTime;
        }
        public int OrderID { get; private set; }
        public string Orderstatus { get; private set; }
        public int TableID { get; private set; }
        public List<Model.MenuItem> OrderItems { get; private set; }
        public DateTime OrderTime { get; private set; }
    }
}
