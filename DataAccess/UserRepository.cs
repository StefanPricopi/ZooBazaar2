
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Logic.Entities;
using Logic.Interfaces;
using Logic.DTO;

namespace DataAccess
{
    public class UserRepository : Connection, IUser
    {
        public User Login(string username, string password)
        {
            User currentUser = GetCurrentUserByEmail(username); // Call the method via IUser

            if (username == currentUser.Email && currentUser.Password == password)
            {
                return currentUser;

            }

            return null;
        }
        
        public User GetCurrentUserByEmail(string userEmail)

        {

            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM users WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Email", userEmail);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        var userDTO = new UserDTO
                        {
                            Email = dr["Email"].ToString(),
                            Password = dr["Password"].ToString(),
                            Name = dr["Name"].ToString(),
                            ClearanceLevel = Convert.ToInt32(dr["ClearanceLevel"])
                        };
                        return new User(userDTO); // Create a User object from the UserDTO
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
            }
            
            return null; // Return null if no user with the specified email is found
        }
        public bool InsertDummyUser(UserDTO userDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "INSERT INTO users (Email, Password, Name, ClearanceLevel) VALUES (@Email, @Password, @Name, @ClearanceLevel)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@Password", userDTO.Password);
                    cmd.Parameters.AddWithValue("@Name", userDTO.Name);
                    cmd.Parameters.AddWithValue("@ClearanceLevel", userDTO.ClearanceLevel);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
                return false;
            }
        }
        public bool CreateAccount(UserDTO userDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "INSERT INTO users (Email, Password, Name, ClearanceLevel) VALUES (@Email, @Password, @Name, @ClearanceLevel)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@Password", userDTO.Password);
                    cmd.Parameters.AddWithValue("@Name", userDTO.Name);
                    cmd.Parameters.AddWithValue("@ClearanceLevel", userDTO.ClearanceLevel);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
                return false;
            }
        }

        public List<UserDTO> GetAllAccounts()
        {
            bool passed;
            List<UserDTO> accounts = new List<UserDTO>();
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM users";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        var userDTO = new UserDTO
                        {
                            Email = dr["Email"].ToString(),
                            Password = dr["Password"].ToString(),
                            Name = dr["Name"].ToString(),
                            ClearanceLevel = Convert.ToInt32(dr["ClearanceLevel"])
                        };
                        accounts.Add(userDTO);
                    }
                    passed = true;
                }
            }   
            catch (Exception ex)
            {
                passed = false;
                // Handle the exception (e.g., log the error)
            }

            if (passed == true)
            {
                return accounts;
            }
            else
            {
                return null;
            }
        }

        public bool UpdateAccount(UserDTO userDTO)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "UPDATE users SET Password = @Password, Name = @Name, ClearanceLevel = @ClearanceLevel WHERE Email = @Email";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@Password", userDTO.Password);
                    cmd.Parameters.AddWithValue("@Name", userDTO.Name);
                    cmd.Parameters.AddWithValue("@ClearanceLevel", userDTO.ClearanceLevel);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
                return false;
            }
        }
    }
}
