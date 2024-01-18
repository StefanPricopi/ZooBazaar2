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
        public List<KeyValuePair<int, string>> GetEmployeeListByDateAndShift(DateTime date, string shift);
        public List<SelectedPanelData> GetSavedPanelsFromDatabase(int employeeID);
        public void AddAvailableEmployees(DateTime date, string shift, int employeeID);
        public bool UpdateShiftCapacity(DateTime Date,string shift,int NeededCapacity);
        public List<KeyValuePair<int, string>> GetEmployeeList();
        public void CreateShift(int employeeID, DateTime Date, string Shift, int areaID, int Needed, int Filled);
        public List<Schedule> PopulateSchedule(DateTime selectedDate);
        public List<Schedule> GetScheduleByID(int id);
        public DataTable LoadSchedules(DateTime time);
        public bool CreateShiftCapacity(DateTime date, string shift, int Needed, int Filled);
        public bool DeleteShift(int id);

        public bool UpdateShift(Schedule schedule);
    }
}
