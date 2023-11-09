using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTO
{
    public class VisitorDTO
    {
        public int VisitorID;
        public int UserID;
        public int TotalTicketsPurchased;
        public string Password;
        public string Username;
        public string Email;
        public string Salt;
        public VisitorDTO() { }
    }
}
