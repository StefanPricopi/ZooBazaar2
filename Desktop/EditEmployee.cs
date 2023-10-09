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
using Microsoft.Data.SqlClient;

namespace Employees
{
    public partial class EditEmployee : Form
    {
        string connectionString = "Server=mssqlstud.fhict.local;Database=dbi516787;User Id=dbi516787;Password=Xhy30aKiec;Encrypt=false;";
        private EmployeeManager employeeManager;

        public EditEmployee(EmployeeManager employeeManager)
        {
            InitializeComponent();
            this.employeeManager = employeeManager;
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT ID, Username, Name, Email, Password FROM Employee";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable employeeDataTable = new DataTable();
                        adapter.Fill(employeeDataTable);

                        dataGridView1.DataSource = employeeDataTable;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string uniqueIdentifier = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Employee WHERE ID = @UniqueIdentifier";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UniqueIdentifier", uniqueIdentifier);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully!");
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("Employee deletion failed.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int employeeId = (int)dataGridView1.SelectedRows[0].Cells["ID"].Value;

                string editedUsername = tbxUsername.Text;
                string editedName = tbxName.Text;
                string editedEmail = tbxEmail.Text;
                string editedPassword = tbxPassword.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Employee SET Username = @Username, Name = @Name, Email = @Email, Password = @Password WHERE ID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", editedUsername);
                        command.Parameters.AddWithValue("@Name", editedName);
                        command.Parameters.AddWithValue("@Email", editedEmail);
                        command.Parameters.AddWithValue("@Password", editedPassword);
                        command.Parameters.AddWithValue("@EmployeeID", employeeId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee updated successfully!");
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("Employee update failed.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to edit.");
            }
        }

    }
}
