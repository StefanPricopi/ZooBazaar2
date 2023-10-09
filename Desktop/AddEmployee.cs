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
            string username = tbxUsername.Text;
            string name = tbxName.Text;
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;

            //Employee newEmployee = new Employee(name, email, password, username);

            //employeeManager.AddEmployee(newEmployee);

            string connectionString = "Server=mssqlstud.fhict.local;Database=dbi516787;User Id=dbi516787;Password=Xhy30aKiec;Encrypt=false;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Employee (Username, Name, Email, Password) VALUES (@Username, @Name, @Email, @Password)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Employee Profile added successfully!");
            this.Close();
        }

    }
}
