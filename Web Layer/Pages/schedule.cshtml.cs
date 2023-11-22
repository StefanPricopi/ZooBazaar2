using DataAccess;
using Logic.Entities;
using Logic.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    [Authorize(Policy = "MustBeEmployee")]
    public class scheduleModel : PageModel
    {

        public List<Schedule> schedules = new List<Schedule>();

        public IActionResult OnGet()
        {
            try
            {
                var userIdClaim = User.FindFirst("EmployeeId");
                if (userIdClaim != null)
                {
                    var userIdValue = userIdClaim.Value;
                    if (int.TryParse(userIdValue, out int employeeID))
                    {
                        ScheduleManager scheduleManager = new ScheduleManager(new ScheduleRepository());

                        schedules = scheduleManager.GetScheduleByID(employeeID);
                        if (schedules != null)
                        {
                            return Page();
                        }
                    }
                }
                return Redirect("Index");
            }
            catch (Exception ex)
            {

                return Redirect($"/Index?message={ex.Message}");
            }
        }
    }
}
