using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(int id, string firstName, string lastName, string phoneNumber)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
    }
}
