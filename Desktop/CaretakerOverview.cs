using Animals;
using Logic.DTO;
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
    public partial class CaretakerOverview : Form
    {
        private IAnimal animalRepository;
        public CaretakerOverview()
        {
            InitializeComponent();
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
    }
}
