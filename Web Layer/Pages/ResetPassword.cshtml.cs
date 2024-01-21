using Logic.DTO;
using Logic.Interfaces;
using Logic.Managers;
using Logic.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace individual_project.Pages
{
    public class ResetPasswordModel : PageModel
    {
        private readonly UserManager loginManager;
       
        public ResetPasswordModel(IUser loginService)
        {
            loginManager = new UserManager(loginService);
        }
        [BindProperty]
        public User User { get; set; }
        public IActionResult OnGet()
        {
            if (base.User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/index");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            User = loginManager.GetCurrentUserByUsername(User.Username);
            loginManager.SendResetEmail(User);
            return RedirectToPage("/ResetMessage");
        }
    }
}
