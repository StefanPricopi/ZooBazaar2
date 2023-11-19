using System;
using System.Windows.Forms;

namespace Desktop
{
    public partial class EmployeeSchedulingTest : Form
    {
        private DateTime currentDate;
        private DayOfWeek startOfWeek;

        public EmployeeSchedulingTest()
        {
            InitializeComponent();
            InitializeWeek();
        }

        private void InitializeWeek()
        {
            currentDate = DateTime.Now;
            startOfWeek = DayOfWeek.Sunday;

            ShiftPanelManager.MorningShiftPanels = new Dictionary<DateTime, MorningShiftPanel>();
            ShiftPanelManager.AfternoonShiftPanels = new Dictionary<DateTime, AfternoonShiftPanel>();
            ShiftPanelManager.EveningShiftPanels = new Dictionary<DateTime, EveningShiftPanel>();

            GenerateWeek(currentDate);
        }

        private void GenerateWeek(DateTime startDate)
        {
            flowLayoutPanel1.Controls.Clear();

            // Morning Shifts
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);

                // Create morning shift panel
                MorningShiftPanel morningShiftPanel = new MorningShiftPanel(currentDay);
                flowLayoutPanel1.Controls.Add(morningShiftPanel);
                ShiftPanelManager.MorningShiftPanels[currentDay.Date] = morningShiftPanel;

                // Access the label within the scrollable panel
                Label morningLabel = (Label)morningShiftPanel.Controls[0].Controls[0];
                morningLabel.Text = $"Morning Shift\n{currentDay.ToShortDateString()}";
            }

            // Afternoon Shifts
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);

                // Create afternoon shift panel
                AfternoonShiftPanel afternoonShiftPanel = new AfternoonShiftPanel(currentDay);
                flowLayoutPanel1.Controls.Add(afternoonShiftPanel);
                ShiftPanelManager.AfternoonShiftPanels[currentDay.Date] = afternoonShiftPanel;

                // Access the label within the scrollable panel
                Label afternoonLabel = (Label)afternoonShiftPanel.Controls[0].Controls[0];
                afternoonLabel.Text = $"Afternoon Shift\n{currentDay.ToShortDateString()}";
            }

            // Evening Shifts
            for (int i = 0; i < 7; i++)
            {
                DateTime currentDay = startDate.AddDays(i);

                // Create evening shift panel
                EveningShiftPanel eveningShiftPanel = new EveningShiftPanel(currentDay);
                flowLayoutPanel1.Controls.Add(eveningShiftPanel);
                ShiftPanelManager.EveningShiftPanels[currentDay.Date] = eveningShiftPanel;

                // Access the label within the scrollable panel
                Label eveningLabel = (Label)eveningShiftPanel.Controls[0].Controls[0];
                eveningLabel.Text = $"Evening Shift\n{currentDay.ToShortDateString()}";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(7);
            GenerateWeek(currentDate);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentDate = currentDate.AddDays(-7);
            GenerateWeek(currentDate);
        }
    }

    public static class ShiftPanelManager
    {
        public static Dictionary<DateTime, MorningShiftPanel> MorningShiftPanels { get; set; } = new Dictionary<DateTime, MorningShiftPanel>();
        public static Dictionary<DateTime, AfternoonShiftPanel> AfternoonShiftPanels { get; set; } = new Dictionary<DateTime, AfternoonShiftPanel>();
        public static Dictionary<DateTime, EveningShiftPanel> EveningShiftPanels { get; set; } = new Dictionary<DateTime, EveningShiftPanel>();
    }

}
