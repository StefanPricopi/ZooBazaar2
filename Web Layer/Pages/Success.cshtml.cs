using Logic.Interfaces;
using Logic.Managers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripe;
using System.Drawing;
using System.Net.Mail;
using System.Net;
using System.Security.Claims;
using Logic.Entities;
using Newtonsoft.Json;
using Microsoft.Identity.Client;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System;
using System.Threading.Tasks;

namespace Web_Layer.Pages
{
    public class SuccessModel : PageModel
    {
        private readonly ITicket iticket;
        private readonly TicketManager ticketManager;
        public SuccessModel(ITicket TopUpService)
        {
            iticket = TopUpService;
            ticketManager = new TicketManager(iticket);
        }
        private async Task<Bitmap> GenerateQRCodeAsync(string qrCodeText)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync($"https://api.qrserver.com/v1/create-qr-code/?data={qrCodeText}&size=300x300");
                if (response.IsSuccessStatusCode)
                {
                    Stream stream = await response.Content.ReadAsStreamAsync();
                    return new Bitmap(stream);
                }
                else
                {
                    // Handle error response
                    return null;
                }
            }
        }

        private byte[] ImageToByteArray(Bitmap image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        private async Task SendEmailWithAttachmentsAsync(string recipientEmail, List<byte[]> attachmentList)
        {
            try
            {
                string senderEmail = "ruuvolt@gmail.com";
                string subject = "QR Code Confirmation Email";
                string messageBody = "Thank you for your action. See the attached QR codes below:";

                MailMessage mail = new MailMessage(senderEmail, recipientEmail);
                mail.Subject = subject;
                mail.Body = messageBody;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(senderEmail, "ybud uxim diox razv"),
                    EnableSsl = true,
                };
                int I = 1;
                foreach (var qrCodeImageData in attachmentList)
                {
                    
                    MemoryStream ms = new MemoryStream(qrCodeImageData);
                    mail.Attachments.Add(new Attachment(ms, "qr_code"+I+".png", "image/png"));
                    I++;
                }

                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


        private List<Ticket> ConvertAmountToTicketList(string serializedAmount)
        {
            List<Ticket> ticketList = JsonConvert.DeserializeObject<List<Ticket>>(serializedAmount);
            return ticketList ?? new List<Ticket>();
        }
        public async Task<IActionResult> OnGet(string token)
        {
            var userIdClaim = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            string UserEmail = HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            
            if (userIdClaim != null && UserEmail != null)
            {
                if (int.TryParse(userIdClaim.Value, out int userId))
                {
                    if (TempData.TryGetValue(token, out var amount) && amount is string serializedAmount)
                    {
                        List<byte[]> qrCodeImagesList = new List<byte[]>();
                        Ticket ticketclass = new Ticket();
                        List<Ticket> ticketList = ConvertAmountToTicketList(serializedAmount);
                        int testValue = 0; // this is a value for testing if the QR code
                        foreach (var ticket in ticketList)
                        {
                            for (int i = 0; i < ticket.Count; i++)
                            {
                                ticketclass.DateValidity = ticket.DateValidity;
                                ticketclass.TicketPrice = ticket.TicketPrice;
                                ticketclass.TimeOfPurchase = ticket.TimeOfPurchase;
                                ticketclass.TicketType = ticket.TicketType;
                                ticketclass.UserID = userId;
                                int ticketID = ticketManager.CreateTicket(ticketclass);
                                string qrCodeText ="Your order number is: " + ticketID + "\r\n" + "Your ticket type is: " + ticket.TicketType.ToString() + "\r\n" + "Your email is: " + UserEmail + "\r\n" + "the ticket is available for the date: " + ticket.DateValidity.Date.ToString() + "\r\n"; // Text to encode in QR code

                                // Generate QR code as Bitmap
                                Bitmap qrCodeImage = await GenerateQRCodeAsync(qrCodeText);

                                // Convert QR code image to byte array
                                byte[] qrCodeImageData = ImageToByteArray(qrCodeImage);

                                qrCodeImagesList.Add(qrCodeImageData);
                                testValue++;
                            }
                        }
                        // Combine all QR codes into a single image
                        await SendEmailWithAttachmentsAsync(UserEmail, qrCodeImagesList);
                        return Page();
                    }
                }
            }

            return RedirectToPage("/index");
        }
    }
}
