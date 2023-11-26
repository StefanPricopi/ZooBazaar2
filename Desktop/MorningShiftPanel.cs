using Employees;
using Logic.Interfaces;
using System;
using System.Windows.Forms;

namespace Desktop
{
    // might consider making a universal ShiftPanel that accepts, shifttype parameter
    // so that it is more "scalable" if lets say client wants 100 different shift types
    // ¯\_(ツ)_/¯
    public partial class MorningShiftPanel : UserControl, IShiftPanel
    {

       // const height for labels, acts as margin between labels
        private const int labelHeight = 50;
        // this is the margin within panels
        private int initialPanelHeight; 
        public MorningShiftPanel(DateTime date)
        {
            InitializeComponent();
            InitializePanel(date, "Morning Shift");
            
        }
        //method that the button which assigns employee to shift calls, to create the label for the employee
        public void AddShiftLabel(string employeeName)
        {
            Label newLabel = new Label
            {
                Text = $"{employeeName}",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Location = new Point(0, Controls[0].Controls.Count * (labelHeight + 10))
            };

            Controls[0].Controls.Add(newLabel);
            Controls[0].Height += labelHeight + 10;
        }
        //intial intialization of all the panels, this is to show the date and shift type
        private void InitializePanel(DateTime date, string shiftType)
        {
            // making the panels scrollable so that if hundreds of employees are assigned to the same 
            // shift they can still be seen
            Panel scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            int labelHeight = 50;

            //actual label for the shift type and date
            Label label = new Label
            {
                Text = $"{shiftType}\n{date.ToShortDateString()}",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Location = new Point(0, 0) 
            };
            // event for whenever we click on the label
            //to show the assignemployee form
            DateTime currentTime = DateTime.Now;
            if (date <= currentTime.AddDays(-1))
            {

            }
            else
            {
                label.Click += (sender, e) =>
                {
                    AssignEmployee addEmployeeForm = new AssignEmployee(date, "MorningShift");
                    addEmployeeForm.Show();
                };
            }
            


            scrollablePanel.Controls.Add(label);

            initialPanelHeight = 3 * (labelHeight + 10); ; 

            Controls.Add(scrollablePanel);
        }



    }
}
