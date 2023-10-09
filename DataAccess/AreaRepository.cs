using Logic.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Logic.Interfaces;

namespace DataAccess
{
    public class AreaRepository : Connection,IArea
    {
        public bool CreateArea(AreaDTO areaDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "INSERT INTO zooArea (areaName, status) VALUES (@areaName, @status)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@areaName", areaDTO.AreaName);
                    cmd.Parameters.AddWithValue("@status", areaDTO.Status);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public List<AreaDTO> GetAllAreas()
        {
            bool passed;
            List<AreaDTO> areas = new List<AreaDTO>();
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM zooArea";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var areaDTO = new AreaDTO
                        {
                            AreaID = Convert.ToInt32(dr["areaID"]),
                            AreaName = dr["areaName"].ToString(),
                            Status = dr["status"].ToString()
                        };
                        areas.Add(areaDTO);
                    }
                    passed = true;
                }
            }
            catch (Exception ex)
            {
                passed = false;
            }

            if (passed == true)
            {
                return areas;
            }
            else
            {
                return null;
            }
        }

        public bool UpdateArea(AreaDTO areaDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "UPDATE zooArea SET areaName = @areaName, status = @status WHERE areaID = areaID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@areaID", areaDTO.AreaID);
                    cmd.Parameters.AddWithValue("@areaName", areaDTO.AreaName);
                    cmd.Parameters.AddWithValue("@status", areaDTO.Status);
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }


}
