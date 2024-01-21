using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace individual_project.Pages
{
    public class PasswordResetErrorModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (base.User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/index");
            }
            return Page();
        }
    }
}
