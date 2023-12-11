using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Ticket
    {
        private int ticketID;
        private int userID;
        private int count;
        private string ticketPrice;
        private string ticketType;
        private DateTime timeOfPurchase;
        private DateTime dateValidity;

        public int TicketID { get => ticketID; set => ticketID = value; }
        public int UserID { get => userID; set => userID = value; }
        public int Count { get => count; set => count = value; }
        public string TicketPrice { get => ticketPrice; set => ticketPrice = value; }
        public string TicketType { get => ticketType; set => ticketType = value; }
        public DateTime TimeOfPurchase { get => timeOfPurchase; set => timeOfPurchase = value; }
        public DateTime DateValidity { get => dateValidity; set => dateValidity = value; }

        public Ticket(int ticketID,int userID, string ticketPrice, string ticketType, DateTime timeOfPurchase, DateTime dateValidity, int count)
        {
            this.ticketID = ticketID;
            this.userID = userID;
            this.ticketPrice = ticketPrice;
            this.ticketType = ticketType;
            this.timeOfPurchase = timeOfPurchase;
            this.dateValidity = dateValidity;
            this.count = count;
        }
        public Ticket() { }

    }
}
