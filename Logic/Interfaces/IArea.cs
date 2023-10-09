using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IArea
    {
        public bool CreateArea(AreaDTO areaDTO);
        public List<AreaDTO> GetAllAreas();
        public bool UpdateArea(AreaDTO areaDTO);
    }
}
