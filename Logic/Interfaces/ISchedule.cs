using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface ISchedule
    {
        public List<KeyValuePair<int, string>> GetEmployeeListExcludingDateAndShift(DateTime date, string shift);
        public List<KeyValuePair<int, string>> GetEmployeeListByDateAndShift(DateTime date, string shift);
        public List<SelectedPanelData> GetSavedPanelsFromDatabase(int employeeID);
        public void AddAvailableEmployees(DateTime date, string shift, int employeeID);
        public void RemoveAvailableEmployee(DateTime date, string shift, int employeeID);
        public bool UpdateShiftCapacity(DateTime Date,string shift,int NeededCapacity);
        public List<KeyValuePair<int, string>> GetEmployeeList();
        public void CreateShift(int employeeID, DateTime Date, string Shift, int areaID, int Needed, int Filled);
        public List<Schedule> PopulateSchedule(DateTime selectedDate);
        public List<Schedule> GetScheduleByID(int id);
        public DataTable LoadSchedules(DateTime time);
        public bool CreateShiftCapacity(DateTime date, string shift, int Needed, int Filled);
        public bool DeleteShift(int id);

        public bool UpdateShift(Schedule schedule);

        List<Employee> RetrieveAvailableEmployees();
        public Dictionary<Tuple<DateTime, string>, List<int>> IdentifyDayWithLeastEmployees();
        List<Employee> RetrieveManagers();
        void AssignManagersToShifts(List<Employee> managers, List<Tuple<DateTime, string>> dateShiftUserCounts);
        List<Employee> RetrieveFullTimeEmployees();
        public bool AreAllShiftsFilled(DateTime startDate, DateTime endDate);
        public List<Employee> RetrieveParttimers();
        public void AssignPartTimeEmployeesToShifts(List<Employee> partTimeEmployees, List<Tuple<DateTime, string>> dateShiftUserCounts);
        List<Employee> RetrievePartTimeEmployees();
        List<Employee> RetrieveZeroHourEmployees();
        public List<Employee> RetrieveEmployeeFulltime();
        public void AssignFullTimeEmployeesToShifts(List<Employee> fullTimeEmployees, List<Tuple<DateTime, string>> dateShiftUserCounts);
        void AssignEmployeesToShifts(List<Employee> employees, DateTime targetDate);
    }
}
