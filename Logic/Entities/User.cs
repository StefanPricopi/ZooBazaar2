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
        private string email;
        private string password;
        private string name;
        private int clearanceLevel;

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

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int ClearanceLevel
        {
            get => clearanceLevel;
            set => clearanceLevel = value;
        }

        public User()
        {
            // Default constructor
        }

        public User(string email, string password, string name, int clearanceLevel)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.clearanceLevel = clearanceLevel;
        }
        public User(UserDTO userDTO)
        {
            this.email = userDTO.Email;
            this.password = userDTO.Password;
            this.name = userDTO.Name;
            this.clearanceLevel = userDTO.ClearanceLevel;
        }

        public UserDTO UserToUserDTO()
        {
            return new UserDTO()
            {
                Email = this.Email,
                Password = this.Password,
                Name = this.Name,
                ClearanceLevel = this.ClearanceLevel
            };
        }

        public static User UserDTOToUser(UserDTO userDTO)
        {
            return new User()
            {
                Email = userDTO.Email,
                Name = userDTO.Name,
                Password = userDTO.Password,
                ClearanceLevel = userDTO.ClearanceLevel
            };
        }
    }
}
