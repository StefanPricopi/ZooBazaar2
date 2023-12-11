using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Enums
{
    public class TicketEnums
    {
        Dictionary<string, int> ticketPrices = new Dictionary<string, int>
        {
            {"children", 3},
            {"adult", 15},
            {"elderly", 10}
        };
    }
}
