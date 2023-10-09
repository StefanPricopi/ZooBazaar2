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
    public partial class AddAnimal : Form
    {
        private AnimalManager animalManager;
        public AddAnimal(AnimalManager animalManager)
        {
            InitializeComponent();
            this.animalManager = animalManager;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            if (tbxSpecies.Text == "")
            {
                MessageBox.Show("species cannot be null");
                return;
            }
            string species = tbxSpecies.Text;
            if (!int.TryParse(tbxAge.Text, out int age))
            {
                MessageBox.Show("Age must be a valid number.");
                return;
            }
            string location = tbxLocation.Text;

            Animal newAnimal = new Animal(name, species, age, location);

            animalManager.AddAnimal(newAnimal);
            MessageBox.Show("Animal added successfully!");
            this.Close();
        }
    }
}
