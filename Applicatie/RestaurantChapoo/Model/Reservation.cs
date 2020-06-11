using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        public Reservation(int reservationid, int customerid, DateTime starttime, DateTime endtime, string reservationcomment, string customercomment, int customeramount)
        {
            this.ReservationID = reservationid;
            this.CustomerID = customerid;
            this.StartTime = starttime;
            this.EndTime = endtime;
            this.ReservationComment = reservationcomment;
            this.CustomerComment = customercomment;
            this.CustomerAmount = customeramount;

        }

        public int ReservationID { get; private set; }
        public int CustomerID { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public string ReservationComment { get; private set; }
        public string CustomerComment { get; private set; }
        public int CustomerAmount { get; private set; }
    }
}
