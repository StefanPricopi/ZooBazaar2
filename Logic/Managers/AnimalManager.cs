using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class AnimalManager
    {
        private readonly IAnimal animal;

        public AnimalManager(IAnimal animal)
        {
            this.animal = animal ?? throw new ArgumentNullException(nameof(animal));
        }

        public AnimalManager() { }
        private List<Animal> animals = new List<Animal>();

        public bool CreateAnimal(AnimalDTO animalDTO)
        {
            return animal.CreateAnimal(animalDTO);
        }

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();
            foreach (AnimalDTO a in animal.GetAllAnimals())
            {
                animals.Add(new Animal(a));
            }
            return animals;
        }

        public bool UpdateAnimal(AnimalDTO animalDTO)
        {
            return animal.UpdateAnimal(animalDTO);
        }
    }
}
