﻿using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IVisitor
    {
        public VisitorDTO GetActualProfileByID(int id);
        public VisitorDTO UpdateVisitorInformation(VisitorDTO updatedVisitor);
    }
}
