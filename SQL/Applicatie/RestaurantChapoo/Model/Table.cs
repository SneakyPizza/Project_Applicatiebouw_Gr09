﻿using System;
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
        public int TableID { get; private set; }
        public int TableStatus { get; private set; }

    }
}
