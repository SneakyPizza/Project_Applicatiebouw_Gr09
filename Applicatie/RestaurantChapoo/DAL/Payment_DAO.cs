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
        private static Payment_DAO _uniquePaymentDAO;
        public static Payment_DAO GetPaymentDAO()
        {
            if (_uniquePaymentDAO == null)
            {
                _uniquePaymentDAO = new Payment_DAO();
            }
            return _uniquePaymentDAO;
        }

        public void PlacePayment(DateTime PaymentTimeStamp, double PaymentTip, int PaymentMethod)
        {
            SqlParameter sqlParameter2 = new SqlParameter("@PaymentTimeStamp", PaymentTimeStamp);
            SqlParameter sqlParameter3 = new SqlParameter("@PaymentTip", PaymentTip);
            SqlParameter sqlParameter4 = new SqlParameter("@PaymentMethod", PaymentMethod);
            SqlParameter[] sqlP = new SqlParameter[] { sqlParameter2, sqlParameter3, sqlParameter4 };
            ExecuteEditQuery("PlacePayment", sqlP);
        }

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
    }
}
