using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    public class QrpageModel : PageModel
    {
        public string EmbeddedUrl { get; private set; }
        public string AdditionalData { get; private set; }

        public void OnGet()
        {
            // Read QR code data from the query parameters
            string qrCodeData = HttpContext.Request.Query["data"];

            if (!string.IsNullOrEmpty(qrCodeData))
            {
                // Split the QR code data using the same delimiter used when generating the QR code
                string[] parts = qrCodeData.Split('|');

                if (parts.Length >= 2)
                {
                    // Retrieve embedded URL and additional data
                    EmbeddedUrl = Uri.UnescapeDataString(parts[0]);
                    AdditionalData = Uri.UnescapeDataString(parts[1]);

                    // You can now use EmbeddedUrl and AdditionalData as needed
                }
                else
                {
                    // Handle invalid QR code data
                }
            }
        }
    }
}
