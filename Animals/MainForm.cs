using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals
{
    public partial class MainForm : Form
    {
        private AnimalManager animalManager;
        public MainForm()
        {
            InitializeComponent();
            animalManager = new AnimalManager();
        }

        private void btnOpenAddAnimalForm_Click(object sender, EventArgs e)
        {
            AddAnimal addAnimalForm = new AddAnimal(animalManager);
            addAnimalForm.ShowDialog();
        }
    }
}
