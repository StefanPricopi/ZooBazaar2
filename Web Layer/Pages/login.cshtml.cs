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
           

            userModel = ValidateLoginVisitorOrEmployee();

            UserDTO ValidateLoginVisitorOrEmployee()
            {
                return userManager.IsLoginEmployeeOrVisitor(User.Username, User.Password);
            }

            if (User == null)
            {
                return Page();
            }
            else
            {
                if (userModel.EmployeeID != 0)
                {

                    Console.WriteLine("Login successful.");
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, "user"),
                        new Claim(ClaimTypes.Email, "admin@website.com"),
                        new Claim("EmployeeId",userModel.EmployeeID.ToString()),
                        new Claim("Employee", "Caretaker"),
                        new Claim(ClaimTypes.Role, "Caretaker")
                    };
                    var identity = new ClaimsIdentity(claims, "LoginCookieAuth");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync("LoginCookieAuth", claimsPrincipal);

                    return RedirectToPage("/schedule");
                }
                else if (userModel.VisitorID != 0)
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

