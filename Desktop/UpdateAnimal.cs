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
using System.Xml.Linq;

namespace Animals
{
    public partial class UpdateAnimal : Form
    {
        private IAnimal animalRepository;
        private List<AnimalDTO> animals;
        private List<AnimalDTO> filteredAnimals;
        private AnimalDTO selectedAnimal;
        private List<string> phylum;
        private Dictionary<string, List<string>> classis;
        private Dictionary<string, List<string>> ordo;
        private Dictionary<string, List<string>> familia;
        private Dictionary<string, List<string>> genus;
        private Dictionary<string, List<string>> species;

        public UpdateAnimal(IAnimal animalRepository, List<AnimalDTO> animals)
        {
            InitializeComponent();
            this.animalRepository = animalRepository;
            this.animals = animals;
            classis = GetClassisList();
            ordo = GetOrdoList();
            familia = GetFamiliaList();
            genus = GetGenusList();
            species = GetSpeciesList();
            InitializeForm();
            InitializeComboBoxes();
            InitializeUpdateComboBoxes();

            comboUpdatePhylum.SelectedIndex = 0;
        }

        private void InitializeComboBoxes()
        {
            phylum = GetPhylumList();

            comboPhylum.Items.AddRange(phylum.ToArray());
        }

        private void InitializeUpdateComboBoxes()
        {
            phylum = GetPhylumList();
            comboUpdatePhylum.Items.AddRange(phylum.ToArray());

            FillComboBox(comboUpdateClassis, classis.SelectMany(kv => kv.Value).ToArray());
            FillComboBox(comboUpdateOrdo, ordo.SelectMany(kv => kv.Value).ToArray());
            FillComboBox(comboUpdateFamilia, familia.SelectMany(kv => kv.Value).ToArray());
            FillComboBox(comboUpdateGenus, genus.SelectMany(kv => kv.Value).ToArray());
            FillComboBox(comboUpdateSpecies, species.SelectMany(kv => kv.Value).ToArray());
        }

        private void FillComboBox(ComboBox comboBox, string[] items)
        {
            comboBox.Items.AddRange(items);
        }

        private List<string> GetPhylumList()
        {
            List<string> phylum = new List<string> { "Chordata", "Arthropoda" };
            return phylum;
        }

        private Dictionary<string, List<string>> GetClassisList()
        {
            Dictionary<string, List<string>> classis = new Dictionary<string, List<string>>
            {
                { "Chordata", new List<string> { "Mammals", "Birds", "Reptiles", "Fish" } },
                { "Arthropoda", new List<string> { "Insects", "Arachnids", "Crustaceans" } }
            };
            return classis;
        }



        private Dictionary<string, List<string>> GetOrdoList()
        {
            Dictionary<string, List<string>> ordo = new Dictionary<string, List<string>>
            {
                { "Mammals", new List<string> { "Carnivores", "Primates", "Hoofed Animals" } },
                { "Birds", new List<string> { "Songbirds", "Parrots", "Ostriches" } },
                { "Reptiles", new List<string> { "Lizards and Snakes", "Turtles", "Crocodiles" } },
                { "Fish", new List<string> { "Perch-like Fish", "Catfish", "Carp-like Fish" } },
                { "Insects", new List<string> { "Butterflies", "Beetles", "Ants and Bees" } },
                { "Arachnids", new List<string> { "Spiders", "Scorpions", "Whip Scorpions" } },
                { "Crustaceans", new List<string> { "Crabs", "Isopods", "Amphipods" } }
            };
            return ordo;
        }

