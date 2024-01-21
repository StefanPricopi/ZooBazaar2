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
    public class AnnouncementManager
    {
        private readonly IAnnouncements announcementRepository;

        public AnnouncementManager(IAnnouncements announcementRepository)
        {
            this.announcementRepository = announcementRepository ?? throw new ArgumentNullException(nameof(announcementRepository));
        }

        public bool AddAnnouncement(AnnouncementDTO announcementDTO)
        {
            return announcementRepository.AddAnnouncement(announcementDTO);
        }
        public bool UpdateAnnouncement(AnnouncementDTO announcementDTO)
        {
            return announcementRepository.UpdateAnnouncement(announcementDTO);
        }
        public bool DeleteAnnouncement(AnnouncementDTO announcementDTO)
        {
            return announcementRepository.DeleteAnnouncement(announcementDTO);
        }

        public List<Announcement> GetAllAnnouncements()
        {
            List<Announcement> announcements = new List<Announcement>();
            foreach (AnnouncementDTO announcementDTO in announcementRepository.GetAllAnnouncements())
            {
                announcements.Add(new Announcement(announcementDTO));
            }
            return announcements;
        }
        public AnnouncementDTO GetTheLastAnnouncementForAll()
        {
            int roleid = 5;
            return announcementRepository.GetTheLastAnnouncementForAll(roleid); 
        }
        public List<Announcement> GetAnnouncementsByRole(int id)
        {
            List<Announcement> announcements = new List<Announcement>();
            foreach (AnnouncementDTO announcementDTO in announcementRepository.GetAnnouncementsByRole(id))
            {
                announcements.Add(new Announcement(announcementDTO));
            }
            return announcements;
        }

        public AnnouncementDTO GetAnnouncementByID(int id)
        {
           return new Announcement(announcementRepository.GetAnnouncementByID(id)).AnnouncementToAnnouncementDTO();
        }
    }
}
