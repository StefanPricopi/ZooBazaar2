using Logic.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Logic.Entities;
using Logic.Interfaces;

namespace DataAccess
{
    public class LocationRepository : Connection, ILocation
    {
        public bool CreateLocation(LocationDTO locationDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "INSERT INTO zooLocation (areaID, locationName, capacity, status) VALUES (@areaID, @locationName, @capacity, @status)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@areaID", locationDTO.AreaDTO.AreaID);
                    cmd.Parameters.AddWithValue("@locationName", locationDTO.LocationName);
                    cmd.Parameters.AddWithValue("@capacity", locationDTO.Capacity);
                    cmd.Parameters.AddWithValue("@status", locationDTO.Status);
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

        public List<LocationDTO> GetAllLocations()
        {
            bool passed;
            List<LocationDTO> locations = new List<LocationDTO>();
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM zooLocation l INNER JOIN zooArea a ON l.areaID = a.areaID";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var locationDTO = new LocationDTO
                        {
                            LocationID = Convert.ToInt32(dr["locationID"]),
                            AreaDTO = new AreaDTO
                            {
                                AreaID = Convert.ToInt32(dr["areaID"]),
                                AreaName = dr["areaName"].ToString(),
                                Status = dr["status"].ToString()
                            },
                            LocationName = dr["locationName"].ToString(),
                            Capacity = Convert.ToInt32(dr["capacity"]),
                            Status = dr["status"].ToString()
                        };
                        locations.Add(locationDTO);
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
                return locations;
            }
            else
            {
                return null;
            }
        }

        public bool UpdateLocation(LocationDTO locationDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "UPDATE zooLocation SET areaID = @areaID, locationName = @locationName, capacity = @capacity, status = @status WHERE locationID = locationID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@locationID", locationDTO.LocationID);
                    cmd.Parameters.AddWithValue("@areaID", locationDTO.AreaDTO.AreaID);
                    cmd.Parameters.AddWithValue("@locationName", locationDTO.LocationName);
                    cmd.Parameters.AddWithValue("@capacity", locationDTO.Capacity);
                    cmd.Parameters.AddWithValue("@status", locationDTO.Status);

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
