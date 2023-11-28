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
        public IActionResult OnPostPrevious()
        {
            CurrentWeek = CurrentWeek.AddDays(-7);
            return RedirectToPage();
        }

        public IActionResult OnPostNext()
        {
            CurrentWeek = CurrentWeek.AddDays(7);
            return RedirectToPage();
        }
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
            var userIdClaim = User.FindFirst("EmployeeId");
           
            
                var userIdValue = userIdClaim.Value;
                int.TryParse(userIdValue, out int employeeID);
                
                    ScheduleManager scheduleManager = new ScheduleManager(new ScheduleRepository());

                    schedules = scheduleManager.GetScheduleByID(employeeID);

            DateTime endOfTheWeek = currentDay.AddDays(6);

            // Assuming you have a class named Schedule
            result.Append($"<div class='title-holder' style='justify-content: center; align-items: center; text-align:center;'><h1 class='card-title'>{currentDay.ToShortDateString()}-{endOfTheWeek.ToShortDateString()}</h1></div>");

            result.Append("<div class='col-md-0' style='margin-bottom:0px;margin-left:0px; margin-right:0px; padding-left:0px;padding-right:0px;justify-content: center; align-items: center;'></div>"); // Offset for the first column

            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);

                result.Append("<div class='col mb-5 gap-0' style='margin-bottom:-20px; padding-botton:-20px;justify-content: center; align-items: center;'>");

                // Create morning shift card
                Schedule morningSchedule = schedules.FirstOrDefault(s => s.Date == currentDay.Date && s.Shift == "MorningShift");
                result.Append($"<div class=''><div class=''><p class='card-title'>{DaysOfWeek[i]}</p></div></div>");
                result.Append($"<div class='card' style='height:200px;'><div class='card-body'><h5 class='card-title'>Morning Shift</h5>");

                if (morningSchedule != null)
                {
                    result.Append($"<p class='card-text'>Scheduled: {morningSchedule.Date.ToShortDateString()}</p>");
                    
                }
                result.Append("</div></div>");
                // Create afternoon shift card
                Schedule afternoonSchedule = schedules.FirstOrDefault(s => s.Date == currentDay.Date && s.Shift == "AfternoonShift");
                result.Append($"<div class='card'><div class='card-body'style='height:200px;'><h5 class='card-title'>Afternoon Shift</h5>");
            
                if (afternoonSchedule != null)
                {
                    result.Append($"<p class='card-text'>Scheduled: {afternoonSchedule.Date.ToShortDateString()}</p>");
                }
                result.Append("</div></div>");
                // Create evening shift card
                Schedule eveningSchedule = schedules.FirstOrDefault(s => s.Date == currentDay.Date && s.Shift == "EveningShift");
                result.Append($"<div class='card'><div class='card-body'style='height:200px;'><h5 class='card-title'>Evening Shift</h5>");
              
                if (eveningSchedule != null)
                {
                    result.Append($"<p class='card-text'>Scheduled: {eveningSchedule.Date.ToShortDateString()}</p>");
                }
                result.Append("</div></div>");
                result.Append("</div>");

            }
            

            return result.ToString();
        }


    }
    }

