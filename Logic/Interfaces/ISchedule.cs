using Logic.Entities;
using System;
using System.Collections.Generic;
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
    }
}
