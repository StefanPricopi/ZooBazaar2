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
    public partial class ViewAnimalDetails : Form
    {
        private AnimalManager animalManager;

        public ViewAnimalDetails(AnimalManager animalManager)
        {
            InitializeComponent();
            this.animalManager = animalManager;

            List<string> speciesList = GetSpeciesList();
            comboSpecies.DataSource = speciesList;
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

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            List<string> speciesList = GetSpeciesList();
            foreach (string species in speciesList)
            {
                if (comboSpecies.SelectedItem == species)
                {


                    string selectedSpecies = comboSpecies.SelectedItem.ToString();
                    {
                        if (selectedSpecies == species)
                        {



                            List<Animal> animalsOfSelectedSpecies = animalManager.GetAnimalsBySpecies(selectedSpecies);

                            listAnimals.Items.Clear();
                            foreach (Animal animal in animalsOfSelectedSpecies)
                            {
                                listAnimals.Items.Add(animal.ToString());
                            }
                        }
                    }
                }
            }
        }
    }
}
