using Logic.DTO;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Managers
{
    public class EmpProfileManager
    {
        private readonly IEmpProfile empProfile;
       public EmpProfileManager(IEmpProfile empProfile)
        {
            this.empProfile = empProfile ?? throw new ArgumentNullException(nameof(empProfile));
        }

        public EmpProfileDTO GetActualProfileByID(int id)
        {
            return  empProfile.GetActualProfileByID(id);
        }
        public EmpProfileDTO UpdateProfile(EmpProfileDTO updatedProfile)
        {  return empProfile.UpdateProfile(updatedProfile);}
    }
}
