using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DTO;

namespace Logic.Entities
{
    public class Announcement
    {
        private int announcementId;
        private Role role;
        private string text;
        private string title;

        public int AnnouncementId { get => announcementId; set => announcementId = value; }
        public Role Role { get => role; set => role = value; }
        public string Text { get => text; set => text = value; }
        public string Title { get => title; set => title = value; }

        public Announcement() { }
        public Announcement(Role role, string text, string title)
        {
            this.role = role;
            this.text = text;
            this.title = title;
        }

        public Announcement(int announcementId, Role role, string text, string title)
        {
            this.announcementId = announcementId;
            this.role = role;
            this.text = text;
            this.title = title;
        }

        public Announcement(AnnouncementDTO announcementDTO)
        {
            this.AnnouncementId = announcementDTO.AnnouncementId;
            this.Role = (Role)announcementDTO.RoleDTO1;

            this.Text = announcementDTO.Text;
            this.Title = announcementDTO.Title;
        }

        public AnnouncementDTO AnnouncementToAnnouncementDTO()
        {
            return new AnnouncementDTO
            {
                AnnouncementId = this.AnnouncementId,
                RoleDTO1 = Convert.ToInt32(this.Role),
                Text = this.Text,
                Title = this.Title
            };
        }//

        public override string ToString()
        {
            return Title + " " + Role;
        }
    }
}


