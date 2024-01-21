using Logic.DTO;
using Logic.Entities;
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
                    cmd.Parameters.AddWithValue("roleID", announcementDTO.RoleDTO1 + 1);
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
                            RoleDTO1 = Convert.ToInt32(dr["roleID"]) - 1,
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
                    cmd.Parameters.AddWithValue("@roleID", id - 1);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var announcementDTO = new AnnouncementDTO
                        {
                            AnnouncementId = Convert.ToInt32(dr["announcementID"]),
                            RoleDTO1 = Convert.ToInt32(dr["roleID"]) - 1,
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
                            RoleDTO1 = Convert.ToInt32(dr["roleID"]) - 1,
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

        public bool UpdateAnnouncement(AnnouncementDTO announcementDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "UPDATE Announcements SET roleID = @roleID, text = @text, title= @title WHERE announcementID= @announcementID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("announcementID", announcementDTO.AnnouncementId);
                    cmd.Parameters.AddWithValue("roleID", announcementDTO.RoleDTO1 + 1);
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

        public bool DeleteAnnouncement(AnnouncementDTO announcementDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "DELETE FROM Announcements WHERE announcementID= @announcementID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("announcementID", announcementDTO.AnnouncementId);

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

        public AnnouncementDTO GetTheLastAnnouncementForAll(int id)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "SELECT TOP 1 * FROM Announcements WHERE roleID = @roleID ORDER BY AnnouncementID DESC";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@roleID", id - 1);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var announcementDTO = new AnnouncementDTO
                        {
                            AnnouncementId = Convert.ToInt32(dr["announcementID"]),
                            RoleDTO1 = Convert.ToInt32(dr["roleID"]) - 1,
                            Text = dr["text"].ToString(),
                            Title = dr["title"].ToString()
                        };
                        return announcementDTO;
                    }
                    return null;   
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
                return null;
            }
        }
    }
}

