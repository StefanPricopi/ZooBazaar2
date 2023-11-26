using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class EmpProfile
    {
        public int employeeID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
        public string partnerFirstName { get; set; }
        public string partnerLastName { get; set; }
        public string partnerPhoneNumber { get; set; }
        public DateTime dateOfBirth { get; set; }

        public EmpProfile() { }
        EmpProfile(int employeeID, string username, string password, string email, string firstName, string lastName, string phoneNumber, string street, string city, string zipcode, string country, string partnerFirstName, string partnerLastName, string partnerPhoneNumber, DateTime dateOfBirth)
        {
            this.employeeID = employeeID;
            this.username = username;
            this.password = password;
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.street = street;
            this.city = city;
            this.zipcode = zipcode;
            this.country = country;
            this.partnerFirstName = partnerFirstName;
            this.partnerLastName = partnerLastName;
            this.partnerPhoneNumber = partnerPhoneNumber;
            this.dateOfBirth = dateOfBirth;
        }
    }
}
