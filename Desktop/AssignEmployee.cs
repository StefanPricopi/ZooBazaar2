using DataAccess;
using Logic.DTO;
using Logic.Entities;
using Logic.Managers;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Desktop
{
    public partial class AssignEmployee : Form
    {
        private readonly ScheduleManager manager;
        private DateTime selectedDate;
        private string selectedShift;
        private string selectedEmployee;

        public AssignEmployee(DateTime date, string shiftType)
        {
            manager = new ScheduleManager(new ScheduleRepository());
            InitializeComponent();
            selectedDate = date;
            selectedShift = shiftType;
        }

        private void AssignEmployee_Load(object sender, EventArgs e)
        {
            string selectedDateFormatted = selectedDate.ToShortDateString();
            tbxDate.Text = selectedDateFormatted;
            tbxShiftType.Text = selectedShift;
            PopulateComboBox();
        }
        private void PopulateComboBox()
        {
            List<KeyValuePair<int, string>> employeeList = manager.GetEmployeeList();
            cmbEmployee.Items.Clear();
            foreach (var employee in employeeList)
            {
                cmbEmployee.Items.Add(employee);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            selectedEmployee = cmbEmployee.Text;
            int employeeID = int.Parse(manager.GetEmployeeID(cmbEmployee.SelectedItem.ToString()));
            DateTime Date = DateTime.TryParse(tbxDate.Text, out DateTime parsedShift) ? parsedShift : DateTime.MinValue;
            string shift = tbxShiftType.Text;
            manager.CreateShift(employeeID, Date, shift);
            // Find the appropriate shift panel based on selectedShift and selectedDate
            DateTime selectedDate = DateTime.Parse(tbxDate.Text);

            manager.PopulateSchedule(selectedDate.Date);


        }
    }
}
