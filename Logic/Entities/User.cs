﻿using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class User
    {
        private int userID;
        private string username;
        private string password;
        private string email;
        private string salt;

        public int UserID
        {
            get => userID;
            set => userID = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }



        public string Salt
        {
            get => salt;
            set => salt = value;
        }

        public User()
        {
            // Default constructor
        }

        public User(int userID, string username, string password, string email, string salt)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.email = email;
            this.salt = salt;
        }
        public User(UserDTO userDTO)
        {
            this.userID = userDTO.UserID;
            this.username = userDTO.Username;
            this.password = userDTO.Password;
            this.email = userDTO.Email;
            this.salt = userDTO.Salt;
        }

        public UserDTO UserToUserDTO()
        {
            return new UserDTO()
            {
                UserID = this.userID,
                Username = this.Username,
                Password = this.Password,
                Email = this.Email,
                Salt = this.Salt
            };
        }

        public static User UserDTOToUser(UserDTO userDTO)
        {
            return new User()
            {
                UserID = userDTO.UserID,
                Username = userDTO.Username,
                Password = userDTO.Password,
                Email = userDTO.Email,
                Salt = userDTO.Salt
            };
        }
    }
}
