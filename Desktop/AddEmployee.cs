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
using Microsoft.Data.SqlClient;
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

            //Employee newEmployee = new Employee(name, email, password, username);

            //employeeManager.AddEmployee(newEmployee);

            string connectionString = "Server=mssqlstud.fhict.local;Database=dbi478560_dbijungle;User Id=dbi478560_dbijungle;Password=1234;Encrypt=false;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Employees (FirstName, LastName, PhoneNumber, DateOfBirth, BSN, Position) VALUES (@FirstName, @LastName, @PhoneNumber, @DateOfBirth, @BSN, @Position)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@PhoneNumber", phone);
                    command.Parameters.AddWithValue("@DateOfBirth", birthDate);
                    command.Parameters.AddWithValue("@BSN", BSN);
                    command.Parameters.AddWithValue("@Position", position);

                    command.ExecuteNonQuery();
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
