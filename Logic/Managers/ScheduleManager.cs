﻿using Logic.Entities;
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
        public List<KeyValuePair<int, string>> GetEmployeeList()
        {
            return schedule.GetEmployeeList();
        }
        public bool DeleteShift(int id)
        {
           return schedule.DeleteShift(id);
        }
        public void CreateShift(int employeeID, DateTime Date, string Shift, int areaID)
        {
            schedule.CreateShift(employeeID, Date, Shift, areaID);
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
    }
}
