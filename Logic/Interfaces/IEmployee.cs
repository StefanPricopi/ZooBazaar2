using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IEmployee
    {
        bool CreateEmployee(EmployeeDTO employeeDTO, UserDTO userDTO);
        bool UpdateEmployee(EmployeeDTO employeeDTO);
        bool UpdateEmployeeLoginDetails(UserDTO userDTO);
        bool DeleteEmployee(EmployeeDTO employeeDTO);
        (DataTable, DataTable) LoadEmployees();
        


    }
}
