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
    public partial class ShiftCapacity : Form
    {
        private readonly ScheduleManager manager;
        private readonly AreaManager areaManager;
        private DateTime selectedDate;
        private string selectedShift;
        private string selectedEmployee;
        private string employeeIDValue;
        private int areaID;
        private Area selectedArea;
        FlowLayoutPanel flowLayoutPanel1;

        public ShiftCapacity(DateTime date, string shiftType, FlowLayoutPanel flow)
        {
            manager = new ScheduleManager(new ScheduleRepository());
            areaManager = new AreaManager(new AreaRepository());
            InitializeComponent();
            selectedDate = date;
            selectedShift = shiftType;
            flowLayoutPanel1 = flow;
        }

       

        private void AssignEmployee_Load(object sender, EventArgs e)
        {
            string selectedDateFormatted = selectedDate.ToShortDateString();
            tbxDate.Text = selectedDateFormatted;
            cmbShift.Text = selectedShift;
            // Optionally make the form topmost
            this.TopMost = true;
            PopulateShifts();
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
        private void PopulateAreas(System.Windows.Forms.ComboBox cmb)
        {
            List<Area> areas = areaManager.GetAllAreas();


            cmb.DisplayMember = "DisplayName";

            foreach (Area area in areas)
            {
                cmb.Items.Add(area);
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            DateTime Date = DateTime.TryParse(tbxDate.Text, out DateTime parsedShift) ? parsedShift : DateTime.MinValue;
            string shift = cmbShift.Text;
            int NeededCapacity = Convert.ToInt32(numCapacity.Value);
            int FilledCapacty = 0;
          bool IsAlreadyCreated =  manager.CreateShiftCapacity(Date, shift, NeededCapacity, FilledCapacty);
            if (!IsAlreadyCreated)
            {
                MessageBox.Show("There's already custom capacity for this date and shift," +
                    "\n please use the update button" +
                    "or select a different date/shift");

            }
            // Find the appropriate shift panel based on selectedShift and selectedDate
            DateTime selectedDate = DateTime.Parse(tbxDate.Text);
            DateTime newDate = currentStartday(selectedDate);
            GenerateWeek(newDate);
            manager.PopulateSchedule(newDate.Date);




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
                MorningShiftPanel morningShiftPanel = new MorningShiftPanel(currentDay.Date, flowLayoutPanel1, 5, 0);
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
                AfternoonShiftPanel afternoonShiftPanel = new AfternoonShiftPanel(currentDay.Date, flowLayoutPanel1, 5, 0);
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
                EveningShiftPanel eveningShiftPanel = new EveningShiftPanel(currentDay.Date, flowLayoutPanel1, 5, 0);
                flowLayoutPanel1.Controls.Add(eveningShiftPanel);
                ShiftPanelManager.EveningShiftPanels[currentDay.Date] = eveningShiftPanel;

                Label eveningLabel = (Label)eveningShiftPanel.Controls[0].Controls[0];
                eveningLabel.Text = $"Evening Shift\n{currentDay.ToShortDateString()}";

                // Move to the next day
                currentDay = currentDay.AddDays(1);
            }
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       
        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbUpdateArea_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnUpdateShift_Click_1(object sender, EventArgs e)
        {
            string shift = cmbShift.Text;
            int NeededCapacity = Convert.ToInt32(numCapacity.Value);
            DateTime Date = DateTime.TryParse(tbxDate.Text, out DateTime parsedShift) ? parsedShift : DateTime.MinValue;
            
            manager.UpdateShiftCapacity(Date, shift, NeededCapacity);
            DateTime selectedDate = DateTime.Parse(tbxDate.Text);
            DateTime newDate = currentStartday(selectedDate);
            GenerateWeek(newDate);
            // check repo
            manager.PopulateSchedule(newDate.Date);
        }

        public enum ShiftType
        {
            MorningShift,
            AfternoonShift,
            EveningShift
        }
    }
}
