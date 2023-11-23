using Logic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class MainForm : Form
    {
        private List<string> EmplNavFeatures = new List<string> { "Employee Management", "Scheduling", "Announcement" };
        private List<string> AnimNavFeatures = new List<string> { "Animal Management", "Feeding Table", "Other feature", "Other feature" };

        public MainForm(string role)
        {
            this.DoubleBuffered = true;

            this.WindowState = FormWindowState.Maximized; // Maximize the form
            this.FormBorderStyle = FormBorderStyle.None;   // Remove the border for full screen
            this.DoubleBuffered = true;
            this.TopMost = true;
            InitializeComponent();
            this.Resize += new EventHandler(Nav_pnl_Resize);
            // Keep the form on top

            PageEmployeeManagement();
            PopulateButtons(role);
        }
        private void ClearCanvas()
        {
            pnlContents.Controls.Clear();
        }
        private void PageEmployeeManagement()
        {
            ClearCanvas();
            EmployeeSchedulingForm empPage = new EmployeeSchedulingForm();
            empPage.TopLevel = false;
            pnlContents.Controls.Add(empPage);
            empPage.Dock = DockStyle.Fill;
            
            empPage.Show();
        }
        private void PopulateButtons(string role)
        {
            if (role.Equals("animal_manager"))
            {
                CreateNavButtons(EmplNavFeatures, new List<Form> { new EmployeeSchedulingForm(), /* Add other forms as needed */ });
            }
            else
            {
                CreateNavButtons(AnimNavFeatures, new List<Form> { /* Add forms for the other role */ });
            }
        }
        private void CreateNavButtons(List<string> features, List<Form> forms)
        {
            int xPos = 14;
            int yPos = 269;
            int buttonSpacing = 5;

            for (int i = 0; i < features.Count; i++)
            {
                Button btn = new Button();
                btn.Text = features[i];
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Size = new Size(337, 55);
                btn.Location = new Point(xPos, yPos);
                btn.BackColor = Color.Transparent;
                yPos += btn.Height + buttonSpacing;
                btn.FlatAppearance.BorderSize = 1;
                btn.MouseEnter += (sender, e) => ((Button)sender).BackColor = Color.DarkGray;
                btn.MouseLeave += (sender, e) => ((Button)sender).BackColor = Color.Transparent;

                // Attach a click event handler
                btn.Click += (sender, e) =>
                {
                    // Clear existing controls from pnlContents
                    pnlContents.Controls.Clear();

                    // Add the corresponding form to pnlContents
                    forms[i].TopLevel = false;
                    pnlContents.Controls.Add(forms[i]);
                    forms[i].Size = pnlContents.Size;
                    forms[i].Dock = DockStyle.Fill;
                    forms[i].Show();
                };

                pnlNav.Controls.Add(btn);
                yPos += btn.Height + buttonSpacing;
            }
        }
        private void BtnLogOut_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkGray;
        }

        private void BtnLogOut_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            Dispose();
        }
        private void Forms_MainForm_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            // Remove borders for a true full screen experience
            this.FormBorderStyle = FormBorderStyle.None;

            // Optionally make the form topmost
            this.TopMost = true;


        }
        private void Nav_pnl_Resize(object sender, EventArgs e)
        {
            int hight = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = hight;
            this.Width = width;
            Top = 0;
            Left = 0;
            pnlContents.Width = width - 20;
            pnlContents.Height = hight - 20;
        }


    }
}
