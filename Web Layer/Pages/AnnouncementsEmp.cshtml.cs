using DataAccess;
using Logic.DTO;
using Logic.Entities;
using Logic.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    [Authorize(Policy = "MustBeEmployee")]
    public class AnnouncementsEmpModel : PageModel
    {
        public List<Announcement> Announcements { get; set; }
        public EmployeeDTO e { get; set; }

        public void OnGet()
        {
            try
            {
                var roleIdClaim = User.FindFirst("EmployeeId");

                if (roleIdClaim != null)
                {
                    var userIdValue = roleIdClaim.Value;

                    if (int.TryParse(userIdValue, out int roleID))
                    {
                        EmployeeManager employeeManager = new EmployeeManager(new EmployeeRepository());
                        AnnouncementManager announcementManager = new AnnouncementManager(new AnnouncementsRepository());

                        // Ensure that e is initialized before using it
                        e = employeeManager.GetEmployeeById(roleID);

                        if (e != null)
                        {
                            // Assign the result of GetAnnouncementsByRole to the Announcements property
                            Announcements = announcementManager.GetAnnouncementsByRole(e.RoleID);
                        }
                        else
                        {
                            // Handle the case where e is null (employee not found)
                            // You may want to log this or perform other error handling
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }
}
