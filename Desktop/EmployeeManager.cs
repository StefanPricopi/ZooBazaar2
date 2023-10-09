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
                if (employee.Name == edittedEmployee.Name)
                {
                    employee.Email = edittedEmployee.Email;
                    employee.Password = edittedEmployee.Password;
                    employee.Username = edittedEmployee.Username;
                    break;
                }
            }
        }

        //public List<Animal> GetAnimalsBySpecies(string species)
        //{
        //    List<Animal> result = new List<Animal>();
        //    foreach (Animal animal in animals)
        //    {
        //        if (animal.Species == species)
        //        {
        //            result.Add(animal);
        //        }
        //    }
        //    return result;
        //}

        //public Animal GetAnimalByName(string name)
        //{
        //    foreach (Animal animal in animals)
        //    {
        //        if (animal.Name == name)
        //        {
        //            return animal;
        //        }
        //    }
        //    return null;
        //}

        public string GetEmployeeListAsString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Employee employee in employees)
            {
                sb.AppendLine($"Name: {employee.Name}, Email: {employee.Email}, Username: {employee.Username}");
            }

            return sb.ToString();
        }
    }
}
