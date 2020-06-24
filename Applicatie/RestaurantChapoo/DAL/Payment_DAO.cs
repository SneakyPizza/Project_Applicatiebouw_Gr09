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
    public class Payment_DAO : Base
    {
        public void PlacePayment(int PaymentID, DateTime PaymentTimeStamp, int PaymentTip, int PaymentMethod)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@PaymentID", PaymentID);
            SqlParameter sqlParameter2 = new SqlParameter("@PaymentTimeStamp", PaymentTimeStamp);
            SqlParameter sqlParameter3 = new SqlParameter("@PaymentTip", PaymentTip);
            SqlParameter sqlParameter4 = new SqlParameter("@PaymentMethod", PaymentMethod);
            SqlParameter[] sqlP = new SqlParameter[] { sqlParameter1, sqlParameter2, sqlParameter3, sqlParameter4 };
            ExecuteEditQuery("PlacePayment", sqlP);
        }
<<<<<<< HEAD
=======

        public DataTable GetAllReservationID()
        {
            return ExecuteQuery("GetAllReservations");
        }

        public DataTable GetOrderDetails(int ReservationID)
        {
            SqlParameter sqlParameter1 = new SqlParameter("@ReservationID", ReservationID);
            SqlParameter[] sqlP = new SqlParameter[] { sqlParameter1 };
            return ExecuteQuery("ItemsInOrder", sqlP);
        }
>>>>>>> Lars-v2
    }
}
