using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public string Name { get; set; }
        public string Regio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Regnum { get; set; }
        public string Phylum { get; set; }
        public string Classis { get; set; }
        public string Ordo { get; set; }
        public string Familia { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        public string History { get; set; }
        public string Status { get; set; }
        public string Diet { get; set; }
        public string SpecialDiet { get; set; }

        public Animal(int animalID, string name, DateTime dateofbirth, string phylum, string classis, string ordo, string familia, string genus, string species, string history, string status, string diet, string specialdiet)
        {
            AnimalID = animalID;
            Name = name;
            Regio = "Animal";
            DateOfBirth = dateofbirth;
            Regnum = "Animalia";
            Phylum = phylum;
            Classis = classis;
            Ordo = ordo;
            Familia = familia;
            Genus = genus;
            Species = species;
            History = history;
            Status = status;
            Diet = diet;
            SpecialDiet = specialdiet;
        }

        public Animal(int animalID, string name, DateTime dateofbirth, string phylum, string classis, string ordo)
        {
            AnimalID = animalID;
            Name = name;
            Regio = "Animal";
            DateOfBirth = dateofbirth;
            Regnum = "Animalia";
            Phylum = phylum;
            Classis = classis;
            Ordo = ordo;
        }
    }
}
