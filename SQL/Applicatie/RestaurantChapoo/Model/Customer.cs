using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public Customer(int customerid, string firstname, string lastname, string phonenumber)
        {
            this.CustomerID = customerid;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Phonenumber = phonenumber;
        }

        public int CustomerID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Phonenumber { get; private set; }
    }
}
