using DataAccess;
using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Desktop
{
    public partial class EmployeeSchedulingForm : Form
    {
        private DateTime currentDate;
        private readonly ScheduleManager manager;
        private DayOfWeek startOfWeek;

        public EmployeeSchedulingForm()
        {
            manager = new ScheduleManager(new ScheduleRepository());
            InitializeComponent();
            InitializeWeek();
        }

        private void InitializeWeek()
        {
            currentDate = DateTime.Now;
            startOfWeek = DayOfWeek.Sunday;
            GenerateWeek(currentDate);
            manager.PopulateSchedule(currentDate);
        }

        private void GenerateWeek(DateTime startDate)
        {
            flowLayoutPanel1.Controls.Clear();

            // Morning Shifts
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);

                // Create morning shift panel
                MorningShiftPanel morningShiftPanel = new MorningShiftPanel(currentDay.Date);
                flowLayoutPanel1.Controls.Add(morningShiftPanel);
                ShiftPanelManager.MorningShiftPanels[currentDay.Date] = morningShiftPanel;

                Label morningLabel = (Label)morningShiftPanel.Controls[0].Controls[0];
                morningLabel.Text = $"Morning Shift\n{currentDay.ToShortDateString()}";
            }

            // Afternoon Shifts
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);

                // Create afternoon shift panel
                AfternoonShiftPanel afternoonShiftPanel = new AfternoonShiftPanel(currentDay.Date);
                flowLayoutPanel1.Controls.Add(afternoonShiftPanel);
                ShiftPanelManager.AfternoonShiftPanels[currentDay.Date] = afternoonShiftPanel;

                Label afternoonLabel = (Label)afternoonShiftPanel.Controls[0].Controls[0];
                afternoonLabel.Text = $"Afternoon Shift\n{currentDay.ToShortDateString()}";
            }

            // Evening Shifts
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);

                // Create evening shift panel
                EveningShiftPanel eveningShiftPanel = new EveningShiftPanel(currentDay.Date);
                flowLayoutPanel1.Controls.Add(eveningShiftPanel);
                ShiftPanelManager.EveningShiftPanels[currentDay.Date] = eveningShiftPanel;

                Label eveningLabel = (Label)eveningShiftPanel.Controls[0].Controls[0];
                eveningLabel.Text = $"Evening Shift\n{currentDay.ToShortDateString()}";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(7);
            GenerateWeek(currentDate);
            manager.PopulateSchedule(currentDate);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(-7);
            GenerateWeek(currentDate);
            manager.PopulateSchedule(currentDate);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
