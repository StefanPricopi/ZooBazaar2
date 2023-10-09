using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

        public Animal(string name, string species, int age, string location)
        {
            Name = name;
            Species = species;
            Age = age;
            Location = location;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Species: {Species}, Age: {Age}, Location: {Location}";
        }
    }
}
