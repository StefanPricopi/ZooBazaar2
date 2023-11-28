using DataAccess;
using Logic.DTO;
using Logic.Entities;
using Logic.Managers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class UpdateEmployeeForm : Form
    {
        string connectionString = "Server=mssqlstud.fhict.local;Database=dbi478560_dbijungle;User Id=dbi478560_dbijungle;Password=1234;Encrypt=false;";
        private readonly EmployeeManager employeeManager;



        public UpdateEmployeeForm()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager(new EmployeeRepository());
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            cmbRole.DataSource = Enum.GetValues(typeof(Role));
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeesInOneGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEmployeesInOneGrid();
        }

        private void LoadEmployeesInOneGrid()
        {
            var employeeTable1 = employeeManager.LoadEmployees();
            dataGridView1.DataSource = employeeTable1;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EmployeeDTO employeeDTO = new EmployeeDTO();
                employeeDTO.EmployeeID = (int)dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value;

                if (employeeManager.DeleteEmployee(employeeDTO))
                {
                    MessageBox.Show("success");
                    LoadEmployeesInOneGrid();
                }
                else
                {
                    MessageBox.Show("fail");
                }

            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }
        private void btnDeleteLogin_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string uniqueIdentifier = dataGridView1.SelectedRows[0].Cells["UserID"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM users WHERE UserID = @UniqueIdentifier";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UniqueIdentifier", uniqueIdentifier);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully!");
                            LoadEmployeesInOneGrid();
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
                dtpStartDate.Text = selectedRow.Cells["StartDate"].Value.ToString();
                dtpEndDate.Text = selectedRow.Cells["EndDate"].Value.ToString();
                tbxSalary.Text = selectedRow.Cells["Salary"].Value.ToString();
                tbxPartnerFirstName.Text = selectedRow.Cells["PartnerFirstName"].Value.ToString();
                tbxPartnerLastName.Text = selectedRow.Cells["PartnerLastName"].Value.ToString();
                tbxPartnerPhone.Text = selectedRow.Cells["PartnerPhoneNumber"].Value.ToString();
                tbxType.Text = selectedRow.Cells["ContractType"].Value.ToString();
                tbxStreetName.Text = selectedRow.Cells["StreetName"].Value.ToString();
                tbxCity.Text = selectedRow.Cells["City"].Value.ToString();
                tbxZip.Text = selectedRow.Cells["ZipCode"].Value.ToString();
                tbxCountry.Text = selectedRow.Cells["Country"].Value.ToString();
                int num = int.Parse(selectedRow.Cells["RoleID"].Value.ToString());
                cmbRole.SelectedIndex = num - 1;
            }
        }








        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployeesInOneGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                UserDTO userDTO = new UserDTO();
                ContractDTO contractDTO = new ContractDTO();
                PartnerDTO partnerDTO = new PartnerDTO();
                AddressDTO addressDTO = new AddressDTO();
                EmployeeDTO employeeDTO = new EmployeeDTO();
                int employeeId = (int)dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value;
                employeeDTO.EmployeeID = employeeId;
                employeeDTO.FirstName = tbxFirstName.Text;
                employeeDTO.LastName = tbxLastName.Text;
                employeeDTO.PhoneNumber = tbxPhone.Text;
                employeeDTO.DateOfBirth = dtpBirthDate.Value;
                employeeDTO.BSN = int.Parse(tbxBSN.Text);
                int addressID = (int)dataGridView1.SelectedRows[0].Cells["AddressID"].Value;
                addressDTO.AddressID = addressID;
                addressDTO.StreetName = tbxStreetName.Text;
                addressDTO.City = tbxCity.Text;
                addressDTO.ZipCode = tbxZip.Text;
                addressDTO.Country = tbxCountry.Text;
                int partnerID = (int)dataGridView1.SelectedRows[0].Cells["PartnerID"].Value;
                partnerDTO.PartnerID = partnerID;
                partnerDTO.FirstName = tbxPartnerFirstName.Text;
                partnerDTO.LastName = tbxPartnerLastName.Text;
                partnerDTO.PhoneNumber = tbxPartnerPhone.Text;
                int userID = (int)dataGridView1.SelectedRows[0].Cells["UserID"].Value;
                userDTO.UserID = userID;
                userDTO.Username = tbxUsername.Text;
                userDTO.Password = tbxPassword.Text;
                userDTO.Email = tbxEmail.Text;
                int contractID = (int)dataGridView1.SelectedRows[0].Cells["ContractID"].Value;
                contractDTO.ContractID = contractID;
                contractDTO.StartDate = dtpStartDate.Value;
                contractDTO.EndDate = dtpEndDate.Value;
                contractDTO.Salary = Convert.ToDecimal(tbxSalary.Text);
                contractDTO.ContractType = tbxType.Text;
                contractDTO.RoleID = cmbRole.SelectedIndex;

                if (employeeManager.UpdateAllTables(employeeDTO, userDTO, contractDTO, partnerDTO, addressDTO))
                {
                    MessageBox.Show("Success");
                    LoadEmployeesInOneGrid();
                }
                else
                {
                    MessageBox.Show("fail");
                }


            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string userId = dataGridView1.SelectedRows[0].Cells["UserID"].Value.ToString();
                string employeeId = dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value.ToString();
                string partnerId = dataGridView1.SelectedRows[0].Cells["PartnerID"].Value.ToString();
                string addressId = dataGridView1.SelectedRows[0].Cells["AddressID"].Value.ToString();
                string contractId = dataGridView1.SelectedRows[0].Cells["ContractID"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Delete from EmployeePartner table
                            string deletePartnerQuery = "DELETE FROM EmployeePartner WHERE EmployeeID = @EmployeeID";
                            using (SqlCommand command = new SqlCommand(deletePartnerQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@EmployeeID", employeeId);
                                command.ExecuteNonQuery();
                            }

                            // Delete from EmployeeAddress table
                            string deleteAddressQuery = "DELETE FROM EmployeeAddress WHERE AddressID = @AddressID";
                            using (SqlCommand command = new SqlCommand(deleteAddressQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@AddressID", addressId);
                                command.ExecuteNonQuery();
                            }

                            // Delete from EmployeeContracts table
                            string deleteContractsQuery = "DELETE FROM EmployeeContracts WHERE ContractID = @ContractID";
                            using (SqlCommand command = new SqlCommand(deleteContractsQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@ContractID", contractId);
                                command.ExecuteNonQuery();
                            }

                            // Delete from Employees table
                            string deleteEmployeesQuery = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                            using (SqlCommand command = new SqlCommand(deleteEmployeesQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@EmployeeID", employeeId);
                                command.ExecuteNonQuery();
                            }

                            // Delete from Users table
                            string deleteUsersQuery = "DELETE FROM Users WHERE UserID = @UserID";
                            using (SqlCommand command = new SqlCommand(deleteUsersQuery, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@UserID", userId);
                                command.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show("Employee and related records deleted successfully!");
                            LoadEmployeesInOneGrid();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Employee deletion failed. Error: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }

    }
}