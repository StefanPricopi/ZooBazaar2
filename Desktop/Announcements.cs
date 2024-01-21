using DataAccess;
using Logic.Entities;
using Logic.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Announcements : Form
    {
        private readonly AnnouncementManager announcementManager;
        List<Announcement> announcements = new List<Announcement>();
        public Announcements()
        {
            InitializeComponent();
            announcementManager = new AnnouncementManager(new AnnouncementsRepository());
            announcements = announcementManager.GetAllAnnouncements();
            foreach (var item in Enum.GetValues(typeof(Role)))
            {
                cbDepartment.Items.Add(item);
            }
            foreach (Announcement announcement in announcements)
            {
                lbAnnouncements.Items.Add(announcement);
            }
        }

        public void RefreshList()
        {
            lbAnnouncements.Items.Clear();
            announcements = announcementManager.GetAllAnnouncements();
            foreach (Announcement announcement in announcements)
            {
                lbAnnouncements.Items.Add(announcement);
            }
        }

        private void AddAnnouncement()
        {
            Role selectedRole = (Role)cbDepartment.SelectedItem;
            if (cbDepartment.SelectedItem != null && rtbText.Text != string.Empty && tbTitle.Text != string.Empty)
            {
                Announcement announcement = new Announcement(selectedRole, rtbText.Text, tbTitle.Text);
                announcementManager.AddAnnouncement(announcement.AnnouncementToAnnouncementDTO());
                ClearBoxes();
            }
        }
        private void UpdateAnnouncement()
        {
            Announcement announcement1 = lbAnnouncements.SelectedItem as Announcement;
            Role selectedRole = (Role)cbDepartment.SelectedItem;
            if (cbDepartment.SelectedItem != null && rtbText.Text != string.Empty && tbTitle.Text != string.Empty)
            {
                Announcement announcement = new Announcement(announcement1.AnnouncementId, selectedRole, rtbText.Text, tbTitle.Text);
                announcementManager.UpdateAnnouncement(announcement.AnnouncementToAnnouncementDTO());
                ClearBoxes();
            }
        }
        private void DeleteAnnouncement()
        {
            if (lbAnnouncements.SelectedItem != null)
            {
                Announcement announcement1 = lbAnnouncements.SelectedItem as Announcement;
                announcementManager.DeleteAnnouncement(announcement1.AnnouncementToAnnouncementDTO());
                ClearBoxes();
            }
        }

        private void ClearBoxes()
        {
            tbTitle.Text = string.Empty;
            rtbText.Text = string.Empty;
            cbDepartment.SelectedItem = null;
        }
        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAnnouncement();
            RefreshList();
        }

        private void lbAnnouncements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAnnouncements.SelectedItem != null)
            {
                Announcement announcement = lbAnnouncements.SelectedItem as Announcement;
                tbTitle.Text = announcement.Title;
                rtbText.Text = announcement.Text;
                cbDepartment.SelectedItem = (Role)announcement.Role;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateAnnouncement();
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lbAnnouncements.SelectedItem != null)
            {
                DeleteAnnouncement();
                RefreshList();
            }
            else
            {
                MessageBox.Show("You have to select an announcement first in order to delete it");
            }
        }
    }
}
