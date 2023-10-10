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
using Employees;
using Microsoft.Data.SqlClient;

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
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;
            
            User currentUser = userManager.Login(email, password);
            if (currentUser != null)
            {
                if(currentUser.ClearanceLevel == 0)
                {
                    Form openfrom = new Form1();
                }
                if(currentUser.ClearanceLevel == 1)
                {
                    AddAnimal addAnimalForm = new AddAnimal(animalManager);
                }
                if(currentUser.ClearanceLevel == 2)
                {
                    AddEmployee addEmployeeForm = new AddEmployee(employeeManager);
                }
                if (currentUser.ClearanceLevel == 3)
                {
                    Form formtoopen = new Area_LocationManagement();
                }
            }
        }
    }
}
