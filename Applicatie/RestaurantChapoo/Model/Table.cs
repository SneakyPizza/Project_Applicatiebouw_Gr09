using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Table
    {
        public Table(int tableID, int tablestatus)
        {
            this.TableID = tableID;
            this.TableStatus = tablestatus;
        }

        static Table _uniqueTable;

        public static Table GetTable()
        {
            if(_uniqueTable == null)
            {
                _uniqueTable = new Table(5 , 0);
            }
            return _uniqueTable;
        }
        public int TableID { get; private set; }
        public int TableStatus { get; private set; }
        public Table currentTable { get; set; }
    }
}
