﻿using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic.DTO
{
    public class UserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public int ClearanceLevel { get; set; }

        public UserDTO() { }
    }
}
