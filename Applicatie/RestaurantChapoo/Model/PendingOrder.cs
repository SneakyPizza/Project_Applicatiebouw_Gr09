using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PendingOrder
    {
        public PendingOrder(int tableid, string orderstatusname)
        {
            this.OrderStatusName = orderstatusname;
            this.TableID = tableid;
        }
        public string OrderStatusName { get; private set; }
        public int TableID { get; private set; }
    }
}
