using Logic.DTO;
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
    public class EmployeeManager
    {

        private readonly IEmployee employee;

        
        public EmployeeManager(IEmployee employee)
        {
            this.employee = employee ?? throw new ArgumentNullException(nameof(employee));
        }
        public EmployeeManager() { }
        public bool CreateEmployee(EmployeeDTO employeeDTO,UserDTO userDTO,ContractDTO contractDTO,AddressDTO addressDTO, PartnerDTO partnerDTO, RoleDTO roleDTO)
        {
            return employee.CreateEmployee(employeeDTO,userDTO,contractDTO,addressDTO,partnerDTO,roleDTO);
        }
        public bool UpdateEmployee(EmployeeDTO employeeDTO)
        {
            return employee.UpdateEmployee(employeeDTO);
        }
        public bool UpdateEmployeeLoginDetails(UserDTO userDTO)
        {
            return employee.UpdateEmployeeLoginDetails(userDTO);
        }
        public bool UpdateEmployeeContract(ContractDTO contractDTO)
        {
            return employee.UpdateEmployeeContract(contractDTO);
        }
        public bool UpdateEmployeeAddress(AddressDTO addressDTO)
        {
            return employee.UpdateEmployeeAddress(addressDTO);
        }
        public bool UpdateEmployeePartner(PartnerDTO partnerDTO)
        {
            return employee.UpdateEmployeePartner(partnerDTO);
        }
        public bool DeleteEmployee(EmployeeDTO employeeDTO)
        {
            return employee.DeleteEmployee(employeeDTO);
        }
        public (DataTable,DataTable,DataTable,DataTable,DataTable) LoadEmployees()
        {
            return employee.LoadEmployees();
        }
    }
}
