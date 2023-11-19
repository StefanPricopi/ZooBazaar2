using System;
using System.Windows.Forms;

namespace Desktop
{
    public partial class AssignEmployee : Form
    {
        private DateTime selectedDate;
        private string selectedShift;
        private string selectedEmployee;


        public AssignEmployee(DateTime date, string shiftType)
        {
            InitializeComponent();
            selectedDate = date;
            selectedShift = shiftType;
            
        }

        private void AssignEmployee_Load(object sender, EventArgs e)
        {
            string selectedDateFormatted = selectedDate.ToString();
            tbxDate.Text = selectedDateFormatted;
            tbxShiftType.Text = selectedShift;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            selectedEmployee = cmbEmployee.Text;

            // Find the appropriate shift panel based on selectedShift and selectedDate
            DateTime selectedDate = DateTime.Parse(tbxDate.Text);

            if (selectedShift == "MorningShift" && ShiftPanelManager.MorningShiftPanels.ContainsKey(selectedDate.Date))
            {
                ShiftPanelManager.MorningShiftPanels[selectedDate.Date].AddShiftLabel(selectedEmployee);
            }
            if (selectedShift == "AfternoonShift" && ShiftPanelManager.AfternoonShiftPanels.ContainsKey(selectedDate.Date))
            {
                ShiftPanelManager.AfternoonShiftPanels[selectedDate.Date].AddShiftLabel(selectedEmployee);
            }
            if (selectedShift == "EveningShift" && ShiftPanelManager.EveningShiftPanels.ContainsKey(selectedDate.Date))
            {
                ShiftPanelManager.EveningShiftPanels[selectedDate.Date].AddShiftLabel(selectedEmployee);
            }


        }
    }
}
