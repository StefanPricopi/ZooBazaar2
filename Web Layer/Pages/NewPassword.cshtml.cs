using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace individual_project.Pages
{
    public class NewPasswordModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }
        private bool TokenIsCorrect;
        private UserManager loginManager;
        private string Token;
        public NewPasswordModel(Logic.Interfaces.IUser loginService)
        {
            loginManager = new UserManager(loginService);
        }
        public IActionResult OnPost()
        {
            Token = TempData["Token"].ToString();
            TokenIsCorrect = Convert.ToBoolean(TempData["Bool"]);
            if (TokenIsCorrect) 
            {
                
                loginManager.UpdateNewPassword(User.Password, Token);
                return RedirectToPage("/PasswordResetSuccess");
            }   
            return RedirectToPage("/PasswordResetError");
        }

        public IActionResult OnGet(string token)
        {
            if (base.User.Identity.IsAuthenticated)
            {
                return RedirectToPage("/index");
            }
            else
            {

            
            if (token != null)
            {
                Token = token;
                if (loginManager.receivedResetTokenMatch(token))
                {
                    TokenIsCorrect = true;
                    TempData["Bool"] = TokenIsCorrect;
                    TempData["Token"] = token;
                    return Page();
                }
                else
                {
                    TempData["Bool"] = false;
                    TempData["Token"] = token;
                    return Page();
                }
                
            }
            else
            {
                return Page();
            }
            }
        }
       
    }
}

