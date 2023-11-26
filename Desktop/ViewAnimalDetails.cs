using Logic.DTO;
using Logic.Entities;
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

namespace Animals
{
    public partial class ViewAnimalDetails : Form
    {
        private IAnimal animalRepository;
        private ILocation locationRepository;

        public ViewAnimalDetails(IAnimal animalRepository, ILocation locationRepository)
        {
            InitializeComponent();
            this.animalRepository = animalRepository;
            this.locationRepository = locationRepository;
            InitializeGrid();
            InitializeLocationComboBox();
        }

        private void InitializeGrid()
        {
            dgvAnimals.AutoGenerateColumns = true;
            dgvAnimals.DataSource = animalRepository.GetAllAnimals();
        }

        private void InitializeLocationComboBox()
        {
            List<LocationDTO> locations = locationRepository.GetAllLocations();
            comboLocation.DataSource = locations;
            comboLocation.DisplayMember = "LocationName";
            comboLocation.ValueMember = "LocationID";
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitializeGrid();
        }



        private void ViewAnimalDetails_Load(object sender, EventArgs e)
        {
        }

        private void comboPhylum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboClassis_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbxSearch_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void dgvAnimals_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int? locationID = null;
            AnimalDTO selectedAnimal = null;

            if (dgvAnimals.SelectedRows.Count > 0)
            {
                selectedAnimal = (AnimalDTO)dgvAnimals.SelectedRows[0].DataBoundItem;

                if (comboLocation.SelectedValue is int selectedLocationID)
                {
                    locationID = selectedLocationID;
                }
            }

            if (locationID.HasValue && selectedAnimal != null)
            {
                // Use the repository method to check if the location is at capacity
                if (locationRepository.IsLocationAtCapacity(locationID.Value))
                {
                    MessageBox.Show("Error: Location has reached its capacity. Cannot assign animal.");
                    return;
                }

                // Call the AssignAnimalToLocation method to handle the assignment
                if (locationRepository.AssignAnimalToLocation(selectedAnimal.AnimalID, locationID.Value))
                {
                    MessageBox.Show("Location assigned successfully!");
                    List<AnimalDTO> updatedAnimals = animalRepository.GetAllAnimals();
                    InitializeGrid();
                }
                else
                {
                    MessageBox.Show("Failed to assign location.");
                }
            }
            else
            {
                MessageBox.Show("Please select a location from the ComboBox.", "Error");
            }
        }


    }
}

