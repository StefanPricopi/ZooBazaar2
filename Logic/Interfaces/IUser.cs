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
        public bool CreateAccount(UserDTO accountDTO);
        public List<UserDTO> GetAllAccounts();
        public bool UpdateAccount(UserDTO accountDTO);
        User GetCurrentUserByEmail(string userEmail); 
    }
}
