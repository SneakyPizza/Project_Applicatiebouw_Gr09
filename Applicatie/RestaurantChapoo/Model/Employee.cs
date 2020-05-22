using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        public Employee(int id, string firstname, string lastname, string email, string password, int functionID, string functionName)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            FunctionID = functionID;
            FunctionName = functionName;
        }

        public int Id { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public int FunctionID { get; private set; }
        public string FunctionName { get; private set; }
    }
}
