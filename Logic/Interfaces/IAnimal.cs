using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IAnimal
    {
        public bool CreateAnimal(AnimalDTO animalDTO);
        public List<AnimalDTO> GetAllAnimals();
        public bool UpdateAnimal(AnimalDTO animalDTO);
    }
}