        private Dictionary<string, List<string>> GetFamiliaList()
        {
            Dictionary<string, List<string>> familia = new Dictionary<string, List<string>>
            {
                { "Carnivores", new List<string> { "Big Cats", "Canines", "Bears" } },
                { "Primates", new List<string> { "Great Apes", "Monkeys" } },
                { "Hoofed Animals", new List<string> { "Giraffes", "Zebras", "Hippopotamuses" } },
                { "Songbirds", new List<string> { "Sparrows", "Finches", "Warblers" } },
                { "Parrots", new List<string> { "Macaws", "Cockatoos", "Lovebirds" } },
                { "Ostriches", new List<string> { "Common Ostrich", "Somali Ostrich" } },
                { "Lizards and Snakes", new List<string> { "Lizards", "Snakes" } },
                { "Turtles", new List<string> { "Tortoises", "Terrapins", "Sea Turtles" } },
                { "Crocodiles", new List<string> { "Nile Crocodile", "American Alligator" } },
                { "Perch-like Fish", new List<string> { "Percidae", "Centrarchidae" } },
                { "Catfish", new List<string> { "Ictaluridae", "Pimelodidae" } },
                { "Carp-like Fish", new List<string> { "Cyprinidae", "Cichlidae" } },
                { "Butterflies", new List<string> { "Nymphalids", "Swallowtails", "Blues" } },
                { "Beetles", new List<string> { "Ladybugs", "Dung Beetles" } },
                { "Ants and Bees", new List<string> { "Honey Bees", "Carpenter Ants" } },
                { "Spiders", new List<string> { "Orb-weavers", "Jumping Spiders", "Tarantulas" } },
                { "Scorpions", new List<string> { "Emperor Scorpions", "Bark Scorpions" } },
                { "Whip Scorpions", new List<string> { "Vinegaroons" } },
                { "Crabs", new List<string> { "Blue Crabs", "King Crabs", "Fiddler Crabs" } },
                { "Isopods", new List<string> { "Woodlice", "Pillbugs" } },
                { "Amphipods", new List<string> { "Scuds" } }
            };
            return familia;
        }

        private Dictionary<string, List<string>> GetGenusList()
        {
            Dictionary<string, List<string>> genus = new Dictionary<string, List<string>>
            {
                { "Big Cats", new List<string> { "Lion", "Tiger", "Leopard" } },
                { "Canines", new List<string> { "Wolf", "Coyote", "Fox" } },
                { "Bears", new List<string> { "Grizzly Bear", "Polar Bear", "Brown Bear" } },
                { "Great Apes", new List<string> { "Chimpanzee", "Gorilla", "Orangutan" } },
                { "Monkeys", new List<string> { "Capuchin Monkey", "Howler Monkey", "Marmoset" } },
                { "Giraffes", new List<string> { "Reticulated Giraffe", "Masai Giraffe" } },
                { "Zebras", new List<string> { "Plains Zebra", "Grevy's Zebra" } },
                { "Hippopotamuses", new List<string> { "Common Hippopotamus" } },
                { "Sparrows", new List<string> { "House Sparrow", "Song Sparrow" } },
                { "Finches", new List<string> { "House Finch", "Goldfinch" } },
                { "Warblers", new List<string> { "Yellow Warbler", "Blackburnian Warbler" } },
                { "Macaws", new List<string> { "Scarlet Macaw", "Blue-and-yellow Macaw" } },
                { "Cockatoos", new List<string> { "Sulphur-crested Cockatoo", "Galah" } },
                { "Lovebirds", new List<string> { "Peach-faced Lovebird", "Fischer's Lovebird" } },
                { "Common Ostrich", new List<string> { "Common Ostrich" } },
                { "Somali Ostrich", new List<string> { "Somali Ostrich" } },
                { "Lizards", new List<string> { "Iguana", "Gecko" } },
                { "Snakes", new List<string> { "Boa Constrictor", "Corn Snake" } },
                { "Tortoises", new List<string> { "Aldabra Giant Tortoise" } },
                { "Terrapins", new List<string> { "Eastern Box Turtle" } },
                { "Sea Turtles", new List<string> { "Loggerhead Sea Turtle" } },
                { "Nile Crocodile", new List<string> { "Nile Crocodile" } },
                { "American Alligator", new List<string> { "American Alligator" } },
                { "Percidae", new List<string> { "Yellow Perch" } },
                { "Centrarchidae", new List<string> { "Largemouth Bass" } },
                { "Ictaluridae", new List<string> { "Channel Catfish" } },
                { "Pimelodidae", new List<string> { "Amazonian Catfish" } },
                { "Cyprinidae", new List<string> { "Common Carp" } },
                { "Cichlidae", new List<string> { "African Cichlid" } },
                { "Nymphalids", new List<string> { "Monarch Butterfly" } },
                { "Swallowtails", new List<string> { "Eastern Tiger Swallowtail" } },
                { "Blues", new List<string> { "Eastern Tailed-Blue" } },
                { "Ladybugs", new List<string> { "Seven-spot Ladybug" } },
                { "Dung Beetles", new List<string> { "Scarab Beetle" } },
                { "Honey Bees", new List<string> { "Western Honey Bee" } },
                { "Carpenter Ants", new List<string> { "Carpenter Ant" } },
                { "Orb-weavers", new List<string> { "Garden Orb-weaver" } },
                { "Jumping Spiders", new List<string> { "Bold Jumping Spider" } },
                { "Tarantulas", new List<string> { "Mexican Redknee Tarantula" } },
                { "Emperor Scorpions", new List<string> { "Emperor Scorpion" } },
                { "Bark Scorpions", new List<string> { "Arizona Bark Scorpion" } },
                { "Vinegaroons", new List<string> { "Vinegaroon" } },
                { "Blue Crabs", new List<string> { "Blue Crab" } },
                { "King Crabs", new List<string> { "King Crab" } },
                { "Fiddler Crabs", new List<string> { "Fiddler Crab" } },
                { "Woodlice", new List<string> { "Common Woodlouse" } },
                { "Pillbugs", new List<string> { "Common Pillbug" } },
                { "Scuds", new List<string> { "Gammarid" } },
            };
            return genus;
        }


