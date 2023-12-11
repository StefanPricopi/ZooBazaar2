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
    }
}
