﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IShiftPanel
    {
        void AddShiftLabel(string employeeName);
        void UpdateShiftCapacity(int needed, int filled);
    }
}
