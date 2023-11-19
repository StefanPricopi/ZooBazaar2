using System;
using System.Windows.Forms;

namespace Desktop
{
    public partial class EveningShiftPanel : UserControl
    {
        // for comments see morningShiftPanel code is 99% the same
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
            Panel scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            int labelHeight = 50; 

            Label label = new Label
            {
                Text = $"{shiftType}\n{date.ToShortDateString()}",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Location = new Point(0, 0) 
            };
            label.Click += (sender, e) =>
            {
                AssignEmployee addEmployeeForm = new AssignEmployee(date, "EveningShift");
                addEmployeeForm.ShowDialog();
            };


            scrollablePanel.Controls.Add(label);

            initialPanelHeight = 3 * (labelHeight + 10); ; 

            Controls.Add(scrollablePanel);
        }
        
    }
}
