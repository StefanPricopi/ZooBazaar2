using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Managers
{
    public class LocationManager
    {
        private readonly ILocation location;

        public LocationManager(ILocation location)
        {
            this.location = location ?? throw new ArgumentNullException(nameof(location));
        }

        public LocationManager() { }

        public bool CreateLocation(LocationDTO locationDTO)
        {
            return location.CreateLocation(locationDTO);
        }

        public List<Location> GetAllLocations()
        {
            List<Location> locations = new List<Location>();
            foreach (LocationDTO l in location.GetAllLocations())
            {
                locations.Add(new Location(l));
            }
            return locations;
        }
        public bool UpdateLocation(LocationDTO locationDTO)
        {
            return location.UpdateLocation(locationDTO);
        }
    }
}
