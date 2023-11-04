using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Logic.Managers
{
    public class UserManager
    {
        private readonly IUser user;

        public UserManager() { }
        public UserManager(IUser user)
        {
            this.user = user ?? throw new ArgumentNullException(nameof(user));
        }
        public bool InsertDummyUser(UserDTO userDTO)
        {
            // Call the repository method to insert the dummy user
            return user.InsertDummyUser(userDTO);
        }

        public User Login(string username, string password)
        {
            User currentUser = user.GetCurrentUserByUsername(username); // Call the method via IUser

            if (username == currentUser.Username && currentUser.Password == password)
            {
                return currentUser;
            }

            return null;
        }
        public string RetrievePositionInformation(string username)
        {
            return user.RetrievePositionInformation(username);
        }
       

        public bool CreateAccount(UserDTO userDTO)
        {
            return user.CreateAccount(userDTO);
        }

        public List<User> GetAllAccounts()
        {
            List<User> users = new List<User>();
            foreach (UserDTO userDTO in user.GetAllAccounts())
            {
                users.Add(new User(userDTO.UserID,userDTO.Username, userDTO.Password, userDTO.Email, userDTO.Salt));
            }
            return users;
        }

        public bool UpdateAccount(UserDTO userDTO)
        {
            return user.UpdateAccount(userDTO);
        }
        public static string HashedPassword(string password)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedPasswordBytes = hash.ComputeHash(passwordBytes);
                return Convert.ToHexString(hashedPasswordBytes);
            }
        }
    }
}
