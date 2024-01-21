using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Logic.Entities;
using Logic.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Web_Layer.Pages
{
    [Authorize(Policy = "MustBeEmployee")]
    public class scheduleModel : PageModel
    {
        public static DateTime CurrentWeek = DateTime.Now;
        public DateTime currentDay = CurrentWeek.AddDays(-(int)CurrentWeek.DayOfWeek);
        public static string[] DaysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        public List<Schedule> schedules = new List<Schedule>();
        public IActionResult OnPostForm()
        {
            try
            {
                ScheduleManager scheduleManager = new ScheduleManager(new ScheduleRepository());
                // Access the selected panels from the model binding
                var selectedPanels = HttpContext.Request.Form["selectedPanels"];
                var selectedPanelsList = JsonConvert.DeserializeObject<List<SelectedPanelData>>(selectedPanels);
                var userIdClaim = User.FindFirst("EmployeeId");
                var userIdValue = userIdClaim.Value;
                int.TryParse(userIdValue, out int employeeID);
                // Split the PanelId into Date and ShiftType
                foreach (var panel in selectedPanelsList)
                {
                    var panelIdParts = panel.PanelId.Split('-');

                    if (panelIdParts.Length == 2)
                    {
                        panel.Date = panelIdParts[0];
                        panel.ShiftType = panelIdParts[1];
                        scheduleManager.RemoveAvailableEmployee(Convert.ToDateTime(panel.Date), panel.ShiftType, employeeID);
                    }
                }


                return RedirectToPage();
            }
            catch (Exception ex)
            {
                return Redirect($"/Index?message={ex.Message}");
            }
        }
        public IActionResult OnPost()
        {
            try
            {
                ScheduleManager scheduleManager = new ScheduleManager(new ScheduleRepository());
                // Access the selected panels from the model binding
                var selectedPanels = HttpContext.Request.Form["selectedPanels"];
                var selectedPanelsList = JsonConvert.DeserializeObject<List<SelectedPanelData>>(selectedPanels);
                var userIdClaim = User.FindFirst("EmployeeId");
                var userIdValue = userIdClaim.Value;
                int.TryParse(userIdValue, out int employeeID);
                // Split the PanelId into Date and ShiftType
                foreach (var panel in selectedPanelsList)
                {
                    var panelIdParts = panel.PanelId.Split('-');

                    if (panelIdParts.Length == 2)
                    {
                        panel.Date = panelIdParts[0];
                        panel.ShiftType = panelIdParts[1];
                        scheduleManager.AddAvailableEmployees(Convert.ToDateTime(panel.Date),  panel.ShiftType,  employeeID);
                    }
                }


                return RedirectToPage();
            }
            catch (Exception ex)
            {
                return Redirect($"/Index?message={ex.Message}");
            }
        }


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

                        // Pass employeeID to the Razor view
                        ViewData["EmployeeID"] = employeeID;

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

    DateTime endOfTheWeek = currentDay.AddDays(6);

    // Assuming you have a class named Schedule
    result.Append($"<div class='title-holder' style='justify-content: center; align-items: center; text-align:center;'><h1 class='card-title'>{currentDay.ToShortDateString()}-{endOfTheWeek.ToShortDateString()}</h1></div>");

    result.Append("<div class='col-md-0' style='margin-bottom:0px;margin-left:0px; margin-right:0px; padding-left:0px;padding-right:0px;justify-content: center; align-items: center;'></div>"); // Offset for the first column

    result.Append("<div class='row' style='justify-content: center; align-items: center;'>");

    for (int i = 0; i < 7; i++)
    {
        DateTime currentDay = startDate.AddDays(i);

        result.Append("<div class='col mb-5 gap-0' style='margin-bottom:-20px; padding-botton:-20px;justify-content: center; align-items: center;'>");

        // Create morning shift card
        CreateShiftCard(result, currentDay, "MorningShift", i);

        // Create afternoon shift card
        CreateShiftCard(result, currentDay, "AfternoonShift", i);

        // Create evening shift card
        CreateShiftCard(result, currentDay, "EveningShift", i);

        // Close the col div
        result.Append("</div>");
    }

    // Close the row div
    result.Append("</div>");
            return result.ToString();
}

        private void CreateShiftCard(System.Text.StringBuilder result, DateTime currentDay, string shiftType, int i)
        {
            Schedule schedule = schedules.FirstOrDefault(s => s.Date == currentDay.Date && s.Shift == shiftType);
            ScheduleManager scheduleManager = new ScheduleManager(new ScheduleRepository());

            // Fetch selected panels from the database
            var userIdClaim = User.FindFirst("EmployeeId");
            var userIdValue = userIdClaim.Value;
            int.TryParse(userIdValue, out int employeeID);
            var savedPanels = scheduleManager.GetSavedPanelsFromDatabase(employeeID);

            // Check if there is a saved panel for the current shift type and date
            // Check if there is a saved panel for the current shift type and date
            var panelExists = savedPanels.Any(panel =>
            {
                DateTime panelDate;
                if (DateTime.TryParse(panel.Date, out panelDate))
                {
                    return panel.ShiftType == shiftType && panelDate.Date == currentDay.Date;
                }
                return false;
            });


            // Determine the background color
            var backgroundColor = panelExists ? "red" : "white";

            result.Append($"<div class=''><div class=''><p class='card-title'>{DaysOfWeek[i]}</p></div></div>");
            result.Append($"<div class='card' style='height:200px; background-color: {backgroundColor}'>");
            result.Append($"<button type='button' onclick='selectPanel(\"{currentDay.Date}-{shiftType}\")'>Select</button>");
            result.Append($"<div panel-id='{currentDay.Date}-{shiftType}' class='card-body'><h5 class='card-title'>{shiftType}</h5>");

            if (schedule != null)
            {
                result.Append($"<p class='card-text'>Scheduled In Area: {schedule.AreaName}</p>");
            }

            result.Append("</div></div>");
        }


    }
}
