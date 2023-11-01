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

            // Populate the comboPhylum, comboClassis, and comboOrdo with unique values
            List<string> phylumList = GetPhylumList();
            List<string> classisList = GetClassisList();
            List<string> ordoList = GetOrdoList();

            comboPhylum.DataSource = phylumList;
            comboClassis.DataSource = classisList;
            comboOrdo.DataSource = ordoList;
        }

        private List<string> GetPhylumList()
        {
            List<string> phylumList = new List<string>();
            foreach (Animal animal in animalManager.GetAllAnimals())
            {
                if (!phylumList.Contains(animal.Phylum))
                {
                    phylumList.Add(animal.Phylum);
                }
            }
            return phylumList;
        }

        private List<string> GetClassisList()
        {
            List<string> classisList = new List<string>();
            foreach (Animal animal in animalManager.GetAllAnimals())
            {
                if (!classisList.Contains(animal.Classis))
                {
                    classisList.Add(animal.Classis);
                }
            }
            return classisList;
        }

        private List<string> GetOrdoList()
        {
            List<string> ordoList = new List<string>();
            foreach (Animal animal in animalManager.GetAllAnimals())
            {
                if (!ordoList.Contains(animal.Ordo))
                {
                    ordoList.Add(animal.Ordo);
                }
            }
            return ordoList;
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            string selectedPhylum = comboPhylum.SelectedItem as string;
            string selectedClassis = comboClassis.SelectedItem as string;
            string selectedOrdo = comboOrdo.SelectedItem as string;

            List<Animal> filteredAnimals = new List<Animal>();

            foreach (Animal animal in animalManager.GetAllAnimals())
            {
                if (string.IsNullOrEmpty(selectedPhylum) || animal.Phylum == selectedPhylum)
                {
                    if (string.IsNullOrEmpty(selectedClassis) || animal.Classis == selectedClassis)
                    {
                        if (string.IsNullOrEmpty(selectedOrdo) || animal.Ordo == selectedOrdo)
                        {
                            filteredAnimals.Add(animal);
                        }
                    }
                }
            }

            listAnimals.Items.Clear();
            foreach (Animal animal in filteredAnimals)
            {
                listAnimals.Items.Add(animal.Name);
            }
        }

        private void LoadAnimalsToListBox(List<Animal> animals = null)
        {
            listAnimals.Items.Clear();

            if (animals == null)
            {
                animals = animalManager.GetAllAnimals();
            }

            foreach (Animal animal in animals)
            {
                listAnimals.Items.Add(animal.Name);
            }
        }

        private void ViewAnimalDetails_Load(object sender, EventArgs e)
        {
            LoadAnimalsToListBox();
        }

        private void comboPhylum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPhylum = comboPhylum.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedPhylum))
            {
                comboClassis.SelectedIndex = -1;
                comboOrdo.SelectedIndex = -1;

                List<string> classisList = GetClassisList(selectedPhylum);
                comboClassis.DataSource = classisList;
            }

        }

        private List<string> GetClassisList(string selectedPhylum)
        {
            List<string> classisList = new List<string>();
            foreach (Animal animal in animalManager.GetAllAnimals())
            {
                if (animal.Phylum == selectedPhylum && !classisList.Contains(animal.Classis))
                {
                    classisList.Add(animal.Classis);
                }
            }
            return classisList;
        }

        private void comboClassis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClassis = comboClassis.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedClassis))
            {
                // Reset Ordo combo box when Classis is selected.
                comboOrdo.SelectedIndex = -1;

                // Populate the Ordo combo box with the available Ordo values for the selected Classis.
                List<string> ordoList = GetOrdoList(selectedClassis);
                comboOrdo.DataSource = ordoList;
            }
        }

        private List<string> GetOrdoList(string selectedClassis)
        {
            List<string> ordoList = new List<string>();
            foreach (Animal animal in animalManager.GetAllAnimals())
            {
                if (animal.Classis == selectedClassis && !ordoList.Contains(animal.Ordo))
                {
                    ordoList.Add(animal.Ordo);
                }
            }
            return ordoList;
        }

        private void tbxSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = tbxSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                ResetComboBoxItems(comboPhylum, GetPhylumList());
                ResetComboBoxItems(comboClassis, GetClassisList());
                ResetComboBoxItems(comboOrdo, GetOrdoList());
            }
            else
            {
                FilterComboBoxItems(comboPhylum, searchText);

                FilterComboBoxItems(comboClassis, searchText);

                FilterComboBoxItems(comboOrdo, searchText);
            }
        }

        private void ResetComboBoxItems(ComboBox comboBox, List<string> items)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();

            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }
        }

        private void FilterComboBoxItems(ComboBox comboBox, string searchText)
        {
            List<string> originalItems = new List<string>();
            foreach (string item in comboBox.Items)
            {
                originalItems.Add(item);
            }

            comboBox.DataSource = null;
            comboBox.Items.Clear();

            foreach (string item in originalItems)
            {
                if (item.ToLower().StartsWith(searchText))
                {
                    comboBox.Items.Add(item);
                }
            }
        }
    }
}
