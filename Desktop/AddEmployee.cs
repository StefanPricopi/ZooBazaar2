using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Logic.DTO;
using Logic.Managers;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employees
{
    public partial class AddEmployee : Form
    {
        private EmployeeManager employeeManager;

        public AddEmployee(EmployeeManager employeeManager)
        {
            InitializeComponent();
            this.employeeManager = employeeManager;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            string phone = tbxPhone.Text;
            DateTime birthDate = dtpBirthDate.Value;
            string BSN = tbxBSN.Text;
            string position = tbxPosition.Text;
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;
            string email = tbxEmail.Text;
            string salt = DateTime.Now.ToString();
            var hashedPW = UserManager.HashedPassword($"{password}{salt.Trim()}");
            //Employee newEmployee = new Employee(name, email, password, username);

            //employeeManager.AddEmployee(newEmployee);

            string connectionString = "Server=mssqlstud.fhict.local;Database=dbi478560_dbijungle;User Id=dbi478560_dbijungle;Password=1234;Encrypt=false;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert into User table
                using (SqlCommand cmdUser = new SqlCommand("INSERT INTO [users] (Username, Email, Password, Salt) VALUES (@Username, @Email, @Password, @Salt); SELECT SCOPE_IDENTITY();", connection))
                {
                    cmdUser.Parameters.AddWithValue("@Username", username);
                    cmdUser.Parameters.AddWithValue("@Email", email);
                    cmdUser.Parameters.AddWithValue("@Password", hashedPW);
                    cmdUser.Parameters.AddWithValue("@Salt", salt);

                    int userID = Convert.ToInt32(cmdUser.ExecuteScalar()); // Get the auto-generated UserID

                    // Insert into Employee table with the obtained UserID
                    using (SqlCommand cmdEmployee = new SqlCommand("INSERT INTO Employees (FirstName, LastName, PhoneNumber, DateOfBirth, BSN, UserID, Position) VALUES (@FirstName, @LastName, @PhoneNumber, @DateOfBirth, @BSN, @UserID, @Position);", connection))
                    {
                        cmdEmployee.Parameters.AddWithValue("@FirstName", firstName);
                        cmdEmployee.Parameters.AddWithValue("@LastName", lastName);
                        cmdEmployee.Parameters.AddWithValue("@PhoneNumber", phone);
                        cmdEmployee.Parameters.AddWithValue("@DateOfBirth", birthDate);
                        cmdEmployee.Parameters.AddWithValue("@BSN", BSN);
                        cmdEmployee.Parameters.AddWithValue("@UserID", userID); // Use the obtained UserID
                        cmdEmployee.Parameters.AddWithValue("@Position", position);

                        cmdEmployee.ExecuteNonQuery(); // Insert employee record
                    }
                }
            }
            MessageBox.Show("Employee Profile added successfully!");
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
