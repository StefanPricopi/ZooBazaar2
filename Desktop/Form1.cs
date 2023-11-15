using Animals;
using Employees;
using Logic.DTO;
using Logic.Interfaces;

namespace Desktop
{
    public partial class Form1 : Form
    {
        private EmployeeManager employeeManager;
        private IAnimal animalRepository;
        public Form1()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
        }

        private void btnAreaManagement_Click(object sender, EventArgs e)
        {
            Area_LocationManagement management = new Area_LocationManagement();
            management.Show();

        }

        private void btnOpenAddAnimalForm_Click(object sender, EventArgs e)
        {
            AddAnimal addAnimalForm = new AddAnimal(animalRepository);
            addAnimalForm.ShowDialog();
        }

        private void btnOpenViewAnimalDetailsForm_Click(object sender, EventArgs e)
        {
            ViewAnimalDetails viewAnimalDetailsForm = new ViewAnimalDetails(animalRepository);
            viewAnimalDetailsForm.ShowDialog();
        }

        private void btnOpenUpdateAnimalForm_Click(object sender, EventArgs e)
        {
            List<AnimalDTO> animals = animalRepository.GetAllAnimals();

            UpdateAnimal updateAnimalForm = new UpdateAnimal(animalRepository, animals);
            updateAnimalForm.ShowDialog();
        }

        private void btnOpenSearchAnimalForm_Click(object sender, EventArgs e)
        {
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