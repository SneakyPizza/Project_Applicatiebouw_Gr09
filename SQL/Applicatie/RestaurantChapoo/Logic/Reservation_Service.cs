using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace Logic
{
    public class Reservation_Service
    {
        private static Reservation_Service _uniqueReservationService;
        public static Reservation_Service GetReservationService()
        {
            if (_uniqueReservationService == null)
            {
                _uniqueReservationService = new Reservation_Service();
            }
            return _uniqueReservationService;
        }

        public List<Table> GetTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int TableID = (int)dataRow["TableID"];
                int TableStatus = (int)dataRow["TableStatus"];
                Table table = new Table(TableID, TableStatus);
                tables.Add(table);
            }
            return tables;
        }
    }
}
