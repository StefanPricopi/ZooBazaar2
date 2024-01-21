using Logic.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Logic.Managers;
using Logic.Interfaces;
using Logic.DTO;

namespace Web_Layer.Pages
{
    public class IndexModel : PageModel
    {
        public AnnouncementDTO announce { get; set; }
        private readonly ILogger<IndexModel> _logger;
        private AnnouncementManager manager;
        public IndexModel(ILogger<IndexModel> logger, IAnnouncements announcements)
        {
            _logger = logger;
            manager = new AnnouncementManager(announcements);
        }

        public void OnGet()
        {
            announce = manager.GetTheLastAnnouncementForAll();
        }
    }
}