using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Table_DAO : Base
    {
        public List<Table> GetAllTables()
        {
            return GetAllData(ExecuteQuery("GetAllTables"));
        }
        private List<Table> GetAllData(DataTable dataTable)
        {
                List<Table> tables = new List<Table>();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    int tableID = (int)dataRow["TableID"];
                    int tableStatus = Convert.ToInt32(dataRow["TableStatus"]);
                    Table table = new Table(tableID, tableStatus);
                    tables.Add(table);
                }
                return tables;
        }
        private int GetInt(DataTable dataTable)
        {
            int reservationID = 0;
            foreach (DataRow dataRow in dataTable.Rows) 
            {
                reservationID = (int)dataRow["ReservationID"];
            }
            return reservationID;
        }
        public int GetReservationID(int tableID)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@tableID", tableID);
            SqlParameter[] sqlp = new SqlParameter[] { sqlParameter1 };
            return GetInt(ExecuteQuery("GetReservationID", sqlp));
        }
    }
}
