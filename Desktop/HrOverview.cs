using Employees;
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
            AddEmployee addEmployeeForm = new AddEmployee(employeeManager);
            addEmployeeForm.ShowDialog();
        }

        private void btnEmployeeSchedule_Click(object sender, EventArgs e)
        {
            EmployeeSchedule employeeScheduleForm = new EmployeeSchedule();
            employeeScheduleForm.ShowDialog();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee editEmployeeForm = new EditEmployee(employeeManager);
            editEmployeeForm.ShowDialog();
        }
    }
}
