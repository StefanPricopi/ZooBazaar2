using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BSN { get; set; }
        public string Position { get; set; }


        public Employee(string firstname, string lastname, string phoneNumber, DateTime dateOfBirth, string bsn, string position)
        {
            FirstName = firstname;
            LastName = lastname;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            BSN = bsn;
            Position = position;
        }
    }
}
