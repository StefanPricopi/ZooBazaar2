using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using System;
using System.Windows;
using System.Collections.Generic;

namespace Logic.Managers
{
    public class UserManager
    {
        private readonly IUser user;
        public bool InsertDummyUser(UserDTO userDTO)
        {
            // Call the repository method to insert the dummy user
            return user.InsertDummyUser(userDTO);
        }

        public User Login(string username, string password)
        {
            User currentUser = user.GetCurrentUserByEmail(username); // Call the method via IUser

            if (username == currentUser.Name && currentUser.Password == password)
            {
                return currentUser;
            }

            return null;
        }
      
        public UserManager(IUser user)
        {
            this.user = user ?? throw new ArgumentNullException(nameof(user));
        }

        public UserManager() { }

        public bool CreateAccount(UserDTO userDTO)
        {
            return user.CreateAccount(userDTO);
        }

        public List<User> GetAllAccounts()
        {
            List<User> users = new List<User>();
            foreach (UserDTO userDTO in user.GetAllAccounts())
            {
                users.Add(new User(userDTO.Email, userDTO.Password, userDTO.Name, userDTO.ClearanceLevel));
            }
            return users;
        }

        public bool UpdateAccount(UserDTO userDTO)
        {
            return user.UpdateAccount(userDTO);
        }
    }
}
