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
        public static DateTime CurrentWeek = DateTime.Now;
       public DateTime currentDay = CurrentWeek.AddDays(-(int)CurrentWeek.DayOfWeek);
        public static string[] DaysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
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
        public string GenerateShifts(DateTime startDate)
        {
            var result = new System.Text.StringBuilder();

            result.Append("<div class='col-md-0' style'margin-left:0px; margin-right:0px; padding-left:0px;padding-right:0px;justify-content: center; align-items: center;'></div>"); // Offset for the first column

            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);

                result.Append("<div class='col mb-5 gap-0' style='justify-content: center; align-items: center;'>");

                // Create morning shift card
                result.Append($"<div class='card'><div class='card-body'><h5 class='card-title'>Morning Shift: {DaysOfWeek[i]}</h5>");
                result.Append($"<p class='card-text'>{currentDay.ToShortDateString()}</p></div></div>");

                // Create afternoon shift card
                result.Append($"<div class='card'><div class='card-body'><h5 class='card-title'>Afternoon Shift: {DaysOfWeek[i]}</h5>");
                result.Append($"<p class='card-text'>{currentDay.ToShortDateString()}</p></div></div>");

                // Create evening shift card
                result.Append($"<div class='card'><div class='card-body'><h5 class='card-title'>Evening Shift: {DaysOfWeek[i]}</h5>");
                result.Append($"<p class='card-text'>{currentDay.ToShortDateString()}</p></div></div>");

                result.Append("</div>");
            }

            return result.ToString();
        }
    }
}
