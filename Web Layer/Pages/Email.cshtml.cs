using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Web_Layer.Pages
{
    public class EmailModel : PageModel
    {
        public void OnGet()
        {
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
        private async Task SendEmailWithAttachmentAsync(string recipientEmail, byte[] attachmentData)
        {
            try
            {


                string senderEmail = "ruuvolt@gmail.com";
                string receiverEmail = "miroslavpartalov22@gmail.com";
                string subject = "QR Code Confirmation Email";
                string messageBody = "Thank you for your action. Scan the QR code below:";

                MailMessage mail = new MailMessage(senderEmail, receiverEmail);
                mail.Subject = subject;
                mail.Body = messageBody;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(senderEmail, "ybud uxim diox razv"),
                    EnableSsl = true,
                };
                MemoryStream ms = new MemoryStream(attachmentData);
                mail.Attachments.Add(new Attachment(ms, "qr_code.png", "image/png"));
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



        }

        public async void OnPostTicket() 
        {
            string recipientEmail = "alin13032001asd@gmail.com"; // Replace with the recipient's email address
            string qrCodeText = "Example QR Code Text"; // Text to encode in QR code

            // Generate QR code as Bitmap
            Bitmap qrCodeImage = await GenerateQRCodeAsync(qrCodeText);

            // Convert QR code image to byte array
            byte[] qrCodeImageData = ImageToByteArray(qrCodeImage);

            // Send email with QR code attached
            SendEmailWithAttachmentAsync(recipientEmail, qrCodeImageData);
        }
    }
}
