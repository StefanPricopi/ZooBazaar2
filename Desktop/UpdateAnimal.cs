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
    public partial class UpdateAnimal : Form
    {
        private AnimalManager animalManager;
        public UpdateAnimal(AnimalManager animalManager)
        {
            InitializeComponent();
            this.animalManager = animalManager;

            List<string> speciesList = GetSpeciesList();
            comboSpecies.DataSource = speciesList;

            comboSpecies.SelectedIndexChanged += comboSpecies_SelectedIndexChanged;
        }

        private List<string> GetSpeciesList()
        {
            List<string> speciesList = new List<string>();
            foreach (Animal animal in animalManager.GetAllAnimals())
            {
                if (!speciesList.Contains(animal.Species))
                {
                    speciesList.Add(animal.Species);
                }
            }
            return speciesList;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            List<string> speciesList = GetSpeciesList();
            foreach (string species in speciesList)
            {
                if (comboSpecies.SelectedItem == species)
                {
                    string selectedSpecies = comboSpecies.SelectedItem.ToString();
                    string selectedAnimalName = comboAnimal.SelectedItem?.ToString();
                    if (string.IsNullOrEmpty(selectedAnimalName))
                    {
                        MessageBox.Show("Please select an animal to update.");
                        return;
                    }



                    if (!int.TryParse(tbxAge.Text, out int newAge))
                    {
                        MessageBox.Show("Age must be a valid number.");
                        return;
                    }

                    MessageBox.Show("Animal information updated successfully!");
                    this.Close();
                }
            }
        }

        private void comboSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecies = comboSpecies.SelectedItem.ToString();


            comboAnimal.Items.Clear();
            
        }

        private void UpdateAnimal_Load(object sender, EventArgs e)
        {

        }
    }
}
