using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Entities;
using Logic.Interfaces;
namespace Logic.Managers
{
    public class TicketManager
    {
        private readonly ITicket iticket;
        public TicketManager(ITicket ticket)
        {
            iticket = ticket;
        }
        public int CreateTicket(Ticket ticket)
        {
            return iticket.CreateTicket(ticket);
        }
        public Ticket RetrieveTicketFromID(int id)
        {
            return iticket.RetrieveTicketFromID(id);
        }
        public bool CheckIfGivenQrIsValid(Ticket ticket, DateTime validity, int givenID) 
        {
            DateTime now = DateTime.Now;
            if (ticket != null) 
            {
                if(ticket.TicketID == givenID && ticket.DateValidity.Date == validity.Date && validity.Date == now.Date)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;   
            }
        }
    }
}
