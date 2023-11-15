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

namespace Animals
{
    public partial class ViewAnimalDetails : Form
    {
        private IAnimal animalRepository;
        public ViewAnimalDetails(IAnimal animalRepository)
        {
            InitializeComponent();
            this.animalRepository = animalRepository;
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            dgvAnimals.AutoGenerateColumns = true;
            dgvAnimals.DataSource = animalRepository.GetAllAnimals();
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
    }
}
