using DataAccess;
using Logic.DTO;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals
{
    public partial class AddAnimal : Form
    {
        private IAnimal animalRepository;
        private List<string> phylum;
        private Dictionary<string, List<string>> classis;
        private Dictionary<string, List<string>> ordo;
        private Dictionary<string, List<string>> familia;
        private Dictionary<string, List<string>> genus;
        private Dictionary<string, List<string>> species;

        public AddAnimal(IAnimal animalRepository)
        {
            InitializeComponent();
            this.animalRepository = animalRepository;
            classis = GetClassisList();
            ordo = GetOrdoList();
            familia = GetFamiliaList();
            genus = GetGenusList();
            species = GetSpeciesList();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            phylum = GetPhylumList();

            comboPhylum.Items.AddRange(phylum.ToArray());
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

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string phylum = comboPhylum.Text;
            string classis = comboClassis.Text;
            string ordo = comboOrdo.Text;
            string familia = comboFamilia.Text;
            string genus = comboGenus.Text;
            string species = comboSpecies.Text;
            string history = tbxHistory.Text;
            string status = comboStatus.Text;
            string diet = tbxDiet.Text;
            string specialDiet = tbxSpecialDiet.Text;
            DateTime dateOfBirth = dateBirth.Value;

            AnimalDTO dummyAnimal = new AnimalDTO()
            {
                Name = name,
                Regio = "Animal",
                DateOfBirth = dateOfBirth,
                Regnum = "Animalia",
                Phylum = phylum,
                Classis = classis,
                Ordo = ordo,
                Familia = familia,
                Genus = genus,
                Species = species,
                History = history,
                Status = status,
                Diet = diet,
                SpecialDiet = specialDiet,
                EmployeeID = 1
            };

            bool insertionResult = animalRepository.CreateAnimal(dummyAnimal);

            if (insertionResult)
            {
                MessageBox.Show("Animal added succesfully!");
            }
            else
            {
                MessageBox.Show("No");
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
        private void ResetComboBoxItems(ComboBox comboBox, List<string> items)
        {
            comboBox.DataSource = null;
            comboBox.Items.Clear();

            foreach (var item in items)
            {
                comboBox.Items.Add(item);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbxSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
            }
            else
            {
                FilterComboBoxItems(comboPhylum, searchText);

                FilterComboBoxItems(comboClassis, searchText);

                FilterComboBoxItems(comboOrdo, searchText);
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

        private void comboSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in species)
            {
                comboSpecies.Items.Add(item.Key);
            }
        }
    }
}
