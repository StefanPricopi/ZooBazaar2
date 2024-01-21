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
        public void UpdateNewPassword(string password, string token);
        public void AddResetToken(string token, int UserID);
        public (string, bool) RetrieveResetTokenFromToken(string token);
        bool CreateAccount(UserDTO accountDTO);
        List<UserDTO> GetAllAccounts();
        bool UpdateAccount(UserDTO accountDTO);
        User GetCurrentUserByUsername(string userEmail);
        bool InsertDummyUser(UserDTO userDTO);
        public bool CreateVisitor(UserDTO userDTO);
        User Login(string email, string password);
      
        UserDTO FindUserByProvidedUsername(string userEmail);
        public string RetrievePositionInformation(string username);
        public int GetEmpIDbyUserId(int id);
        public void ChangePassword(int userId, string oldPassword, string newPassword, string confirmNewPassword);
        public string GetHashedPassword(int userId, string password);
        public string GetUserPassword(int userId);
        public UserDTO LoginByRfid(string rfid);
    }
}
