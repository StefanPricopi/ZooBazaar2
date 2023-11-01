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
            comboPhylum.Items.AddRange(new string[] { "Worms", "Arthropods", "Chordates", "Echinoderms", "Mollusks" });
            comboClassis.Items.AddRange(new string[] { "Polychaeta", "Oligochaeta", "Hirudinea", "Insecta", "Arachnida", "Crustacea", "Myriapoda", "Chilopoda", "Diplopoda", "Malacostraca", "Maxillopoda", "Merostomata", "Mammals", "Birds", "Reptiles", "Amphibians", "Fish", "Sea Stars", "Sea Urchins", "Sea Cucumbers", "Snails", "Clams", "Squid", "Chitons" });
            comboOrdo.Items.AddRange(new string[] { "Spionida", "Sabellida", "Terebellida", "Eunicida", "Phyllodocida", "Lumbriculida", "Haplotaxida", "Moniligastrida", "Microchaetida", "Lumbricida", "Arhynchobdellida", "Rhynchobdellida", "Gnatobdellida", "Hirudinida", "Coleoptera", "Diptera", "Lepidoptera", "Hymenoptera", "Hemiptera", "Araneae", "Scorpiones", "Opiliones", "Decapoda", "Isopoda", "Amphipoda", "Euphausiacea", "Chilognatha", "Scolopendromorpha", "Lithobiomorpha", "Polydesmida", "Chordeumatida", "Siphonocryptida", "Spirobolida", "Decapoda", "Amphipoda", "Isopoda", "Euphausiacea", "Calanoida", "Cyclopoida", "Harpacticoida", "Xiphosura", "Carnivora", "Rodentia", "Cetacea", "Primates", "Artiodactyla", "Passeriformes", "Falconiformes", "Columbiformes", "Struthioniformes", "Squamata", "Testudines", "Crocodylia", "Anura", "Caudata", "Gymnophiona", "Salmoniformes", "Perciformes", "Cypriniformes", "Siluriformes", "Paxillosida", "Valvatida", "Spinulosida", "Forcipulatida", "Echinoidea", "Cidaroida", "Holothuriida", "Elasipodida", "Apodida", "Pulmonata", "Gastropoda", "Stylommatophora", "Bivalvia", "Protobranchia", "Palaeoheterodonta", "Teuthida", "Vampyromorpha", "Octopoda", "Chitonida", "Lepidopleurida" });
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {

        }

        private void comboPhylum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPhylum = comboPhylum.SelectedItem.ToString();

            comboClassis.Items.Clear();
            if (selectedPhylum == "Worms")
            {
                comboClassis.Items.AddRange(new string[] { "Polychaeta", "Oligochaeta", "Hirudinea" });
            }
            else if (selectedPhylum == "Arthropods")
            {
                comboClassis.Items.AddRange(new string[] { "Insecta", "Arachnida", "Crustacea", "Myriapoda", "Chilopoda", "Diplopoda", "Malacostraca", "Maxillopoda", "Merostomata" });
            }
            else if (selectedPhylum == "Chordates")
            {
                comboClassis.Items.AddRange(new string[] { "Mammals", "Birds", "Reptiles", "Amphibians", "Fish" });
            }
            else if (selectedPhylum == "Echinoderms")
            {
                comboClassis.Items.AddRange(new string[] { "Sea Stars", "Sea Urchins", "Sea Cucumbers" });
            }
            else if (selectedPhylum == "Mollusks")
            {
                comboClassis.Items.AddRange(new string[] { "Snails", "Clams", "Squid", "Chitons" });
            }
       }

        private void comboClassis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClassis = comboClassis.SelectedItem.ToString();

            comboOrdo.Items.Clear();
            if (string.IsNullOrEmpty(selectedClassis))
            {
                comboOrdo.Items.AddRange(new string[] { "" });
            }
            else
            {
                if (selectedClassis == "Polychaeta")
                {
                    comboOrdo.Items.AddRange(new string[] { "Spionida", "Sabellida", "Terebellida", "Eunicida", "Phyllodocida" });
                }
                else if (selectedClassis == "Oligochaeta")
                {
                    comboOrdo.Items.AddRange(new string[] { "Lumbriculida", "Haplotaxida", "Moniligastrida", "Microchaetida", "Lumbricida" });
                }
                else if (selectedClassis == "Hirudinea")
                {
                    comboOrdo.Items.AddRange(new string[] { "Arhynchobdellida", "Rhynchobdellida", "Gnatobdellida", "Hirudinida" });
                }
                else if (selectedClassis == "Insecta")
                {
                    comboOrdo.Items.AddRange(new string[] { "Coleoptera", "Diptera", "Lepidoptera", "Hymenoptera", "Hemiptera" });
                }
                else if (selectedClassis == "Arachnida")
                {
                    comboOrdo.Items.AddRange(new string[] { "Araneae", "Scorpiones", "Opiliones" });
                }
                else if (selectedClassis == "Crustacea")
                {
                    comboOrdo.Items.AddRange(new string[] { "Decapoda", "Isopoda", "Amphipoda", "Euphausiacea" });
                }
                else if (selectedClassis == "Myriapoda")
                {
                    comboOrdo.Items.AddRange(new string[] { "Chilognatha", "Scolopendromorpha" });
                }
                else if (selectedClassis == "Chilopoda")
                {
                    comboOrdo.Items.AddRange(new string[] { "Lithobiomorpha", "Scolopendromorpha" });
                }
                else if (selectedClassis == "Diplopoda")
                {
                    comboOrdo.Items.AddRange(new string[] { "Polydesmida", "Chordeumatida", "Siphonocryptida", "Spirobolida" });
                }
                else if (selectedClassis == "Malacostraca")
                {
                    comboOrdo.Items.AddRange(new string[] { "Decapoda", "Amphipoda", "Isopoda", "Euphausiacea" });
                }
                else if (selectedClassis == "Maxillopoda")
                {
                    comboOrdo.Items.AddRange(new string[] { "Calanoida", "Cyclopoida", "Harpacticoida" });
                }
                else if (selectedClassis == "Merostomata")
                {
                    comboOrdo.Items.AddRange(new string[] { "Xiphosura" });
                }
                else if (selectedClassis == "Mammals")
                {
                    comboOrdo.Items.AddRange(new string[] { "Carnivora", "Rodentia", "Cetacea", "Primates", "Artiodactyla" });
                }
                else if (selectedClassis == "Birds")
                {
                    comboOrdo.Items.AddRange(new string[] { "Passeriformes", "Falconiformes", "Columbiformes", "Struthioniformes" });
                }
                else if (selectedClassis == "Reptiles")
                {
                    comboOrdo.Items.AddRange(new string[] { "Squamata", "Testudines", "Crocodylia" });
                }
                else if (selectedClassis == "Amphibians")
                {
                    comboOrdo.Items.AddRange(new string[] { "Anura", "Caudata", "Gymnophiona" });
                }
                else if (selectedClassis == "Fish")
                {
                    comboOrdo.Items.AddRange(new string[] { "Salmoniformes", "Perciformes", "Cypriniformes", "Siluriformes" });
                }
                else if (selectedClassis == "Sea Stars")
                {
                    comboOrdo.Items.AddRange(new string[] { "Paxillosida", "Valvatida", "Spinulosida", "Forcipulatida" });
                }
                else if (selectedClassis == "Sea Urchins")
                {
                    comboOrdo.Items.AddRange(new string[] { "Echinoidea", "Cidaroida" });
                }
                else if (selectedClassis == "Sea Cucumbers")
                {
                    comboOrdo.Items.AddRange(new string[] { "Holothuriida", "Elasipodida", "Apodida" });
                }
                else if (selectedClassis == "Snails")
                {
                    comboOrdo.Items.AddRange(new string[] { "Pulmonata", "Gastropoda", "Stylommatophora" });
                }
                else if (selectedClassis == "Clams")
                {
                    comboOrdo.Items.AddRange(new string[] { "Bivalvia", "Protobranchia", "Palaeoheterodonta" });
                }
                else if (selectedClassis == "Squid")
                {
                    comboOrdo.Items.AddRange(new string[] { "Teuthida", "Vampyromorpha", "Octopoda" });
                }
                else if (selectedClassis == "Chitons")
                {
                    comboOrdo.Items.AddRange(new string[] { "Chitonida", "Lepidopleurida" });
                }
            }
        }
    }
}
