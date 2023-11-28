using DataAccess;
using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Desktop
{
    public partial class EmployeeSchedulingForm : Form
    {
        private DateTime currentDate;
        private readonly ScheduleManager manager;
        private DayOfWeek startOfWeek;

        public DateTime currentStartday(DateTime startDate)
        {
            DateTime currentDay = startDate.AddDays(-(int)startDate.DayOfWeek);
            return currentDay;
        }


        public EmployeeSchedulingForm()
        {
            manager = new ScheduleManager(new ScheduleRepository());
            InitializeComponent();
            lbWeekNum.Parent = pictureBox2;
            InitializeWeek();
        }

        private void InitializeWeek()
        {
            currentDate = DateTime.Now;
            startOfWeek = DayOfWeek.Sunday;
            DateTime newDate = currentStartday(currentDate);
            GenerateWeek(newDate);
            DateTime curr = currentStartday(currentDate);
            manager.PopulateSchedule(curr);
            lbWeekNum.Text = "Current week: " + CalculateTheCurrentWeekByYear(currentDate).ToString();

                
        }
        private int CalculateTheCurrentWeekByYear(DateTime todayDate)
        {

            DateTime startOfYear = new DateTime(todayDate.Year, 1, 1);

            // Determine the current week number
            int currentWeek = GetIso8601WeekNumber(todayDate);

            return currentWeek;
        }
        public static int GetIso8601WeekNumber(DateTime date)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            int week = cal.GetWeekOfYear(date, System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return week;
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
                morningLabel.Text = $"{currentDay.ToShortDateString()}";

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
                afternoonLabel.Text = $"{currentDay.ToShortDateString()}";

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
                eveningLabel.Text = $"{currentDay.ToShortDateString()}";

                // Move to the next day
                currentDay = currentDay.AddDays(1);
            }
        }



        private void btnNext_Click(object sender, EventArgs e)
        {

            currentDate = currentDate.AddDays(7);
            DateTime newDate = currentStartday(currentDate);
            GenerateWeek(currentDate);
            manager.PopulateSchedule(newDate);
            lbWeekNum.Text = "Current week: " + CalculateTheCurrentWeekByYear(currentDate).ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(-7);
            DateTime newDate = currentStartday(currentDate);
            GenerateWeek(currentDate);
            manager.PopulateSchedule(newDate);
            lbWeekNum.Text = "Current week: " + CalculateTheCurrentWeekByYear(currentDate).ToString();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
