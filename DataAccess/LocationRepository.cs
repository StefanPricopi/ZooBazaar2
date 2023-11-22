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
                    string sql = "INSERT INTO zooLocation (areaID, locationName, capacity, status, currentCapacity) VALUES (@areaID, @locationName, @capacity, @status, @currentCapacity)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@areaID", locationDTO.AreaDTO.AreaID);
                    cmd.Parameters.AddWithValue("@locationName", locationDTO.LocationName);
                    cmd.Parameters.AddWithValue("@capacity", locationDTO.Capacity);
                    cmd.Parameters.AddWithValue("@status", locationDTO.Status);
                    cmd.Parameters.AddWithValue("@currentCapacity", locationDTO.CurrentCapacity);
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
                            Status = dr["status"].ToString(),
                            CurrentCapacity = Convert.ToInt32(dr["currentCapacity"])
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
                    cmd.Parameters.AddWithValue("@currentCapacity", locationDTO.CurrentCapacity);

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

        public LocationDTO GetLocationDetails(int locationID)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM zooLocation l INNER JOIN zooArea a ON l.areaID = a.areaID WHERE locationID = @locationID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@locationID", locationID);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
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
                            Status = dr["status"].ToString(),
                            CurrentCapacity = Convert.ToInt32(dr["currentCapacity"])
                        };

                        return locationDTO;
                    }
                    else
                    {
                        return null; // Location not found
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, log them, or return an appropriate error response
                return null;
            }
        }

        public bool AssignAnimalToLocation(int animalID, int locationID)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    if (IsLocationAtCapacity(locationID))
                    {
                        Console.WriteLine("Error: Location has reached its capacity. Cannot assign animal.");
                        return false;
                    }

                    string updateAnimalSql = "UPDATE animals SET LocationID = @LocationID WHERE AnimalID = @AnimalID";
                    SqlCommand updateAnimalCmd = new SqlCommand(updateAnimalSql, conn);
                    updateAnimalCmd.Parameters.AddWithValue("@LocationID", locationID);
                    updateAnimalCmd.Parameters.AddWithValue("@AnimalID", animalID);
                    conn.Open();
                    updateAnimalCmd.ExecuteNonQuery();

                    string updateLocationSql = "UPDATE zooLocation SET currentCapacity = currentCapacity + 1 WHERE locationID = @locationID";
                    SqlCommand updateLocationCmd = new SqlCommand(updateLocationSql, conn);
                    updateLocationCmd.Parameters.AddWithValue("@locationID", locationID);
                    updateLocationCmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public bool IsLocationAtCapacity(int locationID)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT currentCapacity, capacity FROM zooLocation WHERE locationID = @locationID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@locationID", locationID);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        int currentCapacity = Convert.ToInt32(dr["currentCapacity"]);
                        int capacity = Convert.ToInt32(dr["capacity"]);

                        return currentCapacity >= capacity;
                    }
                    else
                    {
                        // Location not found
                        return true; // Assuming no assignment should be allowed if the location is not found
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, log them, or return an appropriate error response
                Console.WriteLine($"Error: {ex.Message}");
                return true; // Assuming an error means we want to block the assignment
            }
        }

        // ... (other methods)
    }

}

