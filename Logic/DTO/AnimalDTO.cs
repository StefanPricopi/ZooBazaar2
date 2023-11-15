using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTO
{
    public class AnimalDTO
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
        public int EmployeeID {  get; set; }

        public AnimalDTO() { }
    }
}
