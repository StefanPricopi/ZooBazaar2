using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace Animals
{
    public class AnimalManager
    {
        private List<Animal> animals = new List<Animal>();

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
                    animal.Age = updatedAnimal.Age;
                    animal.Location = updatedAnimal.Location;
                    break; 
                }
            }
        }
    }
}
