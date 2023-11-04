using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BSN { get; set; }
        public string Position { get; set; }

        public EmployeeDTO() { }
        public EmployeeDTO(EmployeeDTO employeeDTO)
        {

        }
    }
}
