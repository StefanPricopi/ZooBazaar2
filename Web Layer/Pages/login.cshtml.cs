using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Logic.Managers;
using Logic.DTO;
using Logic.Interfaces;

namespace Web_Layer.Pages
{
    public class loginModel : PageModel
    {

        private readonly UserManager userManager;
        private readonly IUser iLoginService;

        public loginModel(IUser loginService)
        {
            iLoginService = loginService;
            userManager = new UserManager(loginService);
        }

        [BindProperty]
        public UserDTO User { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            UserDTO userModel = new UserDTO();
            bool ValidateLogin()
            {
                return false;
            }

            if (User == null)
            {
                return Page();

            }
            else
            {
                if (ValidateLogin())
                {
                    Console.WriteLine("Login successful.");
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, "user"),
                        new Claim(ClaimTypes.Email, "admin@website.com")
                    };
                    var identity = new ClaimsIdentity(claims, "LoginCookieAuth");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                    // Store the original URL in a session variable


                    await HttpContext.SignInAsync("LoginCookieAuth", claimsPrincipal);

                    // Redirect to the original URL if it exists; otherwise, redirect to a default page
                    string originalUrl = HttpContext.Session.GetString("OriginalUrl");
                    if (!string.IsNullOrEmpty(originalUrl))
                    {
                        HttpContext.Session.Remove("OriginalUrl"); // Remove the original URL from the session
                        return Redirect(originalUrl);
                    }
                    else
                    {
                        return RedirectToPage("/index"); // Default page to redirect to if no original URL is found
                    }
                }
            }

            return Page();
        }
    }
}
