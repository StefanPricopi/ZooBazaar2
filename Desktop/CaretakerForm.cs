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
    public partial class CaretakerForm : Form
    {
        private AnimalManager animalManager;
        public CaretakerForm()
        {
            InitializeComponent();
            animalManager = new AnimalManager();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnimal addAnimalForm = new AddAnimal(animalManager);
            addAnimalForm.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewAnimalDetails viewAnimalForm = new ViewAnimalDetails(animalManager);
            viewAnimalForm.ShowDialog();
        }
    }
}