        private Dictionary<string, List<string>> GetSpeciesList()
        {
            Dictionary<string, List<string>> species = new Dictionary<string, List<string>>
            {
                { "Lion", new List<string> { "African Lion" } },
                { "Tiger", new List<string> { "Bengal Tiger", "Siberian Tiger" } },
                { "Leopard", new List<string> { "African Leopard", "Snow Leopard" } },
                { "Wolf", new List<string> { "Gray Wolf" } },
                { "Coyote", new List<string> { "Common Coyote" } },
                { "Fox", new List<string> { "Red Fox", "Arctic Fox" } },
                { "Goldfinch", new List<string> { "American Goldfinch" } },
                { "Iguana", new List<string> { "Green Iguana" } },
                { "Gecko", new List<string> { "Leopard Gecko" } },
            };
            return species;
        }


        private void InitializeForm()
        {

            filteredAnimals = new List<AnimalDTO>(animals);



            DisplayAnimals();
        }

        private void DisplayAnimals()
        {
            dgvAnimals.DataSource = null; // Clear the previous data source
            dgvAnimals.DataSource = filteredAnimals;

            // Set the column you want to display as the ID
            dgvAnimals.Columns["AnimalID"].Visible = true;
            dgvAnimals.Columns["Name"].HeaderText = "Animal Name";
        }

        private void FilterAnimals()
        {
            string selectedPhylum = comboUpdatePhylum.SelectedItem?.ToString();
            string selectedClassis = comboUpdateClassis.SelectedItem?.ToString();
            string selectedOrdo = comboUpdateOrdo.SelectedItem?.ToString();
            string selectedFamilia = comboUpdateFamilia.SelectedItem?.ToString();
            string selectedGenus = comboUpdateGenus.SelectedItem?.ToString();
            string selectedSpecies = comboUpdateSpecies.SelectedItem?.ToString();

            filteredAnimals = animals.Where(animal =>
                (selectedPhylum == null || animal.Phylum == selectedPhylum) &&
                (selectedClassis == null || animal.Classis == selectedClassis) &&
                (selectedOrdo == null || animal.Ordo == selectedOrdo) &&
                (selectedFamilia == null || animal.Familia == selectedFamilia) &&
                (selectedGenus == null || animal.Genus == selectedGenus) &&
                (selectedSpecies == null || animal.Species == selectedSpecies)
            ).ToList();

            DisplayAnimals();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an animal to update.");
                return;
            }

