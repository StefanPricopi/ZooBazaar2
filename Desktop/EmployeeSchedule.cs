using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.LinkLabel;

namespace Employees
{
    public partial class EmployeeSchedule : Form
    {
        private string connectionString = "Server=mssqlstud.fhict.local;Database=dbi478560_dbijungle;User Id=dbi478560_dbijungle;Password=1234;Encrypt=false;";

        public EmployeeSchedule()
        {
            InitializeComponent();
        }

        private void EmployeeScheduleForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeNames();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            LoadScheduledEmployees(selectedDate);
        }
        private void LoadEmployeeNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT EmployeeID, FirstName, LastName FROM Employees";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbEmployees.Items.Add(reader["FirstName"].ToString());
                        }
                    }
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string selectedEmployeeName = cmbEmployees.SelectedItem as string;

            if (monthCalendar1.SelectionStart != DateTime.MinValue)
            {
                DateTime selectedDate = monthCalendar1.SelectionStart;

                int employeeId = GetEmployeeIdByName(selectedEmployeeName);

                if (employeeId > 0)
                {
                    InsertEmployeeSchedule(employeeId, selectedDate);

                    MessageBox.Show("Employee added to the schedule successfully!");
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a date on the calendar.");
            }
        }

        private int GetEmployeeIdByName(string employeeName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT ID FROM Employee WHERE Name = @EmployeeName";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return (int)result;
                    }
                    else
                    {
                        return -1; // Employee not found
                    }
                }
            }
        }

        private void InsertEmployeeSchedule(int employeeId, DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Schedule (EmployeeID, Date) VALUES (@EmployeeID, @Date)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeId);
                    command.Parameters.AddWithValue("@Date", date);

                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadScheduledEmployees(DateTime selectedDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Name " +
                                     "FROM Schedule AS S " +
                                     "INNER JOIN Employee AS E ON S.EmployeeID = E.ID " +
                                     "WHERE S.Date = @SelectedDate";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@SelectedDate", selectedDate);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable employeeDataTable = new DataTable();
                        adapter.Fill(employeeDataTable);

                        dataGridView1.DataSource = employeeDataTable;
                    }
                }
            }
        }

    }
}
