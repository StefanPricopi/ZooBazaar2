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
        private int NeededCapacity;
        private int FilledCapacity;
        private Label capacityLabel;
        private DateTime dates;
        FlowLayoutPanel flowLayoutPanel1;
        public AfternoonShiftPanel(DateTime date, FlowLayoutPanel flow, int neededCapacity, int filledCapacity)
        {
            InitializeComponent();
            InitializePanel(date, "Afternoon Shift", neededCapacity, filledCapacity);
            dates = date;
            this.Click += EveningShiftPanel_Click;
            AttachClickEventToChildren(this);
            flowLayoutPanel1= flow;
            NeededCapacity = neededCapacity;
            FilledCapacity = filledCapacity;
        }
        public void UpdateShiftCapacity(int needed, int filled)
        {
            if (capacityLabel != null)
            {
                capacityLabel.Text = $"{filled}/{needed}";
            }
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
            foreach (Control childControl in control.Controls)
            {
                if (!(childControl is Label)) // Exclude labels from having the click event
                {
                    childControl.Click += EveningShiftPanel_Click;
                }

                AttachClickEventToChildren(childControl);
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
        private void InitializePanel(DateTime date, string shiftType, int neededcapacity, int filledcapacity)
        {
            // making the panels scrollable so that if hundreds of employees are assigned to the same 
            // shift they can still be seen
            Panel scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            int labelHeight = 50;

            // actual label for the shift type and date
            Label label = new Label
            {
                Text = $"{shiftType}\n{date.ToShortDateString()}",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                Location = new Point(0, 0)
            };

            // event for whenever we click on the label
            // to show the assignemployee form
            DateTime currentTime = DateTime.Now;
            if (date <= currentTime.AddDays(-1))
            {

            }
            else
            {

            }

            // Add new label for NeededCapacity and FilledCapacity
            capacityLabel = new Label
            {
                Text = $"{filledcapacity}/{neededcapacity}",
                TextAlign = ContentAlignment.MiddleRight,
                AutoSize = true,
                Location = new Point(scrollablePanel.Width - 100, 0),
                Cursor = Cursors.Hand  // Set cursor to Hand to indicate it's clickable
            };
            capacityLabel.MouseClick += CapacityLabel_MouseClick;

            scrollablePanel.Controls.Add(label);
            if (neededcapacity != 1 && filledcapacity != 1)
            {
                scrollablePanel.Controls.Add(capacityLabel);
            };

            initialPanelHeight = 3 * (labelHeight + 10);

            Controls.Add(scrollablePanel);
        }

        private void CapacityLabel_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            if (dates <= currentTime.AddDays(-1))
            {

            }
            else
            {
                ShiftCapacity addEmployeeForm = new ShiftCapacity(dates, "AfternoonShift", flowLayoutPanel1);
                addEmployeeForm.ShowDialog();
            }
        }
    }
}
