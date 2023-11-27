using DataAccess;
using Logic.DTO;
using Logic.Entities;
using Logic.Managers;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desktop
{
    public partial class AssignEmployee : Form
    {
        private readonly ScheduleManager manager;
        private DateTime selectedDate;
        private string selectedShift;
        private string selectedEmployee;
        private string employeeIDValue;
        FlowLayoutPanel flowLayoutPanel1;

        public AssignEmployee(DateTime date, string shiftType, FlowLayoutPanel flow)
        {
            manager = new ScheduleManager(new ScheduleRepository());
            InitializeComponent();

            dgvShifts.SelectionChanged += dgvShifts_SelectionChanged;
            selectedDate = date;
            selectedShift = shiftType;
            flowLayoutPanel1 = flow;
        }
        private void LoadEmployees()
        {
            var employeeTable1 = manager.LoadSchedules(selectedDate);

            dgvShifts.DataSource = employeeTable1;

        }
        private void dgvShifts_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvShifts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvShifts.SelectedRows[0];


                if (selectedRow.Cells["EmployeeID"].Value != null)
                    employeeIDValue = selectedRow.Cells["EmployeeID"].Value.ToString();

                int index = int.Parse(employeeIDValue) - 1;

                if (index != -1)
                {
                    cmbUpdateEmployee.SelectedIndex = index;
                }


                if (selectedRow.Cells["Date"].Value != null)
                    tbxUpdateDate.Text = selectedRow.Cells["Date"].Value.ToString();

                if (selectedRow.Cells["Shift"].Value != null)
                    cmbUpdateShift.Text = selectedRow.Cells["Shift"].Value.ToString();

            }
        }

        private void AssignEmployee_Load(object sender, EventArgs e)
        {
            string selectedDateFormatted = selectedDate.ToShortDateString();
            tbxDate.Text = selectedDateFormatted;
            cmbShift.Text = selectedShift;
            // Optionally make the form topmost
            this.TopMost = true;
            PopulateComboBox();
            PopulateShifts();
            PopulateUpdatedShifts();
            PopulateUpdatedComboBox();
            LoadEmployees();
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
        private void PopulateUpdatedComboBox()
        {
            List<KeyValuePair<int, string>> employeeList = manager.GetEmployeeList();
            cmbUpdateEmployee.Items.Clear();
            foreach (var employee in employeeList)
            {
                cmbUpdateEmployee.Items.Add(employee);
            }
        }
        public DateTime currentStartday(DateTime startDate)
        {
            DateTime currentDay = startDate.AddDays(-(int)startDate.DayOfWeek);
            return currentDay;
        }
        private void PopulateShifts()
        {

            foreach (ShiftType time in Enum.GetValues(typeof(ShiftType)))
            {
                cmbShift.Items.Add(time);
            }
        }
        private void PopulateUpdatedShifts()
        {

            foreach (ShiftType time in Enum.GetValues(typeof(ShiftType)))
            {
                cmbUpdateShift.Items.Add(time);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            selectedEmployee = cmbEmployee.Text;
            int employeeID = int.Parse(manager.GetEmployeeID(cmbEmployee.SelectedItem.ToString()));
            DateTime Date = DateTime.TryParse(tbxDate.Text, out DateTime parsedShift) ? parsedShift : DateTime.MinValue;
            string shift = cmbShift.Text;

            manager.CreateShift(employeeID, Date, shift);
            // Find the appropriate shift panel based on selectedShift and selectedDate
            DateTime selectedDate = DateTime.Parse(tbxDate.Text);
            DateTime newDate = currentStartday(selectedDate);
            GenerateWeek(newDate);
            manager.PopulateSchedule(newDate.Date);
            dgvShifts.DataSource = null;
            dgvShifts.DataSource = manager.LoadSchedules(selectedDate);



        }
        private void GenerateWeek(DateTime startDate)
        {
            flowLayoutPanel1.Controls.Clear();

            // Find the Sunday of last week
            DateTime currentDay = startDate.AddDays(-(int)startDate.DayOfWeek);

            // Morning Shifts
            for (int i = 0; i < 7; i++)
            {
                // Create morning shift panel
                MorningShiftPanel morningShiftPanel = new MorningShiftPanel(currentDay.Date, flowLayoutPanel1);
                flowLayoutPanel1.Controls.Add(morningShiftPanel);
                ShiftPanelManager.MorningShiftPanels[currentDay.Date] = morningShiftPanel;

                Label morningLabel = (Label)morningShiftPanel.Controls[0].Controls[0];
                morningLabel.Text = $"Morning Shift\n{currentDay.ToShortDateString()}";

                // Move to the next day
                currentDay = currentDay.AddDays(1);
            }
            currentDay = currentDay.AddDays(-7);
            // Afternoon Shifts
            for (int i = 0; i < 7; i++)
            {
                // Create afternoon shift panel
                AfternoonShiftPanel afternoonShiftPanel = new AfternoonShiftPanel(currentDay.Date, flowLayoutPanel1);
                flowLayoutPanel1.Controls.Add(afternoonShiftPanel);
                ShiftPanelManager.AfternoonShiftPanels[currentDay.Date] = afternoonShiftPanel;

                Label afternoonLabel = (Label)afternoonShiftPanel.Controls[0].Controls[0];
                afternoonLabel.Text = $"Afternoon Shift\n{currentDay.ToShortDateString()}";

                // Move to the next day
                currentDay = currentDay.AddDays(1);
            }
            currentDay = currentDay.AddDays(-7);
            // Evening Shifts
            for (int i = 0; i < 7; i++)
            {
                // Create evening shift panel
                EveningShiftPanel eveningShiftPanel = new EveningShiftPanel(currentDay.Date, flowLayoutPanel1);
                flowLayoutPanel1.Controls.Add(eveningShiftPanel);
                ShiftPanelManager.EveningShiftPanels[currentDay.Date] = eveningShiftPanel;

                Label eveningLabel = (Label)eveningShiftPanel.Controls[0].Controls[0];
                eveningLabel.Text = $"Evening Shift\n{currentDay.ToShortDateString()}";

                // Move to the next day
                currentDay = currentDay.AddDays(1);
            }
        }

        private void btnUpdateShift_Click(object sender, EventArgs e)
        {
            DateTime Date;
            
            DateTime.TryParse(tbxUpdateDate.Text, out Date);
            DataGridViewRow selectedRow = dgvShifts.SelectedRows[0];
            string selectedUpdateEmployee = cmbUpdateEmployee.Text;
            Schedule schedule = new Schedule
            {

                ScheduleId = int.Parse(selectedRow.Cells["ScheduleID"].Value.ToString()),
                Shift = cmbUpdateShift.Text,
                Date = Date,
                EmployeeId = int.Parse(manager.GetEmployeeID(selectedUpdateEmployee)),
            };
            manager.UpdateShift(schedule);
            dgvShifts.DataSource = null;
            dgvShifts.DataSource = manager.LoadSchedules(selectedDate);
            DateTime Somedate = DateTime.Parse(tbxDate.Text);
            DateTime newDate = currentStartday(Somedate);
            GenerateWeek(newDate);
            manager.PopulateSchedule(newDate.Date);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteShift_Click(object sender, EventArgs e)
        {
            if (dgvShifts.SelectedRows.Count > 0)
            {
                string uniqueIdentifier = dgvShifts.SelectedRows[0].Cells["ScheduleID"].Value.ToString();
                int id = int.Parse(uniqueIdentifier);

                manager.DeleteShift(id);

                manager.LoadSchedules(selectedDate);

                dgvShifts.DataSource = null;
                dgvShifts.DataSource = manager.LoadSchedules(selectedDate);
                DateTime Somedate = DateTime.Parse(tbxDate.Text);
                DateTime newDate = currentStartday(Somedate);
                GenerateWeek(newDate);
                manager.PopulateSchedule(newDate.Date);
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }
        }

        public enum ShiftType
        {
            MorningShift,
            AfternoonShift,
            EveningShift
        }
    }
}
