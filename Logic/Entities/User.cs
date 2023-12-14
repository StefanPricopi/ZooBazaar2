using Logic.DTO;
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
        private string rfid;

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

        public string Rfid
        {
            get => rfid;
            set => rfid = value;
        }

        public User()
        {
            // Default constructor
        }

        public User(int userID, string username, string password, string email, string salt, string rfid)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.email = email;
            this.salt = salt;
            this.rfid = rfid;
        }
        public User(UserDTO userDTO)
        {
            this.userID = userDTO.UserID;
            this.username = userDTO.Username;
            this.password = userDTO.Password;
            this.email = userDTO.Email;
            this.salt = userDTO.Salt;
            this.rfid = userDTO.Rfid;
        }

        public UserDTO UserToUserDTO()
        {
            return new UserDTO()
            {
                UserID = this.userID,
                Username = this.Username,
                Password = this.Password,
                Email = this.Email,
                Salt = this.Salt,
                Rfid = this.Rfid
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
                Salt = userDTO.Salt,
                Rfid = userDTO.Rfid
            };
        }
    }
}
