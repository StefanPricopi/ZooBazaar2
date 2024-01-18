using Logic.DTO;
using Logic.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AnnouncementsRepository : Connection, IAnnouncements
    {
        public bool AddAnnouncement(AnnouncementDTO announcementDTO)
        {

            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    const string sql = "INSERT INTO Announcements ([roleID], [text], [title])" +
                        "VALUES (@roleID, @text, @title);";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("roleID", announcementDTO.RoleDTO1);
                    cmd.Parameters.AddWithValue("text", announcementDTO.Text);
                    cmd.Parameters.AddWithValue("title", announcementDTO.Title);
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public List<AnnouncementDTO> GetAllAnnouncements()
        {
            List<AnnouncementDTO> announcementList = new List<AnnouncementDTO>();

            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "SELECT * FROM Announcements";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var announcementDTO = new AnnouncementDTO
                        {
                            AnnouncementId = Convert.ToInt32(dr["announcementID"]),
                            RoleDTO1 = Convert.ToInt32(dr["roleID"]),
                            Text = dr["text"].ToString(),
                            Title = dr["title"].ToString()
                        };
                        announcementList.Add(announcementDTO);
                    }
                    return announcementList;
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public List<AnnouncementDTO> GetAnnouncementsByRole(int id)
        {
            List<AnnouncementDTO> announcementList = new List<AnnouncementDTO>();

            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "SELECT * FROM Announcements WHERE roleID = @roleID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@roleID", id);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var announcementDTO = new AnnouncementDTO
                        {
                            AnnouncementId = Convert.ToInt32(dr["announcementID"]),
                            RoleDTO1 = Convert.ToInt32(dr["roleID"]),
                            Text = dr["text"].ToString(),
                            Title = dr["title"].ToString()
                        };
                        announcementList.Add(announcementDTO);
                    }
                    return announcementList;
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
        public AnnouncementDTO GetAnnouncementByID(int id)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "SELECT * FROM Announcements WHERE announcementID = @announcementID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@announcementID", id);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var announcementDTO = new AnnouncementDTO()
                        {
                            AnnouncementId = Convert.ToInt32(dr["announcementID"]),
                            RoleDTO1 = Convert.ToInt32(dr["roleID"]),
                            Text = dr["text"].ToString(),
                            Title = dr["title"].ToString()
                        };

                        return announcementDTO;
                    }

                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }
        

        }
    }

