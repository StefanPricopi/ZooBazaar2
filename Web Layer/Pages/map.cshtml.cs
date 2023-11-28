using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    public class mapModel : PageModel
    {
        public string Img { get; set; } = "/img/map.png";

        public void OnGet()
        {
        }

        public IActionResult OnPostEN()
        {
            Img = "/img/mapEN.png";
            return Page();
        }

        public IActionResult OnPostNL()
        {
            Img = "/img/map.png";
            return Page();
        }
    }
}
