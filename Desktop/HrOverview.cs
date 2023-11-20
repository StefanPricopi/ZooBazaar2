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

namespace Desktop
{
    public partial class HrOverview : Form
    {
        private EmployeeManager employeeManager;
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

        private void btnEmployeeSchedule_Click(object sender, EventArgs e)
        {
            EmployeeSchedulingForm employeeScheduleForm = new EmployeeSchedulingForm();
            employeeScheduleForm.ShowDialog();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee editEmployeeForm = new EditEmployee();
            editEmployeeForm.ShowDialog();
        }
    }
}
