using Logic.Interfaces;
using System;
using System.Windows.Forms;

namespace Desktop
{
    public partial class AfternoonShiftPanel : UserControl, IShiftPanel
    {
        // for comments see morningShiftPanel code is 99% the same
        private const int labelHeight = 50;
        private int initialPanelHeight;
        private DateTime dates;
        FlowLayoutPanel flowLayoutPanel1;
        public AfternoonShiftPanel(DateTime date,FlowLayoutPanel flow)
        {
            InitializeComponent();
            InitializePanel(date, "Afternoon Shift");
            dates = date;
            this.Click += EveningShiftPanel_Click;
            AttachClickEventToChildren(this);
            flowLayoutPanel1= flow;
        }
        private void EveningShiftPanel_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            if (dates <= currentTime.AddDays(-1))
            {

            }
            else
            {
                AssignEmployee addEmployeeForm = new AssignEmployee(dates, "AfternoonShift", flowLayoutPanel1);
                addEmployeeForm.ShowDialog();
            }

        }
        private void AttachClickEventToChildren(Control control)
        {
            // Recursively attach the click event handler to all child controls
            foreach (Control childControl in control.Controls)
            {
                childControl.Click += EveningShiftPanel_Click;
                AttachClickEventToChildren(childControl); // Recursively attach to children of children
            }
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
            DateTime currentTime = DateTime.Now;
            if (date <= currentTime.AddDays(-1))
            {

            }
            else
            {
               
            }
            scrollablePanel.Controls.Add(label);


            initialPanelHeight = 3 * (labelHeight + 10); ;
            Controls.Add(scrollablePanel);
        }

    }
}
