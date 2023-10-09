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
    public partial class SearchAnimal : Form
    {
        private AnimalManager animalManager;
        public SearchAnimal(AnimalManager animalManager)
        {
            InitializeComponent();
            this.animalManager = animalManager;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = tbxSearch.Text;

            List<Animal> searchResults = animalManager.SearchAnimals(searchQuery);

            listAnimals.Items.Clear();

            foreach (Animal animal in searchResults)
            {
                listAnimals.Items.Add(animal.ToString());
            }
        }
    }
}
