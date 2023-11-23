﻿using Logic.Managers;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animals;
using Logic.Interfaces;
using Employees;
using Microsoft.Data.SqlClient;
using DataAccess;
using Logic.DTO;

namespace Desktop
{
    public partial class Login : Form
    {
        IAnimal animalRepository = new AnimalRepository();
        ILocation locationRepository = new LocationRepository();

        private readonly UserManager userManager;
       
        public Login()
        {
            InitializeComponent();

            userManager = new UserManager(new UserRepository());
            

        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IUser userRepository = new UserRepository();
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;

            User currentUser = userRepository.Login(email, password);   


            if (currentUser != null)
            {
               string position = userManager.RetrievePositionInformation(email);

                if (position == "Admin")
                {
                    Form openfrom = new Form1();
                    openfrom.ShowDialog();
                }
                if (position == "Caretaker")
                {
                    Form addAnimalForm = new CaretakerForm(animalRepository, locationRepository);
                    addAnimalForm.ShowDialog();
                }
                if (position == "1")
                {
                    Form addEmployeeForm = new MainForm(1);
                    addEmployeeForm.ShowDialog();
                }
                if (position == "2")
                {
                    Form formtoopen = new MainForm(2);
                    formtoopen.ShowDialog();
                }
                if (position == "3")
                {
                    Form addAnimalForm = new MainForm(3);
                    addAnimalForm.ShowDialog();
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Create an instance of UserRepository (assuming it implements IUser)
            IUser userRepository = new UserRepository();

            UserDTO dummyUser = new UserDTO
            {
                Username = "test@example.com",
                Password = "password",
                Email = "Test User"
             
            };

            // Call the InsertDummyUser method on the userRepository instance
            bool insertionResult = userRepository.InsertDummyUser(dummyUser);

            if (insertionResult)
            {
                Console.WriteLine("Dummy user inserted successfully.");
            }
            else
            {
                Console.WriteLine("Failed to insert dummy user.");
            }
        }
    }
}