            try
            {
                // Assuming you want to get the first selected row
                DataGridViewRow selectedRow = dgvAnimals.SelectedRows[0];

                // Retrieve the bound data object (AnimalDTO) from the selected row's DataBoundItem property
                selectedAnimal = (AnimalDTO)selectedRow.DataBoundItem;

                if (selectedAnimal != null)
                {
                    UpdateAnimalDetails();
                    DisplayAnimals(); // Refresh the DataGridView after updating
                }
                else
                {
                    MessageBox.Show("Invalid animal selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateAnimalDetails()
        {
            selectedAnimal.Name = tbxName.Text;
            selectedAnimal.Regio = "Animal";
            selectedAnimal.DateOfBirth = dateBirth.Value;
            selectedAnimal.Regnum = "Animalia";
            selectedAnimal.Phylum = comboPhylum.Text;
            selectedAnimal.Classis = comboClassis.Text;
            selectedAnimal.Ordo = comboOrdo.Text;
            selectedAnimal.Familia = comboFamilia.Text;
            selectedAnimal.Genus = comboGenus.Text;
            selectedAnimal.Species = comboSpecies.Text;
            selectedAnimal.History = tbxHistory.Text;
            selectedAnimal.Status = comboStatus.Text;
            selectedAnimal.Diet = tbxDiet.Text;
            selectedAnimal.SpecialDiet = tbxSpecialDiet.Text;
            selectedAnimal.EmployeeID = 1;

            // Call the UpdateAnimal method in your repository
            bool updateResult = animalRepository.UpdateAnimal(selectedAnimal);

            if (updateResult)
            {
                MessageBox.Show("Animal updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update animal.");
            }
        }
        private void comboSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UpdateAnimal_Load(object sender, EventArgs e)
        {

        }

        private void comboPhylum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPhylum = comboPhylum.SelectedItem.ToString();
            comboClassis.Items.Clear();

            if (classis.ContainsKey(selectedPhylum))
            {
                comboClassis.Items.AddRange(classis[selectedPhylum].ToArray());
            }
        }

        private void comboClassis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClassis = comboClassis.SelectedItem.ToString();
            comboOrdo.Items.Clear();

            if (ordo.ContainsKey(selectedClassis))
            {
                comboOrdo.Items.AddRange(ordo[selectedClassis].ToArray());
            }
        }

        private void comboOrdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrdo = comboOrdo.SelectedItem.ToString();
            comboFamilia.Items.Clear();

            if (familia.ContainsKey(selectedOrdo))
            {
                comboFamilia.Items.AddRange(familia[selectedOrdo].ToArray());
            }
        }

        private void comboFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFamilia = comboFamilia.SelectedItem.ToString();
            comboGenus.Items.Clear();

            if (genus.ContainsKey(selectedFamilia))
            {
                comboGenus.Items.AddRange(genus[selectedFamilia].ToArray());
            }
        }

        private void comboGenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGenus = comboGenus.SelectedItem.ToString();
            comboSpecies.Items.Clear();

