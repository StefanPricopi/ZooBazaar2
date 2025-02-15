﻿using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Employee : User
    {
        private int employeeID;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private DateTime dateOfBirth;
        private int bSN;
        public int RoleID { get; set; }

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; } 
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public int BSN
        {
            get { return bSN; }
            set { bSN = value; }
        }
       

        public Employee(string firstName, string lastName, string phoneNumber, DateTime dateOfBirth, int bSN, int roleID) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOfBirth;
            this.bSN = bSN;
            this.RoleID = roleID;
            
        }
        public Employee()
        {


        }
        public EmployeeDTO EmployeeToEmployeeDTO()
        {
            return new EmployeeDTO()
            {
                FirstName = this.firstName,
                LastName = this.lastName,
                PhoneNumber = this.phoneNumber,
                DateOfBirth = this.dateOfBirth,
                BSN = this.bSN,
                RoleID = this.RoleID
            };

        }

    }
}
