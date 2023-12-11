using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    public class ticket_infoModel : PageModel
    {
        public IActionResult OnPost()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/buy_ticket");
            }
            else
            {
               return RedirectToPage("/login");
            }
        }
        public void OnGet()
        {
        }
    }
}
