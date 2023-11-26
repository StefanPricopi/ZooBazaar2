using Animals;
using DataAccess;
using Employees;
using Logic.Entities;
using Logic.Interfaces;
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
        private string[] EmplNavFeatures = { "Employee Creation", "Scheduling", "Update Existing Employees" };
        private string[] AnimNavFeatures = { "Animal Management" };
        private string[] AreaNavFeatures = { "Area Management" };
        IAnimal animalRepository = new AnimalRepository();
        ILocation locationRepository = new LocationRepository();

        public MainForm(int role)
        {
            this.DoubleBuffered = true;

            this.WindowState = FormWindowState.Maximized; // Maximize the form
            this.FormBorderStyle = FormBorderStyle.None;   // Remove the border for full screen
            this.DoubleBuffered = true;
            this.TopMost = true;
            // Keep the form on top
            InitializeComponent();
            switch (role)
            {
                case 1:
                    CreateNavButtons(EmplNavFeatures);
                    lbText.Text = "HR Overview";
                    break;
                case 3:
                    CreateNavButtons(AnimNavFeatures);
                    lbText.Text = "Animal Manager Overview";
                    break;
                case 2:
                    CreateNavButtons(AreaNavFeatures);
                    lbText.Text = "Area/Location Manager Overview";
                    break;
                default:
                    break;
            }
        }

        private void ClearCanvas()
        {
            pnlContents.Controls.Clear();
        }

        private void CreateNavButtons(string[] data)
        {
            int yPos = 150;
            int xPos = 20;

            int buttonSpacing = 5;
            Color btnColor = Color.FromArgb(60, 74, 62);

            foreach (string item in data)
            {
                Button btn = new Button();
                btn.Text = item;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                btn.FlatStyle = FlatStyle.Flat;
                btn.Size = new Size(275, 55);
                btn.Location = new Point(xPos, yPos);
                btn.BackColor = Color.Transparent;
                yPos += btn.Height + buttonSpacing;
                btn.FlatAppearance.BorderSize = 1;
                btn.MouseEnter += (sender, e) => ((Button)sender).BackColor = Color.DarkGray;
                btn.MouseLeave += (sender, e) => ((Button)sender).BackColor = Color.Transparent;

                pnlNav.Controls.Add(btn);
                pnlNav.Controls.Add(btn);
                yPos += btn.Height + buttonSpacing;
                btn.Click += ChangeCanvas;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            this.Hide();
            f.FormClosed += (e, args) => this.Close();
            f.Show();
        }


        private void Forms_MainForm_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            // Remove borders for a true full screen experience
            this.FormBorderStyle = FormBorderStyle.None;


        }

        private void Nav_pnl_Resize(object sender, EventArgs e)
        {
            int hight = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = hight;
            this.Width = width;
            Top = 0;
            Left = 0;
            pnlNav.Width = width - 0;
            pnlNav.Height = hight - 20;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ChangeCanvas(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            switch (btn.Text)
            {
                case "Employee Creation":
                    ClearCanvas();
                    SetCanvas(new EmployeeCreation());
                    break;
                case "Scheduling":
                    ClearCanvas();
                    SetCanvas(new EmployeeSchedulingForm());
                    break;
                case "Update Existing Employees":
                    ClearCanvas();
                    ClearCanvas();
                    SetCanvas(new EditEmployee());
                    break;
                case "Animal Management":
                    ClearCanvas();
                    SetCanvas(new CaretakerForm(animalRepository, locationRepository));
                    break;
                case "Area Management":
                    ClearCanvas();
                    SetCanvas(new Area_LocationManagement());
                    break;
            }
        }

        private void SetCanvas(Form x)
        {
            x.TopLevel = false;
            pnlContents.Controls.Add(x);

            // Adjust the size of the form to fit the panel
            x.Width = pnlContents.Width;
            x.Height = pnlContents.Height;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Dock = DockStyle.Fill;
            x.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.FormClosed += (e, args) => this.Close();
            f.Show();
        }
    }
}
