﻿using System;
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
using DataAccess;
using Logic.DTO;
using Logic.Entities;
using Logic.Managers;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Employees
{
    public partial class AddEmployee : Form
    {
        private readonly EmployeeManager employeeManager;
        private Rectangle myTabRect;


        public AddEmployee()
        {
            InitializeComponent();

            employeeManager = new EmployeeManager(new EmployeeRepository());
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            cmbRole.DataSource = Enum.GetValues(typeof(Role));

        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Custom drawing logic for your tab control
            TabControl tabControl = (TabControl)sender;
            TabPage tabPage = tabControl.TabPages[e.Index];

            // First paint the background with a color based on the current tab
            switch (e.Index)
            {
                case 0:
                    e.Graphics.FillRectangle(new SolidBrush(Color.MediumSlateBlue), e.Bounds);
                    break;
                case 1:
                    e.Graphics.FillRectangle(new SolidBrush(Color.MediumSlateBlue), e.Bounds);
                    break;
                case 2:
                    e.Graphics.FillRectangle(new SolidBrush(Color.MediumSlateBlue), e.Bounds);
                    break;
                case 3:
                    e.Graphics.FillRectangle(new SolidBrush(Color.MediumSlateBlue), e.Bounds);
                    break;
                case 4:
                    e.Graphics.FillRectangle(new SolidBrush(Color.MediumSlateBlue), e.Bounds);
                    break;
            }

            // Define your custom text color and font
            Color textColor = Color.Black; // Change to the color you want
            Font textFont = new Font("Arial", 12, FontStyle.Bold); // Change to the font and size you want

            // Then draw the current tab button text with custom text color and font
            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-2, -2);

            using (Brush textBrush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(tabPage.Text, textFont, textBrush, paddedBounds);
            }
        }


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            UserDTO userDTO = new UserDTO();
            EmployeeDTO employeeDTO = new EmployeeDTO();
            ContractDTO contractDTO = new ContractDTO();
            PartnerDTO partnerDTO = new PartnerDTO();
            AddressDTO addressDTO = new AddressDTO();
            RoleDTO roleDTO = new RoleDTO();

            //EmployeeDTO info
            employeeDTO.FirstName = tbxFirstName.Text;
            employeeDTO.LastName = tbxLastName.Text;
            employeeDTO.PhoneNumber = tbxPhone.Text;
            employeeDTO.DateOfBirth = dtpBirthDate.Value;
            employeeDTO.BSN = int.Parse(tbxBSN.Text);
            employeeDTO.RoleID = int.Parse(cmbPosition.Text);

            // UserDTO info
            userDTO.Username = tbxUsername.Text;
            userDTO.Password = tbxPassword.Text;
            userDTO.Email = tbxEmail.Text;

            //ContractDTO info
            contractDTO.StartDate = dtpStartDate.Value;
            contractDTO.EndDate = dtpEndDate.Value;
            contractDTO.Salary = Convert.ToDecimal(tbxSalary.Text);
            contractDTO.ContractType = tbxContractType.Text;
            contractDTO.RoleID = cmbRole.SelectedIndex;

            //PartnerDTO info
            partnerDTO.FirstName = tbxFirstNamePartner.Text;
            partnerDTO.LastName = tbxLastNamePartner.Text;
            partnerDTO.PhoneNumber = tbxPhonePartner.Text;

            //AddressDTO info
            addressDTO.StreetName = tbxStreet.Text;
            addressDTO.Country = tbxCountry.Text;
            addressDTO.ZipCode = tbxZipCode.Text;
            addressDTO.City = tbxCity.Text;

            //RoleDTO info
            roleDTO.RoleName = cmbRole.SelectedText;
            roleDTO.RoleID = cmbRole.SelectedIndex;

            if (employeeManager.CreateEmployee(employeeDTO, userDTO, contractDTO, addressDTO, partnerDTO, roleDTO))
            {
                MessageBox.Show("successful");
            }
            else
            {
                MessageBox.Show("failed");
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPartner_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void tbxCountry_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxZipCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxCity_TextChanged(object sender, EventArgs e)
        {
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
        }

        private void tbxStreet_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
