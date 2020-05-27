using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Table
    {
        public Table(int tableID)
        {
            this.TableID = tableID;
        }
        public int TableID { get; private set; }

    }
}