            if (species.ContainsKey(selectedGenus))
            {
                comboSpecies.Items.AddRange(species[selectedGenus].ToArray());
            }
        }

        private void comboSpecies_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvAnimals_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAnimals.SelectedRows[0];
                selectedAnimal = (AnimalDTO)selectedRow.DataBoundItem;

                if (selectedAnimal != null)
                {
                    tbxName.Text = selectedAnimal.Name;
                    dateBirth.Value = selectedAnimal.DateOfBirth;
                    comboPhylum.SelectedItem = selectedAnimal.Phylum;
                    comboClassis.SelectedItem = selectedAnimal.Classis;
                    comboOrdo.SelectedItem = selectedAnimal.Ordo;
                    comboFamilia.SelectedItem = selectedAnimal.Familia;
                    comboGenus.SelectedItem = selectedAnimal.Genus;
                    comboSpecies.SelectedItem = selectedAnimal.Species;
                    tbxHistory.Text = selectedAnimal.History;
                    comboStatus.SelectedItem = selectedAnimal.Status;
                    tbxDiet.Text = selectedAnimal.Diet;
                    tbxSpecialDiet.Text = selectedAnimal.SpecialDiet;
                }
            }
        }

        private void comboUpdateGenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUpdateSpecies.Items.Clear();

            if (comboUpdateGenus.SelectedItem != null)
            {
                string selectedGenus = comboUpdateGenus.SelectedItem.ToString();

                foreach (var genusEntry in genus)
                {
                    if (genusEntry.Value.Contains(comboUpdateGenus.Text))
                    {
                        comboUpdateFamilia.SelectedItem = genusEntry.Key;

                        foreach (var familiaEntry in familia)
                        {
                            if (familiaEntry.Value.Contains(comboUpdateFamilia.Text))
                            {
                                comboUpdateOrdo.SelectedItem = familiaEntry.Key;

                                foreach (var ordoEntry in ordo)
                                {
                                    if (ordoEntry.Value.Contains(comboUpdateOrdo.Text))
                                    {
                                        comboUpdateClassis.SelectedItem = ordoEntry.Key;

                                        foreach (var classisEntry in classis)
                                        {
                                            if (classisEntry.Value.Contains(comboUpdateClassis.Text))
                                            {
                                                comboUpdatePhylum.SelectedItem = classisEntry.Key;
                                                break;
                                            }
                                        }

                                        if (species.TryGetValue(comboUpdateGenus.Text, out var speciesList))
                                        {
                                            comboUpdateSpecies.Items.AddRange(speciesList.ToArray());
                                            comboUpdateSpecies.SelectedItem = speciesList.FirstOrDefault();
                                        }
                                        FilterAnimals(); // Add this line to apply filtering when Phylum changes

                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void comboUpdatePhylum_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUpdateClassis.Items.Clear();
            comboUpdateOrdo.Items.Clear();
            comboUpdateFamilia.Items.Clear();
            comboUpdateGenus.Items.Clear();
            comboUpdateSpecies.Items.Clear();

            if (classis.TryGetValue(comboUpdatePhylum.Text, out var classisList))
            {
                comboUpdateClassis.Items.AddRange(classisList.ToArray());
                comboUpdateClassis.SelectedItem = classisList.FirstOrDefault();
            }

            FilterAnimals();

        }

        private void comboUpdateClassis_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUpdateOrdo.Items.Clear();
            comboUpdateFamilia.Items.Clear();
            comboUpdateGenus.Items.Clear();
            comboUpdateSpecies.Items.Clear();
            if (comboUpdateClassis.SelectedItem != null)
            {
                string selectedClassis = comboUpdateClassis.SelectedItem.ToString();

                foreach (var classisEntry in classis)
                {
                    if (classisEntry.Value.Contains(selectedClassis))
                    {
                        comboUpdatePhylum.SelectedItem = classisEntry.Key;

                        break;
                    }
                }
                if (ordo.TryGetValue(comboUpdateClassis.Text, out var ordoList))
                {
                    comboUpdateOrdo.Items.AddRange(ordoList.ToArray());
                    comboUpdateOrdo.SelectedItem = ordoList.FirstOrDefault();
                }

                FilterAnimals(); // Add this line to apply filtering when Phylum changes

            }
        }

        private void comboUpdateOrdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUpdateFamilia.Items.Clear();
            comboUpdateGenus.Items.Clear();
            comboUpdateSpecies.Items.Clear();

            if (comboUpdateOrdo.SelectedItem != null)
            {
                string selectedOrdo = comboUpdateOrdo.SelectedItem.ToString();

                foreach (var ordoEntry in ordo)
                {
                    if (ordoEntry.Value.Contains(selectedOrdo))
                    {
                        comboUpdateClassis.SelectedItem = ordoEntry.Key;


                        foreach (var classisEntry in classis)
                        {
                            if (classisEntry.Value.Contains(comboUpdateClassis.Text))
                            {
                                comboUpdatePhylum.SelectedItem = classisEntry.Key;
                                break;
                            }
                        }

                        if (familia.TryGetValue(comboUpdateOrdo.Text, out var familiaList))
                        {
                            comboUpdateFamilia.Items.AddRange(familiaList.ToArray());
                            comboUpdateFamilia.SelectedItem = familiaList.FirstOrDefault();
                        }

                        FilterAnimals(); // Add this line to apply filtering when Phylum changes

                        break;
                    }
                }
            }
        }

        private void comboUpdateFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboUpdateGenus.Items.Clear();
            comboUpdateSpecies.Items.Clear();

            if (comboUpdateFamilia.SelectedItem != null)
            {
                string selectedFamilia = comboUpdateFamilia.SelectedItem.ToString();

                foreach (var familiaEntry in familia)
                {
                    if (familiaEntry.Value.Contains(selectedFamilia))
                    {
                        comboUpdateOrdo.SelectedItem = familiaEntry.Key;

                        foreach (var ordoEntry in ordo)
                        {
                            if (ordoEntry.Value.Contains(comboUpdateOrdo.Text))
                            {
                                comboUpdateClassis.SelectedItem = ordoEntry.Key;

                                foreach (var classisEntry in classis)
                                {
                                    if (classisEntry.Value.Contains(comboUpdateClassis.Text))
                                    {
                                        comboUpdatePhylum.SelectedItem = classisEntry.Key;
                                        break;
                                    }
                                }

                                if (genus.TryGetValue(comboUpdateFamilia.Text, out var genusList))
                                {
                                    comboUpdateGenus.Items.AddRange(genusList.ToArray());
                                    comboUpdateGenus.SelectedItem = genusList.FirstOrDefault();
                                }
                                FilterAnimals(); // Add this line to apply filtering when Phylum changes

                                break;
                            }
                        }

                        break;
                    }
                }
            }
        }

        private void comboUpdateSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboUpdateSpecies.SelectedItem != null)
            {
                string selectedSpecies = comboUpdateSpecies.SelectedItem.ToString();

                foreach (var speciesEntry in species)
                {
                    if (speciesEntry.Value.Contains(selectedSpecies))
                    {
                        comboUpdateGenus.SelectedItem = speciesEntry.Key;

                        foreach (var genusEntry in genus)
                        {
                            if (genusEntry.Value.Contains(comboUpdateGenus.Text))
                            {
                                comboUpdateFamilia.SelectedItem = genusEntry.Key;

                                foreach (var familiaEntry in familia)
                                {
                                    if (familiaEntry.Value.Contains(comboUpdateFamilia.Text))
                                    {
                                        comboUpdateOrdo.SelectedItem = familiaEntry.Key;

                                        foreach (var ordoEntry in ordo)
                                        {
                                            if (ordoEntry.Value.Contains(comboUpdateOrdo.Text))
                                            {
                                                comboUpdateClassis.SelectedItem = ordoEntry.Key;

                                                foreach (var classisEntry in classis)
                                                {
                                                    if (classisEntry.Value.Contains(comboUpdateClassis.Text))
                                                    {
                                                        comboUpdatePhylum.SelectedItem = classisEntry.Key;
                                                        break;
                                                        FilterAnimals(); // Add this line to apply filtering when Phylum changes

                                                    }
                                                }
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }
    }
}
