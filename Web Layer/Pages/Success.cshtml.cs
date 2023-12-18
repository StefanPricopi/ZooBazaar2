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
using ZXing;
using System.IO;
using System.Net.Http;
using ZXing.ImageSharp;
using ZXing.SkiaSharp;
using System.IO;
using System.Net.Http;
using SkiaSharp;
using ZXing.SkiaSharp.Rendering;

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
        private SKBitmap GenerateQRCodeWithResizedLogo(string link, string logoFilePath, int logoSize)
        {
            // Append the link to the qrCodeText
            string qrCodeText = "https://localhost:7281/Qrpage?" + Uri.EscapeUriString(link);

            // Create a BarcodeWriter instance for ZXing
            ZXing.BarcodeWriter<SKBitmap> barcodeWriter = new ZXing.BarcodeWriter<SKBitmap>
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300,
                    Height = 300
                },
                Renderer = new SKBitmapRenderer()
            };

            // Encoding the QR code
            SKBitmap qrCodeBitmap = barcodeWriter.Write(qrCodeText);

            // Loading the logo to the QR
            SKBitmap logoBitmap = SKBitmap.Decode(logoFilePath);

            if (qrCodeBitmap != null && logoBitmap != null)
            {
                // Resize the logo to fit within the specified size(the one set in parameter)
                logoBitmap = ResizeBitmap(logoBitmap, logoSize);

               // set it on the center
                int x = (qrCodeBitmap.Width - logoBitmap.Width) / 2;
                int y = (qrCodeBitmap.Height - logoBitmap.Height) / 2;

                // Create a new SKCanvas to draw the QR code and logo
                using (var canvas = new SKCanvas(qrCodeBitmap))
                {
                    // Draw the QR code
                    canvas.DrawBitmap(qrCodeBitmap, 0, 0);

                    // Draw the resized logo on top of the QR code
                    canvas.DrawBitmap(logoBitmap, x, y);
                }

                return qrCodeBitmap;
            }
            else
            {
                return null;
            }
        }

        private SKBitmap ResizeBitmap(SKBitmap bitmap, int newSize)
        {
            if (bitmap == null)
            {
                return null;
            }

            // calculating the new size while maintaining the aspect ratio
            int newWidth, newHeight;
            if (bitmap.Width > bitmap.Height)
            {
                newWidth = newSize;
                newHeight = (int)((float)bitmap.Height / bitmap.Width * newSize);
            }
            else
            {
                newWidth = (int)((float)bitmap.Width / bitmap.Height * newSize);
                newHeight = newSize;
            }
            SKBitmap resizedBitmap = new SKBitmap(newWidth, newHeight);
            using (var canvas = new SKCanvas(resizedBitmap))
            {
                var paint = new SKPaint
                {
                    FilterQuality = SKFilterQuality.High
                };
                canvas.DrawBitmap(bitmap, new SKRect(0, 0, newWidth, newHeight), paint);
            }

            return resizedBitmap;
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

        private Bitmap ConvertToSystemDrawingBitmap(SKBitmap skBitmap)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                skBitmap.Encode(SKEncodedImageFormat.Png, 100).SaveTo(stream);
                stream.Position = 0;
                return new Bitmap(stream);
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
                                string qrCodeText = "Your order number is: " + ticketID + "\r\n" +
                     "Your ticket type is: " + ticket.TicketType.ToString() + "\r\n" +
                     "Your email is: " + UserEmail + "\r\n" +
                     "The ticket is available for the date: " + ticket.DateValidity.Date.ToShortDateString() + "\r\n";
                                // Generate QR code as Bitmap
                                string logoFilePath = @"D:\project repository for group pj\zoo-bazaar-group-5\Web Layer\wwwroot\img\logo3.png"; // works only with absolute address for some reason huh

                                Bitmap qrCodeImage = ConvertToSystemDrawingBitmap(GenerateQRCodeWithResizedLogo(qrCodeText, logoFilePath, 90));// added parameter size keep it between 50-90 more 
                                                                                                                                               // will break the QR decoding
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
