using Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTO
{
    public class LocationDTO
    {
        public int LocationID { get; set; }
        public AreaDTO AreaDTO { get; set; }
        public string LocationName { get;set; }
        public int Capacity { get; set; }
        public string Status { get; set; }
        public int CurrentCapacity {  get; set; }

        public LocationDTO() { }
    }
}
