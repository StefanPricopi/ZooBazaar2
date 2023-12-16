using Logic.Entities;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Web_Layer.Pages
{
    public class QrpageModel : PageModel
    {
        public string OrderNumber { get; private set; }
        public string TicketType { get; private set; }
        public string Email { get; private set; }
        public DateTime TicketDate { get; private set; }
        public bool valid { get; set; } 

        private ITicket ticket;
        private Ticket selectedTicket = new Ticket();
        private TicketManager ticketManager;

        public QrpageModel(ITicket tik)
        {
            ticket = tik;
            ticketManager = new TicketManager(ticket);
        }
        public void OnGet()
        {
            
            string qrCodeData = HttpContext.Request.QueryString.Value;

            if (!string.IsNullOrEmpty(qrCodeData))
            {
            
                string[] parts = qrCodeData.Split("%0D%0A");

                foreach (var part in parts)
                {
                    
                    string[] keyValue = part.Split(':');
                    if (keyValue.Length == 2)
                    {
                       
                        string key = keyValue[0].Trim();
                        string value = Uri.UnescapeDataString(keyValue[1].Trim());

                        
                        switch (key)
                        {
                            case "?Your%20order%20number%20is":
                                OrderNumber = value.Trim();
                                break;
                            case "Your%20ticket%20type%20is":
                                TicketType = value.Trim();
                                break;
                            case "Your%20email%20is":
                                Email = value.Trim();
                                break;
                            case "The%20ticket%20is%20available%20for%20the%20date":
                                if (DateTime.TryParse(value.Trim(), out var date))
                                {
                                    TicketDate = date;
                                }
                                break;
                                
                        }
                    }
                }


                selectedTicket =  ticketManager.RetrieveTicketFromID(int.Parse(OrderNumber));
                valid = ticketManager.CheckIfGivenQrIsValid(selectedTicket, TicketDate, int.Parse(OrderNumber));
            }
            else
            {
                
            }
        }
    }
}
