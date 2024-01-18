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
using DataAccess;
using Logic.DTO;
using Logic.Entities;
using Logic.Managers;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employees
{
    public partial class EditEmployee : Form
    {
        string connectionString = "Server=mssqlstud.fhict.local;Database=dbi478560_dbijungle;User Id=dbi478560_dbijungle;Password=1234;Encrypt=false;";
        private readonly EmployeeManager employeeManager;



        public EditEmployee()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager(new EmployeeRepository());
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView3.SelectionChanged += dataGridView3_SelectionChanged;
            dataGridView4.SelectionChanged += dataGridView4_SelectionChanged;
            dataGridView5.SelectionChanged += dataGridView5_SelectionChanged;
            cmbRole.DataSource = Enum.GetValues(typeof(Role));
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
                    LoadEmployees();
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
            if (dataGridView2.SelectedRows.Count > 0)
            {

                string uniqueIdentifier = dataGridView2.SelectedRows[0].Cells["UserID"].Value.ToString();

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

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView3.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView3.SelectedRows[0];

                dtpStartDate.Text = selectedRow.Cells["StartDate"].Value.ToString();
                dtpEndDate.Text = selectedRow.Cells["EndDate"].Value.ToString();
                tbxSalary.Text = selectedRow.Cells["Salary"].Value.ToString();
                tbxContractType.Text = selectedRow.Cells["ContractType"].Value.ToString();

            }
        }

        private void dataGridView4_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView4.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView4.SelectedRows[0];

                tbxFirstNamePartner.Text = selectedRow.Cells["FirstName"].Value.ToString();
                tbxLastNamePartner.Text = selectedRow.Cells["LastName"].Value.ToString();
                tbxPhonePartner.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
            }
        }
        private void dataGridView5_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView5.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView5.SelectedRows[0];

                tbxStreet.Text = selectedRow.Cells["StreetName"].Value.ToString();
                tbxCity.Text = selectedRow.Cells["City"].Value.ToString();
                tbxZipCode.Text = selectedRow.Cells["ZipCode"].Value.ToString();
                tbxCountry.Text = selectedRow.Cells["Country"].Value.ToString();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EmployeeDTO employeeDTO = new EmployeeDTO();
                int employeeId = (int)dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value;
                employeeDTO.EmployeeID = employeeId;
                employeeDTO.FirstName = tbxFirstName.Text;
                employeeDTO.LastName = tbxLastName.Text;
                employeeDTO.PhoneNumber = tbxPhone.Text;
                employeeDTO.DateOfBirth = dtpBirthDate.Value;
                employeeDTO.BSN = int.Parse(tbxBSN.Text);
                employeeDTO.RoleID = int.Parse(tbxPosition.Text);
                if (employeeManager.UpdateEmployee(employeeDTO))
                {
                    MessageBox.Show("Success");
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("fail");
                }


            }
        }
        private void btnEditLogin_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                UserDTO userDTO = new UserDTO();

                int userID = (int)dataGridView2.SelectedRows[0].Cells["UserID"].Value;
                userDTO.UserID = userID;
                userDTO.Username = tbxUsername.Text;
                userDTO.Password = tbxPassword.Text;
                userDTO.Email = tbxEmail.Text;
                if (employeeManager.UpdateEmployeeLoginDetails(userDTO))
                {
                    MessageBox.Show("Success");
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("fail");
                }

            }
        }

        private void btnEditContract_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                ContractDTO contractDTO = new ContractDTO();

                int contractID = (int)dataGridView3.SelectedRows[0].Cells["ContractID"].Value;
                contractDTO.ContractID = contractID;
                contractDTO.StartDate = dtpStartDate.Value;
                contractDTO.EndDate = dtpEndDate.Value;
                contractDTO.Salary = Convert.ToDecimal(tbxSalary.Text);
                contractDTO.ContractType = tbxContractType.Text;
                contractDTO.RoleID = cmbRole.SelectedIndex;
                if (employeeManager.UpdateEmployeeContract(contractDTO))
                {
                    MessageBox.Show("Success");
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("fail");
                }

            }
        }
        private void btnEditPartner_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                PartnerDTO partnerDTO = new PartnerDTO();

                int partnerID = (int)dataGridView4.SelectedRows[0].Cells["PartnerID"].Value;
                partnerDTO.PartnerID = partnerID;
                partnerDTO.FirstName = tbxFirstNamePartner.Text;
                partnerDTO.LastName = tbxLastNamePartner.Text;
                partnerDTO.PhoneNumber = tbxPhonePartner.Text;
                if (employeeManager.UpdateEmployeePartner(partnerDTO))
                {
                    MessageBox.Show("Success");
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("fail");
                }

            }
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                AddressDTO addressDTO = new AddressDTO();

                int addressID = (int)dataGridView5.SelectedRows[0].Cells["AddressID"].Value;
                addressDTO.AddressID = addressID;
                addressDTO.StreetName = tbxStreet.Text;
                addressDTO.City = tbxCity.Text;
                addressDTO.ZipCode = tbxZipCode.Text;
                addressDTO.Country = tbxCountry.Text;
                if (employeeManager.UpdateEmployeeAddress(addressDTO))
                {
                    MessageBox.Show("Success");
                    LoadEmployees();
                }
                else
                {
                    MessageBox.Show("fail");
                }

            }
        }
    }
}
