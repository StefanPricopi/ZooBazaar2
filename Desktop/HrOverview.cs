using Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Logic.Managers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animals;
using DataAccess;

namespace Desktop
{
    public partial class HrOverview : Form
    {
        private EmployeeManager employeeManager;
        private Form activeForm;
        public HrOverview()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployeeForm = new AddEmployee();
            addEmployeeForm.ShowDialog();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlOverview.Controls.Add(childForm);
            this.pnlOverview.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnEmployeeSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeSchedulingForm(), sender);
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee editEmployeeForm = new EditEmployee();
            editEmployeeForm.ShowDialog();
        }
    }
}
