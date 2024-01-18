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
        public string PhoneNumber {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BSN { get; set; }
        public int RoleID { get; set; }

        public EmployeeDTO() { }
        public EmployeeDTO(EmployeeDTO employeeDTO)
        {

        }
    }
}
