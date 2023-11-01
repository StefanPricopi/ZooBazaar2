using Logic.Managers;
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
        UserManager userManager = new UserManager();
        private AnimalManager animalManager;
        private EmployeeManager employeeManager;
        public Login()
        {
            InitializeComponent();


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

                if (currentUser.Salt == "somdsdething")
                {
                    Form openfrom = new Form1();
                    openfrom.ShowDialog();
                }
                if (currentUser.Salt == "sometdsdhing")
                {
                    Form addAnimalForm = new CaretakerOverview();
                    addAnimalForm.ShowDialog();
                }
                if (currentUser.Salt == "somssething")
                {
                    Form addEmployeeForm = new HrOverview();
                    addEmployeeForm.ShowDialog();
                }
                if (currentUser.Salt == "something")
                {
                    Form formtoopen = new ManagerOverview();
                    formtoopen.ShowDialog();
                }
                if (currentUser.Salt == "sss")
                {
                    Form openfrom = new Form1();
                    openfrom.ShowDialog();
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
