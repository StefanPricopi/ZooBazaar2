﻿using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface ILocation
    {
        public bool CreateLocation(LocationDTO locationDTO);
        public List<LocationDTO> GetAllLocations();
        public bool UpdateLocation(LocationDTO locationDTO);
        public LocationDTO GetLocationDetails(int locationID);
        public bool AssignAnimalToLocation(int animalID, int locationID);
        public bool IsLocationAtCapacity(int locationID);

    }
}
