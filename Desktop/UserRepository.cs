
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
using Logic.Managers;

namespace DataAccess
{
    public class UserRepository : Connection, IUser
    {
        public User Login(string username, string password)
        {
            User currentUser = GetCurrentUserByUsername(username); // Call the method via IUser
            var userhashedpass = UserManager.HashedPassword($"{password}{currentUser.Salt.Trim()}");
            
            if (username == currentUser.Username && userhashedpass == currentUser.Password)
            {
                return currentUser;

            }

            return null;
        }

        public string RetrievePositionInformation(string username)
        {
            User currentUser = GetCurrentUserByUsername(username);
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Employees WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string userDTO = dr["Position"].ToString();
                        
                        return userDTO; 
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
            }
            
            return null; // Return null if no user with the specified email is found
        }
        public User GetCurrentUserByUsername(string username)

        {

            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM users WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        var userDTO = new UserDTO
                        {
                            UserID = Convert.ToInt32(dr["UserID"]),
                            Username = dr["Username"].ToString(),
                            Password = dr["Password"].ToString(),
                            Email = dr["Email"].ToString(),
                            Salt = dr["Salt"].ToString(),


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
                    string sql = "INSERT INTO users (Username, Password, Email, Salt) VALUES (@Username, @Password, @Email, @Salt)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", userDTO.Username);
                    cmd.Parameters.AddWithValue("@Password", userDTO.Password);
                    cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@Salt", userDTO.Salt);
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
                var salt = DateTime.Now.ToString();
                var hashedPW = UserManager.HashedPassword($"{userDTO.Password}{salt.Trim()}");
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "INSERT INTO users (Username, Password, Email, Salt) VALUES (@Username, @Password, @Email, @Salt)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", userDTO.Username);
                    cmd.Parameters.AddWithValue("@Password", hashedPW);
                    cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@Salt", salt);
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
                            UserID = Convert.ToInt32(dr["UserID"]),
                            Username = dr["Username"].ToString(),
                            Password = dr["Password"].ToString(),
                            Email = dr["Email"].ToString(),
                            Salt = dr["Salt"].ToString(),
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
                    string sql = "UPDATE users SET Username = @Username, Password = @Password, Email = @Email, Salt = @Salt WHERE Username = @Username";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", userDTO.Username);
                    cmd.Parameters.AddWithValue("@Password", userDTO.Password);
                    cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@Salt", userDTO.Salt);
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
