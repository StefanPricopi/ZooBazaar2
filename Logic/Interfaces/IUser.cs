using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Entities;

namespace Logic.Interfaces
{
    public interface IUser
    {
        bool CreateAccount(UserDTO accountDTO);
        List<UserDTO> GetAllAccounts();
        bool UpdateAccount(UserDTO accountDTO);
        User GetCurrentUserByUsername(string userEmail);
        bool InsertDummyUser(UserDTO userDTO);
        User Login(string email, string password);
    }
}
