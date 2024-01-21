using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IEmpProfile
    {
        public EmpProfileDTO GetActualProfileByID(int id);
        public EmpProfileDTO UpdateProfile(EmpProfileDTO updatedProfile);

    }
}
