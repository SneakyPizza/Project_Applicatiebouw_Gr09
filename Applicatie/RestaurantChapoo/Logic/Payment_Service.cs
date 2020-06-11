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
        public static Payment_Service GetPaymentService()
        {
            if (_uniquePaymentService == null)
            {
                _uniquePaymentService = new Payment_Service();
            }
            return _uniquePaymentService;
        }

        public void CalculatePrice()
        {
            
        }

        public void CheckoutOrder()
        {

        }
    }
}
