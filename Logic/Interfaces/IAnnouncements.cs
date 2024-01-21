using Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IAnnouncements
    {
        bool AddAnnouncement(AnnouncementDTO announcementDTO);
        List<AnnouncementDTO> GetAllAnnouncements();
        List<AnnouncementDTO> GetAnnouncementsByRole(int id);
        AnnouncementDTO GetAnnouncementByID(int id);
        public bool UpdateAnnouncement(AnnouncementDTO announcementDTO);
        public bool DeleteAnnouncement(AnnouncementDTO announcementDTO);
    }
}
