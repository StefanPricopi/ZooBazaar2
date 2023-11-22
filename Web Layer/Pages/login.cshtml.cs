using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using Logic.Managers;
using Logic.DTO;
using Logic.Interfaces;
using Logic.Entities;

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
            User s = new User();

            bool ValidateLoginEmployeeCase()
            {
                return userManager.IsLoginValidEmployeeCase(User.Username, User.Password);
            }

            bool ValidateLoginVisitorCase()
            {
                return userManager.IsLoginValidVisitorCase(User.Username, User.Password);
            }

            if (User == null)
            {
                return Page();
            }
            else
            {
                if (ValidateLoginEmployeeCase())
                {
                    s = userManager.GetCurrentUserByUsername(User.Username);
                    int id = userManager.GetEmpIDbyUserId(s.UserID);
                    Console.WriteLine("Login successful.");
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, "user"),
                        new Claim(ClaimTypes.Email, "admin@website.com"),
                        new Claim("EmployeeId",id.ToString()),
                        new Claim("Employee", "Caretaker")
                    };
                    var identity = new ClaimsIdentity(claims, "LoginCookieAuth");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync("LoginCookieAuth", claimsPrincipal);

                    return RedirectToPage("/schedule");
                }
                else if (ValidateLoginVisitorCase())
                {
                    Console.WriteLine("Login successful.");
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, "user"),
                        new Claim(ClaimTypes.Email, "admin@website.com")
                    };
                    var identity = new ClaimsIdentity(claims, "LoginCookieAuth");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync("LoginCookieAuth", claimsPrincipal);

                    return RedirectToPage("/index");
                }
            }

            return Page();
        }
    }
}

