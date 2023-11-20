using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public string Shift { get; set; }
    }
}
