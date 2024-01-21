using Logic.DTO;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Managers
{
    public class VisitorProfileManager
    {
        private readonly IVisitor visitor;
        public VisitorProfileManager(IVisitor visitor)
        {
            this.visitor = visitor ?? throw new ArgumentNullException(nameof(visitor));
        }
        public VisitorDTO GetActualProfileByID(int id)
        {
            return visitor.GetActualProfileByID(id);
        }
        public VisitorDTO UpdateVisitorInformation(VisitorDTO updatedVisitor)
        {
            return visitor.UpdateVisitorInformation(updatedVisitor);
        }
    }
}
