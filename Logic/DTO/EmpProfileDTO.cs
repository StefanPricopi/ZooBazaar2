using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTO
{
    public class EmpProfileDTO
    {        
            public int employeeID { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string email { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string phoneNumber { get; set; }
            public string street {  get; set; }
            public string city { get; set; }
            public string zipcode { get; set; }
            public string country { get; set; }
            public string partnerFirstName { get; set; }
            public string partnerLastName { get; set; }
            public string partnerPhoneNumber { get; set; }
            public DateTime dateOfBirth { get; set; }

        public EmpProfileDTO() { }
        
    }
}
