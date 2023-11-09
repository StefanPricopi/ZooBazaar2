using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Visitor : User
    {
        private int visitorID;
        private int userID;
        private int totalTicketPurchased;
        private string password;
        private string username;
        private string email;
        private string salt;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Salt
        {
            get { return salt; }
            set { salt = value; }
        }

        public int VisitorID
        {
            get { return visitorID; }
            set { visitorID = value; }
        }
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public int TotalTicketPurchased
        {
            get { return totalTicketPurchased; }
            set { totalTicketPurchased = value; }
        }
        public Visitor( int visitorID, int userID, int totalTicketPurchased,string password,string username,string email,string salt) 
        {
        this.visitorID = visitorID;
        this.userID = userID;
        this.totalTicketPurchased= totalTicketPurchased;
        this.email = email;
            this.salt = salt;
            this.username = username;
            this.password = password;
        }
        public VisitorDTO VisitorToVisitorDTO()
        {
            return new VisitorDTO()
            {
                TotalTicketsPurchased = this.totalTicketPurchased,
                VisitorID = this.visitorID,
                UserID = this.userID,
                Password = this.password,
                Email = this.email,
                Username = this.username,
                Salt = this.salt
            };
        }
    }
}
