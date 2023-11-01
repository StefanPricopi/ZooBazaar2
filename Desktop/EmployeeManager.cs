using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employees
{
    public class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void EditEmployee(Employee edittedEmployee)
        {
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == edittedEmployee.FirstName & employee.LastName == edittedEmployee.LastName)
                {
                    employee.PhoneNumber = edittedEmployee.PhoneNumber;
                    employee.DateOfBirth = edittedEmployee.DateOfBirth;
                    employee.BSN = edittedEmployee.BSN;
                    employee.Position = edittedEmployee.Position;
                    break;
                }
            }
        }

        public string GetEmployeeListAsString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Employee employee in employees)
            {
                sb.AppendLine($"Name: {employee.FirstName} {employee.LastName}, BSN: {employee.BSN}");
            }

            return sb.ToString();
        }
    }
}
