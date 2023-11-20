using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logic.Managers
{
    public static class ShiftPanelManager
    {
        public static Dictionary<DateTime, IShiftPanel> MorningShiftPanels { get; set; } = new Dictionary<DateTime, IShiftPanel>();
        public static Dictionary<DateTime, IShiftPanel> AfternoonShiftPanels { get; set; } = new Dictionary<DateTime, IShiftPanel>();
        public static Dictionary<DateTime, IShiftPanel> EveningShiftPanels { get; set; } = new Dictionary<DateTime, IShiftPanel>();
    }
}
