using Logic.Entities;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Managers
{
    public class ScheduleManager
    {
        private readonly ISchedule schedule;

        public ScheduleManager(ISchedule location)
        {
        
            this.schedule = location ?? throw new ArgumentNullException(nameof(location));
          
        }
        public void RemoveAvailableEmployee(DateTime date, string shift, int employeeID)
        {
            schedule.RemoveAvailableEmployee(date, shift, employeeID);
        }

        public List<KeyValuePair<int, string>> GetEmployeeListByDateAndShift(DateTime date, string shift)
        {
            return schedule.GetEmployeeListByDateAndShift(date, shift);
        }
        public List<KeyValuePair<int, string>> GetEmployeeListExcludingDateAndShift(DateTime date, string shift)
        {
            return schedule.GetEmployeeListExcludingDateAndShift(date, shift);
        }
        public List<KeyValuePair<int, string>> GetEmployeeList()
        {
            return schedule.GetEmployeeList();
        }
        public bool DeleteShift(int id)
        {
           return schedule.DeleteShift(id);
        }
        public List<SelectedPanelData> GetSavedPanelsFromDatabase(int employeeID)
        {
            return schedule.GetSavedPanelsFromDatabase(employeeID);
        }
       public void AddAvailableEmployees(DateTime Date, string shift, int employeeID)
        {
            schedule.AddAvailableEmployees(Date, shift, employeeID);
        }
        public bool UpdateShiftCapacity(DateTime Date,string shift,int NeededCapacity)
        {
            return schedule.UpdateShiftCapacity(Date, shift, NeededCapacity);
        }
        public void CreateShift(int employeeID, DateTime Date, string Shift, int areaID, int Needed, int Filled)
        {
            schedule.CreateShift(employeeID, Date, Shift, areaID, Needed, Filled);
        }
        public bool CreateShiftCapacity(DateTime date, string shift, int Needed, int Filled)
        {
            return schedule.CreateShiftCapacity( date, shift,  Needed,  Filled);
        }
        public bool UpdateShift(Schedule selected)
        {
            return schedule.UpdateShift(selected);
        }
        public DataTable LoadSchedules(DateTime time)
        {
            return schedule.LoadSchedules(time);
        }
        public List<Schedule> PopulateSchedule(DateTime selectedDate)
        {
            return schedule.PopulateSchedule(selectedDate);
        }
        public string GetEmployeeID(string selectedEmployee)
        {
            int startIndex = selectedEmployee.IndexOf('[') + 1;
            int endIndex = selectedEmployee.IndexOf(',');

            // Extract the ID substring
            string employeeID = selectedEmployee.Substring(startIndex, endIndex - startIndex);

            employeeID = employeeID.Trim();

            return employeeID;
        }
        public List<Schedule> GetScheduleByID(int id) 
        { return schedule.GetScheduleByID(id); }
        public void PerformScheduling()
        {
            try
            {
                // Step 1: Retrieve Available Employees
                //  List<Employee> availableEmployees = schedule.RetrieveAvailableEmployees();

                // Step 2: Count Submissions and Identify the Day with the Least Employees
                Dictionary<Tuple<DateTime, string>, List<int>> dayWithLeastEmployees = schedule.IdentifyDayWithLeastEmployees();
                List<Tuple<DateTime, string>> dateShiftUserCounts = dayWithLeastEmployees.Keys.ToList();
             //   foreach (List<int> employeeList in dayWithLeastEmployees.Values)
             //   {
                    // Now you can work with each employeeList
                //    foreach (int employeeId in employeeList)
               //     {
               //         Console.WriteLine(employeeId);
               //     }

                    // If you only want the first list, you can break out of the loop
              //      break;
               // }
                // Step 3: Retrieve Managers
                List<Employee> managers = schedule.RetrieveManagers();
                List<Employee> employees = schedule.RetrieveEmployeeFulltime();
                // Step 4: Assign Managers to Shifts
                schedule.AssignManagersToShifts(managers, dateShiftUserCounts);
                schedule.AssignFullTimeEmployeesToShifts(employees, dateShiftUserCounts);
                List<Employee> availableEmployees = schedule.RetrieveParttimers();
                DateTime currentDate = DateTime.Today;
                int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)currentDate.DayOfWeek + 7) % 7;
                DateTime nextSunday = currentDate.AddDays(daysUntilSunday);

                // Calculate the end date (Saturday of the same week)
                DateTime endDate = nextSunday.AddDays(6);
                bool allShiftsFull = schedule.AreAllShiftsFilled(nextSunday, endDate);
                if (!allShiftsFull)
                {
                    // Assign part-time employees to shifts
                    schedule.AssignPartTimeEmployeesToShifts(availableEmployees, dateShiftUserCounts);
                }
                // Step 5: Retrieve Full-Time Employees
                //   List<Employee> fullTimeEmployees = schedule.RetrieveFullTimeEmployees();

                // Step 6: Assign Full-Time Employees to Shifts
                /// schedule.AssignEmployeesToShifts(fullTimeEmployees, dayWithLeastEmployees);

                // Step 7: Check and Assign Part-Time Employees
                //    List<Employee> partTimeEmployees = schedule.RetrievePartTimeEmployees();
                // schedule.AssignEmployeesToShifts(partTimeEmployees, dayWithLeastEmployees);

                // Step 8: Check and Assign Zero Hour Employees
                //    List<Employee> zeroHourEmployees = schedule.RetrieveZeroHourEmployees();
                // schedule.AssignEmployeesToShifts(zeroHourEmployees, dayWithLeastEmployees);

                // Final steps for shift assignment (if any)
                // ...

                Console.WriteLine("Scheduling completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
    
