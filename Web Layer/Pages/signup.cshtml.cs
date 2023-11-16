using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    public class signupModel : PageModel
    {
        private readonly UserManager userManager;
        private IUser userService;

        public signupModel(IUser UserService, UserManager manager)
        {
            userService = UserService;
            userManager = manager;
        }

        [BindProperty]
        public UserDTO User { get; set; }

        public IActionResult OnPost()
        {
            if (User != null)
            {

                userManager.CreateVisitor(User);
                return RedirectToPage("/login");
            }
            else
            {
                //  User is null error 
                return Page();
            }
        }
    }
}
