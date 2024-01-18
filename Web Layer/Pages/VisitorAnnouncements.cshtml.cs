using DataAccess;
using Logic.DTO;
using Logic.Entities;
using Logic.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    public class VisitorAnnouncementsModel : PageModel
    {
    
        public List<Announcement> Announcements { get; set; }

        public void OnGet()
        {
            try
            {
                var roleIdClaim = User.FindFirst("RoleID");

                if (roleIdClaim != null)
                {
                    var userIdValue = roleIdClaim.Value;

                    if (int.TryParse(userIdValue, out int roleID))
                    {
                        AnnouncementManager announcementManager = new AnnouncementManager(new AnnouncementsRepository());

                        // Assign the result of GetAnnouncementsByRole to the Announcements property
                        Announcements = announcementManager.GetAnnouncementsByRole(roleID);
                    }
                }
            }
            catch (Exception ex) { }
            
        }
    }
}
