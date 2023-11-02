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
using Logic.Managers;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
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

                string selectQuery = "SELECT EmployeeID, FirstName, LastName, PhoneNumber, DateOfBirth, BSN, UserID, Position FROM Employees";

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT UserID, Username, Password, Email, Salt FROM users";


                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable employeeDataTable = new DataTable();
                        adapter.Fill(employeeDataTable);

                        dataGridView2.DataSource = employeeDataTable;
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
        private void UpdateInfoWhenUserIsSelected()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int employeeId = (int)dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value;


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

                    string updateQuery = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, DateOfBirth = @DateOfBirth, BSN = @BSN, Position = @Position WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", editedFirstName);
                        command.Parameters.AddWithValue("@LastName", editedLastName);
                        command.Parameters.AddWithValue("@PhoneNumber", editedPhone);
                        command.Parameters.AddWithValue("@DateOfBirth", editedBirthDate);
                        command.Parameters.AddWithValue("@BSN", editedBSN);
                        command.Parameters.AddWithValue("@Position", editedPosition);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {




        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                tbxFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();

                tbxLastName.Text = selectedRow.Cells["LastName"].Value.ToString();

                tbxPhone.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                dtpBirthDate.Text = selectedRow.Cells["DateOfBirth"].Value.ToString();
                tbxBSN.Text = selectedRow.Cells["BSN"].Value.ToString();
                tbxPosition.Text = selectedRow.Cells["Position"].Value.ToString();

            }
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {


            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                if (selectedRow.Cells["Username"].Value != null)
                    tbxUsername.Text = selectedRow.Cells["Username"].Value.ToString();
                else
                    tbxUsername.Text = "gosho";

                if (selectedRow.Cells["Password"].Value != null)
                    tbxPassword.Text = selectedRow.Cells["Password"].Value.ToString();
                else
                    tbxPassword.Text = "ivan";

                if (selectedRow.Cells["Email"].Value != null)
                    tbxEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                else
                    tbxEmail.Text = "ivan";
            }
        }

        private void btnEditLogin_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int userID = (int)dataGridView2.SelectedRows[0].Cells["UserID"].Value;

                string editedUsername = tbxUsername.Text;
                string editedPassword = tbxPassword.Text;
                string editedEmail = tbxEmail.Text;
                string salt = DateTime.Now.ToString();
                var hashedPW = UserManager.HashedPassword($"{editedPassword}{salt.Trim()}");
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE users SET Username = @Username, Password = @Password, Email = @Email, Salt = @Salt WHERE UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", editedUsername);
                        command.Parameters.AddWithValue("@Password", hashedPW);
                        command.Parameters.AddWithValue("@Email", editedEmail);
                        command.Parameters.AddWithValue("@Salt", salt);
                        command.Parameters.AddWithValue("@UserID", userID);

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
                MessageBox.Show("Please select an Employee login to edit.");
            }
        }
    }
}
