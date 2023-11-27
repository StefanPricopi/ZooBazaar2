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
        public List<KeyValuePair<int, string>> GetEmployeeList();
        public void CreateShift(int employeeID, DateTime Date, string Shift);
        public List<Schedule> PopulateSchedule(DateTime selectedDate);
        public List<Schedule> GetScheduleByID(int id);
        public DataTable LoadSchedules(DateTime time);
        public bool DeleteShift(int id);

        public bool UpdateShift(Schedule schedule);
    }
}
