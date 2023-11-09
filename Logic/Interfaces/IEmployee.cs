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
        bool CreateEmployee(EmployeeDTO employeeDTO, UserDTO userDTO, ContractDTO contractDTO, AddressDTO addressDTO, PartnerDTO partnerDTO, RoleDTO roleDTO);
        bool UpdateEmployee(EmployeeDTO employeeDTO);
        bool UpdateEmployeeLoginDetails(UserDTO userDTO);
        bool UpdateEmployeeContract(ContractDTO contractDTO);
        bool UpdateEmployeeAddress(AddressDTO addressDTO);
        bool UpdateEmployeePartner(PartnerDTO partnerDTO);
        bool DeleteEmployee(EmployeeDTO employeeDTO);
        (DataTable, DataTable, DataTable, DataTable, DataTable) LoadEmployees();


    }
}
