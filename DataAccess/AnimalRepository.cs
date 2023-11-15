using Logic.DTO;
using Logic.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AnimalRepository : Connection,IAnimal
    {
        public bool CreateAnimal(AnimalDTO animalDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "INSERT INTO animals (Name, Regio, DateOfBirth, Regnum, Phylum, Classis, Ordo, Familia, Genus, Species, History, Status, Diet, SpecialDiet, EmployeeID, LocationID) VALUES (@Name, @Regio, @DateOfBirth, @Regnum, @Phylum, @Classis, @Ordo, @Familia, @Genus, @Species, @History, @Status, @Diet, @SpecialDiet, @EmployeeID, @LocationID)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Name", animalDTO.Name);
                    cmd.Parameters.AddWithValue("@Regio", animalDTO.Regio);
                    cmd.Parameters.AddWithValue("@DateOfBirth", animalDTO.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Regnum", animalDTO.Regnum);
                    cmd.Parameters.AddWithValue("@Phylum", animalDTO.Phylum);
                    cmd.Parameters.AddWithValue("@Classis", animalDTO.Classis);
                    cmd.Parameters.AddWithValue("@Ordo", animalDTO.Ordo);
                    cmd.Parameters.AddWithValue("@Familia", animalDTO.Familia);
                    cmd.Parameters.AddWithValue("@Genus", animalDTO.Genus);
                    cmd.Parameters.AddWithValue("@Species", animalDTO.Species);
                    cmd.Parameters.AddWithValue("@History", animalDTO.History);
                    cmd.Parameters.AddWithValue("@Status", animalDTO.Status);
                    cmd.Parameters.AddWithValue("@Diet", animalDTO.Diet);
                    cmd.Parameters.AddWithValue("@SpecialDiet", animalDTO.SpecialDiet);
                    cmd.Parameters.AddWithValue("@EmployeeID", animalDTO.EmployeeID);
                    cmd.Parameters.AddWithValue("@LocationID", DBNull.Value);
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

        public List<AnimalDTO> GetAllAnimals()
        {
            bool passed;
            List<AnimalDTO> animals = new List<AnimalDTO>();
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM animals";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var animalDTO = new AnimalDTO
                        {
                            AnimalID = Convert.ToInt32(dr["AnimalID"]),
                            Name = dr["Name"].ToString(),
                            Regio = dr["Regio"].ToString(),
                            Regnum = dr["Regnum"].ToString(),
                            Phylum = dr["Phylum"].ToString(),
                            Classis = dr["Classis"].ToString(),
                            Ordo = dr["Ordo"].ToString(),
                            Familia = dr["Familia"].ToString(),
                            Genus = dr["Genus"].ToString(),
                            Species = dr["Species"].ToString(),
                            History = dr["History"].ToString(),
                            Status = dr["Status"].ToString(),
                            Diet = dr["Diet"].ToString(),
                            SpecialDiet = dr["SpecialDiet"].ToString()
                        };

                        if (DateTime.TryParse(dr["DateOfBirth"].ToString(), out DateTime dateOfBirth))
                        {
                            animalDTO.DateOfBirth = dateOfBirth;
                        }
                        else
                        {
                            animalDTO.DateOfBirth = DateTime.MinValue;
                        }

                        if (Int32.TryParse(dr["EmployeeID"].ToString(), out Int32 employeeID))
                        {
                            animalDTO.EmployeeID = employeeID;
                        }
                        else
                        {
                            animalDTO.EmployeeID = 0;
                        }

                        if (Int32.TryParse(dr["LocationID"].ToString(), out Int32 locationID))
                        {
                            animalDTO.LocationID = locationID;
                        }
                        else
                        {
                            animalDTO.LocationID = 0;
                        }

                        animals.Add(animalDTO);
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
                return animals;
            }
            else
            {
                return null;
            }
        }

        public bool UpdateAnimal(AnimalDTO animalDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "UPDATE animals SET Name = @Name, Regio = @Regio, DateOfBirth = @DateOfBirth, Regnum = @Regnum, Phylum = @Phylum, Classis = @Classis, Ordo = @Ordo, Familia = @Familia, Genus = @Genus, Species = @Species, History = @History, Status = @Status, Diet = @Diet, SpecialDiet = @SpecialDiet, EmployeeID = @EmployeeID, LocationID = @LocationID WHERE AnimalID = @AnimalID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@AnimalID", animalDTO.AnimalID);
                    cmd.Parameters.AddWithValue("@Name", animalDTO.Name);
                    cmd.Parameters.AddWithValue("@Regio", animalDTO.Regio);
                    cmd.Parameters.AddWithValue("@DateOfBirth", animalDTO.DateOfBirth);
                    cmd.Parameters.AddWithValue("@Regnum", animalDTO.Regnum);
                    cmd.Parameters.AddWithValue("@Phylum", animalDTO.Phylum);
                    cmd.Parameters.AddWithValue("@Classis", animalDTO.Classis);
                    cmd.Parameters.AddWithValue("@Ordo", animalDTO.Ordo);
                    cmd.Parameters.AddWithValue("@Familia", animalDTO.Familia);
                    cmd.Parameters.AddWithValue("@Genus", animalDTO.Genus);
                    cmd.Parameters.AddWithValue("@Species", animalDTO.Species);
                    cmd.Parameters.AddWithValue("@History", animalDTO.History);
                    cmd.Parameters.AddWithValue("@Status", animalDTO.Status);
                    cmd.Parameters.AddWithValue("@Diet", animalDTO.Diet);
                    cmd.Parameters.AddWithValue("@SpecialDiet", animalDTO.SpecialDiet);
                    cmd.Parameters.AddWithValue("@EmployeeID", animalDTO.EmployeeID);
                    cmd.Parameters.AddWithValue("@LocationID", animalDTO.LocationID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SqlException: {ex.Message}");
                Console.WriteLine($"Error Number: {ex.Number}");
                Console.WriteLine($"Line Number: {ex.LineNumber}");
                // Additional details can be logged as needed
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating animal: {ex.Message}");
                return false;
            }
        }
        public bool CreateAnimalToLocationList(int animalID, int locationID)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "INSERT INTO AnimalToLocationList (AnimalID, LocationID) VALUES (@AnimalID, @LocationID)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@AnimalID", animalID);
                    cmd.Parameters.AddWithValue("@LocationID", locationID);
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
