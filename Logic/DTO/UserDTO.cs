using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic.DTO
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public int VisitorID { get; set; }
        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Salt { get; set; }
        public string Rfid { get; set; }
       
        public UserDTO() { }
        public UserDTO(UserDTO userDTO) { }
    }
}
