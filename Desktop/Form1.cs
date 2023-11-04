using Animals;
using Logic.Managers;
using Employees;

namespace Desktop
{
    public partial class Form1 : Form
    {
        private AnimalManager animalManager;
        private EmployeeManager employeeManager;
        public Form1()
        {
            InitializeComponent();
            animalManager = new AnimalManager();
            employeeManager = new EmployeeManager();
        }

        private void btnAreaManagement_Click(object sender, EventArgs e)
        {
            Area_LocationManagement management = new Area_LocationManagement();
            management.Show();

        }

        private void btnOpenAddAnimalForm_Click(object sender, EventArgs e)
        {
            AddAnimal addAnimalForm = new AddAnimal(animalManager);
            addAnimalForm.ShowDialog();
        }

        private void btnOpenViewAnimalDetailsForm_Click(object sender, EventArgs e)
        {
            ViewAnimalDetails viewAnimalDetailsForm = new ViewAnimalDetails(animalManager);
            viewAnimalDetailsForm.ShowDialog();
        }

        private void btnOpenUpdateAnimalForm_Click(object sender, EventArgs e)
        {
            UpdateAnimal updateAnimalForm = new UpdateAnimal(animalManager);
            updateAnimalForm.ShowDialog();
        }

        private void btnOpenSearchAnimalForm_Click(object sender, EventArgs e)
        {
            SearchAnimal searchAnimalForm = new SearchAnimal(animalManager);
            searchAnimalForm.ShowDialog();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployeeForm = new AddEmployee();
            addEmployeeForm.ShowDialog();
        }

        private void btnEmployeeSchedule_Click(object sender, EventArgs e)
        {
            EmployeeSchedule employeeScheduleForm = new EmployeeSchedule();
            employeeScheduleForm.ShowDialog();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            EditEmployee editEmployeeForm = new EditEmployee();
            editEmployeeForm.ShowDialog();
        }
    }
}