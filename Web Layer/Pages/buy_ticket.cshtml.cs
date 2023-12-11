using Logic.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Stripe.Checkout;
using Stripe;
using Microsoft.Extensions.Primitives;
using static Web_Layer.Pages.buy_ticketModel;
using System.Linq;

namespace Web_Layer.Pages
{
    public class buy_ticketModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost(string ticketIds, decimal totalAmount, string ticketDetails)
        {
            if (!string.IsNullOrEmpty(ticketIds))
            {
                string[] ticketIdArray = ticketIds.Split(',');
                List<Ticket> Tickets = new List<Ticket>();
                // Deserialize the JSON string to get detailed ticket information
                var ticketDetailsList = JsonConvert.DeserializeObject<List<TicketDetails>>(ticketDetails);

                var lineItems = new List<SessionLineItemOptions>();

                foreach (var ticketDetail in ticketDetailsList)
                {
                    var ticket = new Ticket
                    {
                        UserID = 1, // Replace with actual user ID
                        TicketPrice = ticketDetail.Price.ToString(), // Use the price from details
                        TicketType = ticketDetail.TicketType, // Use the ticket type
                        Count = ticketDetail.Count,
                        TimeOfPurchase = DateTime.Now, // Replace with actual purchase time
                        DateValidity = ticketDetail.Date// Replace with actual validity date
                    };
                    Tickets.Add(ticket);
                    long parsedLongValue = Convert.ToInt64(ticketDetail.Price);
                    long parsed = Convert.ToInt64(ticketDetail.Count);
                    lineItems.Add(new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            
                    UnitAmount = (parsedLongValue) * 100,
                            Currency = "eur",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = $"{ticketDetail.TicketType} - {ticketDetail.Count} tickets"
                            }
                        },
                        Quantity = parsed, // Use the ticket quantity
                    });
                }

                var domain = "https://localhost:7281/";
                var token = Guid.NewGuid().ToString();
                var successUrl = $"{domain}success?token={token}";
                TempData[token] = JsonConvert.SerializeObject(Tickets);

                var options = new SessionCreateOptions
                {
                    SuccessUrl = successUrl,
                    CancelUrl = domain + "cancel",
                    Mode = "payment",
                    LineItems = lineItems
                };

                var service = new SessionService();
                var session = service.Create(options);
                Response.Headers.Add("Location", session.Url);
                return new StatusCodeResult(303);

            }
            else
            {
                return Page();
            }

            
                
            

        }
        public class TicketDetails
        {
            public string TicketType { get; set; }
            public int Count { get; set; }
            public decimal Price { get; set; }
            public DateTime Date { get; set; }
        }

    }
}
