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
        string connectionString = "Server=mssqlstud.fhict.local;Database=dbi478560_dbijungle;User Id=dbi478560_dbijungle;Password=1234;Encrypt=false;";
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

                string selectQuery = "SELECT EmployeeID, FirstName, LastName, PhoneNumber, DateOfBirth, BSN, Position FROM Employees";

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

                string uniqueIdentifier = dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Employees WHERE EmployeeID = @UniqueIdentifier";

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
                int employeeId = (int)dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value;

                string editedFirstName = tbxFirstName.Text;
                string editedLastName = tbxLastName.Text;
                string editedPhone = tbxPhone.Text;
                DateTime editedBirthDate = dtpBirthDate.Value;
                string editedBSN = tbxBSN.Text;
                string editedPosition = tbxPosition.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, DateOfBirth = @DateOfBirth, BSN = @BSN, Position = @Position WHERE ID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", editedFirstName);
                        command.Parameters.AddWithValue("@LastName", editedLastName);
                        command.Parameters.AddWithValue("@PhoneNumber", editedPhone);
                        command.Parameters.AddWithValue("@DateOfBirth", editedBirthDate);
                        command.Parameters.AddWithValue("@BSN", editedBSN);
                        command.Parameters.AddWithValue("@Postion", editedPosition);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
