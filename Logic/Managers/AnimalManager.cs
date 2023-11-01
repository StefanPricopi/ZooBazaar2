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
        private List<Animal> animals = new List<Animal>();
        public List<Animal> GetAllAnimals()
        {
            return animals;
        }
        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public List<Animal> GetAnimalsBySpecies(string species)
        {
            List<Animal> result = new List<Animal>();
            foreach (Animal animal in animals)
            {
                if (animal.Species == species)
                {
                    result.Add(animal);
                }
            }
            return result;
        }

        public Animal GetAnimalByName(string name)
        {
            foreach (Animal animal in animals)
            {
                if (animal.Name == name)
                {
                    return animal;
                }
            }
            return null;
        }

        public void UpdateAnimal(Animal updatedAnimal)
        {
            foreach (Animal animal in animals)
            {
                if (animal.Name == updatedAnimal.Name)
                {
                    animal.Species = updatedAnimal.Species;
                    animal.History = updatedAnimal.History;
                    animal.Status = updatedAnimal.Status;
                    animal.Diet = updatedAnimal.Diet;
                    animal.SpecialDiet = updatedAnimal.SpecialDiet;
                    break;
                }
            }
        }

        public List<Animal> SearchAnimals(string query)
        {
            List<Animal> matchingAnimals = new List<Animal>();

            foreach (Animal animal in animals)
            {
                if (animal.Name.Contains(query) || animal.Species.Contains(query))
                {
                    matchingAnimals.Add(animal);
                }
            }

            return matchingAnimals;
        }
    }
}
