using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    [Authorize(Policy = "MustBeEmployee")]
    public class scheduleModel : PageModel
    {
       
        public void OnGet()
        {
        }
    }
}
