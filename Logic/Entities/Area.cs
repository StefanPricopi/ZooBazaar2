using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DTO;

namespace Logic.Entities
{
    public class Area
    {
        private int areaID;
        private string areaName;
        private string status;

        public int AreaID { get => areaID; set => areaID = value; }
        public string AreaName { get => areaName; set => areaName = value; }
        public string Status { get => status; set => status = value; }

        public Area(int areaID, string areaName, string status)
        {
            this.areaID = areaID;
            this.areaName = areaName;
            this.status = status;
        }
        public Area() { }
        public Area(string areaName, string status)
        {
            this.areaName = areaName;
            this.status = status;
        }

        public Area(AreaDTO areaDTO)
        {
            this.areaID = areaDTO.AreaID;
            this.areaName= areaDTO.AreaName;
            this.status = areaDTO.Status;
        }

        public AreaDTO AreaToAreaDTO()
        {
            return new AreaDTO()
            {
                AreaID = this.areaID,
                AreaName = this.areaName,
                Status = this.status
            };
        }

        public override string ToString()
        {
            return areaName + " " + status;
        }
        public string DisplayName => AreaName;
    }
}
