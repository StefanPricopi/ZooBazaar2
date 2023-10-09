using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Entities
{
    public class Location
    {
        //private int areaID;
        //private string areaName;
        //private string status;

        //public int AreaID { get => areaID; set => areaID = value; }
        //public string AreaName { get => areaName; set => areaName = value; }
        //public string Status { get => status; set => status = value; }
        private int locationID;
        private Area area;
        private string locationName;
        private int capacity;
        private string status;

        public int LocationID { get => locationID; set => locationID = value; }
        public Area Area { get => area; set => area = value; }
        public string LocationName { get => locationName; set => locationName = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string Status { get => status; set => status = value; }

        public Location() { }
        public Location(int locationID, Area area, string locationName, int capacity, string status)
        {
            this.locationID = locationID;
            this.area = area;
            this.locationName = locationName;
            this.capacity = capacity;
            this.status = status;
        }

        public Location(LocationDTO locationDTO)
        {
            this.LocationID = locationDTO.LocationID;
            this.area = new Area(locationDTO.AreaDTO)
            {
                AreaID = locationDTO.AreaDTO.AreaID,
                AreaName = locationDTO.AreaDTO.AreaName,
                Status = locationDTO.AreaDTO.Status,
            };
            this.locationName=locationDTO.LocationName;
            this.capacity = locationDTO.Capacity;
            this.status = locationDTO.Status;
        }

        public LocationDTO LocationToLocationDTO() 
        {
            return new LocationDTO()
            {
                LocationID = this.LocationID,
                AreaDTO = this.Area.AreaToAreaDTO(),
                LocationName = this.LocationName,
                Capacity = this.Capacity,
                Status = this.Status
            };
        }

        public override string ToString()
        {
            return LocationName + " " + Status;
        }



    }
}
