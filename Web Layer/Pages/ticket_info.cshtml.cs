using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    public class ticket_infoModel : PageModel
    {
        public void OnPost()
        {
            if (User.Identity.IsAuthenticated)
            {
                RedirectToPage("/buy_ticket");
            }
            else
            {
                RedirectToPage("/login");
            }
        }
        public void OnGet()
        {
        }
    }
}
