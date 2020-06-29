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
    public class Payment_Service
    {
        private static Payment_Service _uniquePaymentService;
        private Payment_DAO payment_DAO = new Payment_DAO();
        public static Payment_Service GetPaymentService()
        {
            if (_uniquePaymentService == null)
            {
                _uniquePaymentService = new Payment_Service();
            }
            return _uniquePaymentService;
        }

        public List<int> GetAllReservationID()
        {
            List<int> ids = new List<int>();
            try
            {
                DataTable dataTable = payment_DAO.GetAllReservationID();
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    ids.Add(dataRow.Field<int>("ReservationID"));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return ids;
        }

        public List<OrderDetails> GetOrderDetails(int ReservationID)
        {
            List<OrderDetails> orderDetails = new List<OrderDetails>();
            try
            {
                DataTable dataTable = payment_DAO.GetOrderDetails(ReservationID);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    OrderDetails details = new OrderDetails(dataRow.Field<string>("MenuItemName"), dataRow.Field<int>("Amount"), dataRow.Field<decimal>("PricePP"), dataRow.Field<int>("MenuTypeID"));
                    orderDetails.Add(details);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return orderDetails;
        }

        public void PlacePayment(double PaymentTip, int PaymentMethod)
        {
            Payment_DAO dao = Payment_DAO.GetPaymentDAO();
            try
            {
                dao.PlacePayment(DateTime.Now, PaymentTip, PaymentMethod);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
