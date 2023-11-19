using System;
using System.Windows.Forms;

namespace Desktop
{
    public partial class EveningShiftPanel : UserControl
    {
        private const int labelHeight = 50;
        private int initialPanelHeight;
        public EveningShiftPanel(DateTime date)
        {
            InitializeComponent();
            InitializePanel(date, "Evening Shift");
        }
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
        private void InitializePanel(DateTime date, string shiftType)
        {
            // Create a scrollable panel
            Panel scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            int labelHeight = 50; // Set the height of each label

            // Create the first label with text
            Label label = new Label
            {
                Text = $"{shiftType}\n{date.ToShortDateString()}",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                // Add margin between labels
                Location = new Point(0, 0) // Adjust as needed
            };
            // Attach a click event handler to the first label
            label.Click += (sender, e) =>
            {
                // Open the AddEmployee form or perform any other action on click
                AssignEmployee addEmployeeForm = new AssignEmployee(date, "EveningShift");
                addEmployeeForm.ShowDialog();
            };



            // Add labels to scrollable panel
            scrollablePanel.Controls.Add(label);

            // Set the height of the panel to ensure vertical scrolling
            initialPanelHeight = 3 * (labelHeight + 10); ; // Height for three labels

            // Add scrollable panel to MorningShiftPanel
            Controls.Add(scrollablePanel);
        }
        
    }
}
