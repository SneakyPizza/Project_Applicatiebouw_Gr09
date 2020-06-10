using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Logic;
using Model;

namespace Logic
{
    public class Table_Service
    {
        Table_DAO Table_DAO = new Table_DAO();
        public List<Table> GetAllTables()
        {
            try
            {
                return Table_DAO.GetAllTables();
            }
            catch (Exception e)
            {
                List<Table> tables = new List<Table>();
                Table table = new Table(99, 0);
                tables.Add(table);
                return tables;
            }
        }
        public int GetReservationID(int tableID)
        {
            try
            {
                return Table_DAO.GetReservationID(tableID);
            }
            catch (Exception e)
            {
                return 999;
            }
        }
    }
}


