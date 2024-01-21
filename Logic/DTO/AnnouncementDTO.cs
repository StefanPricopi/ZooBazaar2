using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DTO
{
    public class AnnouncementDTO
    {
        public int AnnouncementId { get; set; } 
        public int RoleDTO1 { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }

        public AnnouncementDTO() { }
    }
}
