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
    public class AreaManager
    {
        private readonly IArea area;

        public AreaManager(IArea area)
        {
            this.area = area ?? throw new ArgumentNullException(nameof(area));
        }

        public AreaManager() { }

        public bool CreateArea(AreaDTO areaDTO)
        {
            return area.CreateArea(areaDTO);
        }

        public List<Area> GetAllAreas()
        {
            List<Area> areas = new List<Area>();
            foreach(AreaDTO a in area.GetAllAreas())
            {
                areas.Add(new Area(a));
            }
            return areas;
        }
        public bool UpdateArea(AreaDTO areaDTO)
        {
            return area.UpdateArea(areaDTO);
        }
    }
}
