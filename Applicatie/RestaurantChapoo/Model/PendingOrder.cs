using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PendingOrder
    {
        public PendingOrder(int orderID, int tableid, string orderstatusname)
        {
            this.OrderID = orderID;
            this.OrderStatusName = orderstatusname;
            this.TableID = tableid;
        }
        public int OrderID { get; private set; }
        public string OrderStatusName { get; private set; }
        public int TableID { get; private set; }
    }
}
