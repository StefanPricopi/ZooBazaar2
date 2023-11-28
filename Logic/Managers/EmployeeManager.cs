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
        public bool IsLoginValid(string username, string password)
        {

            User Obj = employee.GetCurrentUserByUsername(username);
            if (Obj != null)
            {

                var userhashedpass = UserManager.HashedPassword($"{password}{Obj.Salt.Trim()}");
                Console.WriteLine(Obj.Salt);
                if (password == Obj.Password)
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
        public bool UpdateAllTables(EmployeeDTO employeeDTO, UserDTO userDTO, ContractDTO contractDTO, PartnerDTO partnerDTO, AddressDTO addressDTO)
        {
            string password = userDTO.Password;
            string username = userDTO.Username;
            if (!IsLoginValid(username, password))
            {
                DateTime dateTime = DateTime.Now;
                userDTO.Salt = dateTime.ToString();
                var hashedPW = UserManager.HashedPassword($"{userDTO.Password}{userDTO.Salt.Trim()}");
                userDTO.Password = hashedPW;
            }
            else
            {
                User Obj = employee.GetCurrentUserByUsername(username);
                userDTO.Salt = Obj.Salt;
            }
            
            return employee.UpdateAllTables(employeeDTO,userDTO,contractDTO,partnerDTO,addressDTO);
        }
        public bool DeleteEmployee(EmployeeDTO employeeDTO)
        {
            return employee.DeleteEmployee(employeeDTO);
        }
        public DataTable LoadEmployees()
        {
            return employee.LoadEmployees();
        }
    }
}
