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
    public class AnimalRepository : Connection,IAnimal
    {
        public bool CreateAnimal(AnimalDTO animalDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "INSERT INTO animals (Name, Regio, DateOfBirth, Regnum, Phylum, Classis, Ordo, Familia, Genus, Species, History, Status, Diet, SpecialDiet) VALUES (@Name, @Regio, @DateOfBirth, @Regnum, @Phylum, @Classis, @Ordo, @Familia, @Genus, @Species, @History, @Status, @Diet, @SpecialDiet)";
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
                    cmd.Parameters.AddWithValue("@History", animalDTO.History);
                    cmd.Parameters.AddWithValue("@Status", animalDTO.Status);
                    cmd.Parameters.AddWithValue("@Diet", animalDTO.Diet);
                    cmd.Parameters.AddWithValue("@SpecialDiet", animalDTO.SpecialDiet);
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
                            AnimalID = Convert.ToInt32(dr["animalID"]),
                            Name = dr["Name"].ToString(),
                            Regio = dr["Regio"].ToString(),
                            DateOfBirth = (DateOnly)dr["status"],
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
                    string sql = "UPDATE animals SET Name = @Name, Regio = @Regio, DateOfBirth = @DateOfBirth, Regnum = @Regnum, Phylum = @Phylum, Classis = @Classis, Ordo = @Ordo, Familia = @Familia, Genus = @Genus, Species = @Species, History = @History, Status = @Status, Diet = @Diet, SpecialDiet = @SpecialDiet WHERE AnimaLID = AnimalID";
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
                    cmd.Parameters.AddWithValue("@History", animalDTO.History);
                    cmd.Parameters.AddWithValue("@Status", animalDTO.Status);
                    cmd.Parameters.AddWithValue("@Diet", animalDTO.Diet);
                    cmd.Parameters.AddWithValue("@SpecialDiet", animalDTO.SpecialDiet);

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
