using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Payment
    {
        public Payment(int paymentid, DateTime paymenttimestamp, int paymenttip, int paymentmethod)
        {
            this.PaymentID = paymentid;
            this.PaymentTimeStamp = paymenttimestamp;
            this.PaymentTip = paymenttip;
            this.PaymentMethod = paymentmethod;
        }

        public int PaymentID { get; private set; }
        public DateTime PaymentTimeStamp { get; private set; }
        public int PaymentTip { get; private set; }
        public int PaymentMethod { get; private set; }
    }
}
