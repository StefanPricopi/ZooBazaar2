using Animals;
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
        private AnimalManager animalManager;
        public CaretakerOverview()
        {
            animalManager = new AnimalManager();
            InitializeComponent();
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
    }
}
