using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public Order(int orderStatus, int reservationID, int paymentID, int employeeID, DateTime orderTime)
        {
            this.OrderStatus = orderStatus;
            this.ReservationID = reservationID;
            this.PaymentID = paymentID;
            this.EmployeeID = employeeID;
            this.OrderTime = orderTime;
        }
        public int OrderStatus { get; private set; }
        public int ReservationID { get; private set; }
        public int PaymentID { get; private set; }
        public int EmployeeID { get; private set; }
        public DateTime OrderTime { get; private set; }
    }
}
