﻿using Logic.DTO;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        private int animalID;
        private string name;
        private string regio;
        private DateTime dateofbirth;
        private string regnum;
        private string phylum;
        private string classis;
        private string ordo;
        private string familia;
        private string genus;
        private string species;
        private string history;
        private string status;
        private string diet;
        private string specialdiet;
        private int employeeID;
        private int locationID;

        public int AnimalID { get => animalID; set => animalID = value; }
        public string Name { get =>  name; set => name = value; }
        public string Regio { get => regio; set => regio = value; }
        public DateTime DateOfBirth { get => dateofbirth; set => dateofbirth = value; }
        public string Regnum { get => regnum; set => regnum = value; }
        public string Phylum { get => phylum; set => phylum = value; }
        public string Classis { get => classis; set => classis = value; }
        public string Ordo { get => ordo; set => ordo = value; }
        public string Familia { get => familia; set => familia = value; }
        public string Genus { get => genus; set => genus = value; }
        public string Species { get => species; set => species = value; }
        public string History { get => history; set => history = value; }
        public string Status { get => status; set => status = value; }
        public string Diet { get => diet; set => diet = value; }
        public string SpecialDiet { get => specialdiet; set => specialdiet = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int LocationID { get => locationID; set => locationID = value; }


        public Animal(string name, DateTime dateofbirth, string phylum, string classis, string ordo, string familia, string genus, string species, string history, string status, string diet, string specialdiet, int employeeID, int locationID)
        {
            this.name = name;
            this.regio = "Animal";
            this.dateofbirth = dateofbirth;
            this.regnum = "Animalia";
            this.phylum = phylum;
            this.classis = classis;
            this.ordo = ordo;
            this.familia = familia;
            this.genus = genus;
            this.species = species;
            this.history = history;
            this.status = status;
            this.diet = diet;
            this.specialdiet = specialdiet;
            this.employeeID = employeeID;
            this.locationID = locationID;
        }

        public Animal() { }

        public Animal(AnimalDTO animalDTO)
        {
            this.animalID = animalDTO.AnimalID;
            this.name = animalDTO.Name;
            this.regio = "Animal";
            this.dateofbirth = animalDTO.DateOfBirth;
            this.regnum = "Animalia";
            this.phylum = animalDTO.Phylum;
            this.classis = animalDTO.Classis;
            this.ordo = animalDTO.Ordo;
            this.familia = animalDTO.Familia;
            this.genus = animalDTO.Genus;
            this.species = animalDTO.Species;
            this.history = animalDTO.History;
            this.status = animalDTO.Status;
            this.diet = animalDTO.Diet;
            this.specialdiet = animalDTO.SpecialDiet;
            this.employeeID = animalDTO.EmployeeID;
            this.locationID = animalDTO.LocationID;
        }

        public AnimalDTO AnimalToAnimalDTO()
        {
            return new AnimalDTO()
            {
                AnimalID = this.animalID,
                Name = this.name,
                Regio = this.regio,
                DateOfBirth = this.dateofbirth,
                Regnum = this.regnum,
                Phylum = this.phylum,
                Classis = this.classis,
                Ordo = this.ordo,
                Familia = this.familia,
                Genus = this.genus,
                Species = this.species,
                History = this.history,
                Status = this.status,
                Diet = this.diet,
                SpecialDiet = this.specialdiet,
                EmployeeID = this.employeeID,
                LocationID = this.locationID,
            };
        }

        public Animal(string name, DateTime dateofbirth, string phylum, string classis, string ordo)
        {
            this.name = name;
            this.regio = "Animal";
            this.dateofbirth = dateofbirth;
            this.regnum = "Animalia";
            this.phylum = phylum;
            this.classis = classis;
            this.ordo = ordo;
        }
    }
}
