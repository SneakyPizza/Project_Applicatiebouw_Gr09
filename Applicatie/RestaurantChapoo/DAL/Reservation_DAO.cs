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
    public class Reservation_DAO : Base
    {
        public List<Reservation> GetReservation(DataTable dataTable)
        {
            List<Reservation> reservations = new List<Reservation>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int ReservationID = (int)dataRow["ReservationID"];
                int CustomerID = (int)dataRow["CustomerID"];
                DateTime StartTime = (DateTime)dataRow["StartTime"];
                DateTime EndTime = (DateTime)dataRow["EndTime"];
                string ReservationComment = (string)dataRow["ReservationComment"];
                string CustomerComment = (string)dataRow["CustomerComment"];
                int CustomerAmount = (int)dataRow["CustomerAmount"];
                Reservation reservation = new Reservation(ReservationID, CustomerID, StartTime, EndTime, ReservationComment, CustomerComment, CustomerAmount);
                reservations.Add(reservation);
            }
            return reservations;
        }
        public List<Customer> GetCustomers(DataTable dataTable)
        {
            List<Customer> customers = new List<Customer>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                int CustomerID = (int)dataRow["CustomerID"];
                string FirstName = (string)dataRow["FirstName"];
                string LastName = (string)dataRow["LastName"];
                string Phonenumber = (string)dataRow["Phonenumber"];
                Customer customer = new Customer(CustomerID, FirstName, LastName, Phonenumber);
                customers.Add(customer);
            }
            return customers;
        }

        public void CreateReservation(int CustomerID, int CustomerAmount)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@CustomerID", CustomerID);
            SqlParameter sqlParameter2 = new SqlParameter("@CustomerAmount", CustomerAmount);
            SqlParameter sqlParameter3 = new SqlParameter("@StartTime", DateTime.Now);
            SqlParameter sqlParameter4 = new SqlParameter("@EndTime", DateTime.Now.AddHours(2));
            SqlParameter sqlParameter5 = new SqlParameter("@ReservationComment", "");
            SqlParameter sqlParameter6 = new SqlParameter("@CustomerComment", "");
            SqlParameter[] sqlP = new SqlParameter[] { sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, sqlParameter6};
            ExecuteEditQuery("CreateReservation", sqlP);
        }

        public void UpdateReservation(int CustomerID, DateTime StartTime, DateTime EndTime, string ReservationComment, string CustomerComment, int CustomerAmount)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@CustomerID", CustomerID);
            SqlParameter sqlParameter2 = new SqlParameter("@StartTime", StartTime);
            SqlParameter sqlParameter3 = new SqlParameter("@EndTime", EndTime);
            SqlParameter sqlParameter4 = new SqlParameter("@ReservationComment", ReservationComment);
            SqlParameter sqlParameter5 = new SqlParameter("@CustomerComment", CustomerComment);
            SqlParameter sqlParameter6 = new SqlParameter("@CustomerAmount", CustomerAmount);
            SqlParameter[] sqlP = new SqlParameter[] { sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4, sqlParameter5, sqlParameter6};
            ExecuteEditQuery("UpdateReservation", sqlP);
        }
    }
}
