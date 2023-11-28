using Logic.DTO;
using Logic.Entities;
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
        bool CreateEmployee(EmployeeDTO employeeDTO, UserDTO userDTO, ContractDTO contractDTO, AddressDTO addressDTO, PartnerDTO partnerDTO, RoleDTO roleDTO);
        bool UpdateEmployee(EmployeeDTO employeeDTO);
        User GetCurrentUserByUsername(string userEmail);
        bool UpdateEmployeeLoginDetails(UserDTO userDTO);
        bool UpdateEmployeeContract(ContractDTO contractDTO);
        bool UpdateEmployeeAddress(AddressDTO addressDTO);
        bool UpdateEmployeePartner(PartnerDTO partnerDTO);
        bool DeleteEmployee(EmployeeDTO employeeDTO);
        public bool UpdateAllTables(EmployeeDTO employeeDTO, UserDTO userDTO, ContractDTO contractDTO, PartnerDTO partnerDTO, AddressDTO addressDTO);
        public DataTable LoadEmployees();


    }
}
