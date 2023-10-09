using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employee
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Employee(string name, string email, string password, string username)
        {
            Username = username;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
