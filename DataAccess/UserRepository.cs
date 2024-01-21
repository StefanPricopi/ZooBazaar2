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

        public UserDTO LoginByRfid(string rfid)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM users WHERE Rfid = @rfid";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@rfid", rfid);

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
                            Rfid = dr["Rfid"].ToString(),


                        };
                        return userDTO; // Create a User object from the UserDTO
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
            }

            return null; // Return null if no user with the specified email is found
        }

        public string RetrievePositionInformation(string username)
        {
            User currentUser = GetCurrentUserByUsername(username);
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();

                    // Step 1: Get the employeeID from the Employees table
                    string employeeIdQuery = "SELECT EmployeeID FROM Employees WHERE UserID = @UserID";
                    SqlCommand employeeIdCmd = new SqlCommand(employeeIdQuery, conn);
                    employeeIdCmd.Parameters.AddWithValue("@UserID", currentUser.UserID);

                    int employeeID;
                    object result = employeeIdCmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out employeeID))
                    {
                        // Step 2: Use the obtained employeeID to retrieve the RoleID from the EmployeeContracts table
                        string roleIdQuery = "SELECT RoleID FROM EmployeeContracts WHERE EmployeeID = @EmployeeID";
                        SqlCommand roleIdCmd = new SqlCommand(roleIdQuery, conn);
                        roleIdCmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                        SqlDataReader dr = roleIdCmd.ExecuteReader();

                        if (dr.Read())
                        {
                            string roleDTO = dr["RoleID"].ToString();
                            return roleDTO;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                Console.WriteLine("Error: " + ex.Message);
            }

            // Return a default value or handle the case where no data is found
            return null;
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
        public UserDTO FindUserByProvidedUsername(string username)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = @"
                SELECT u.*, e.EmployeeID, v.VisitorID
                FROM Users u
                LEFT JOIN Employees e ON u.UserID = e.UserID
                LEFT JOIN Visitors v ON u.UserID = v.UserID
                WHERE u.Username = @Username;
            ";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", username);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        string compareEmp = dr["EmployeeID"].ToString();
                        string compareVis = dr["VisitorID"].ToString();
                        if (compareEmp == "")
                        {
                            var userDTO = new UserDTO
                            {
                                UserID = Convert.ToInt32(dr["UserID"]),
                                Username = dr["Username"].ToString(),
                                Password = dr["Password"].ToString(),
                                Email = dr["Email"].ToString(),
                                Salt = dr["Salt"].ToString(),
                                VisitorID = Convert.ToInt32(dr["VisitorID"]),
                            };
                            return userDTO;
                        }
                        else if (compareVis == "")
                        {
                            var userDTO = new UserDTO
                            {
                                UserID = Convert.ToInt32(dr["UserID"]),
                                Username = dr["Username"].ToString(),
                                Password = dr["Password"].ToString(),
                                Email = dr["Email"].ToString(),
                                Salt = dr["Salt"].ToString(),
                                EmployeeID = Convert.ToInt32(dr["EmployeeID"]),
                                
                            };
                            return userDTO;
                        }
                        
                        
                    }
                }
            }
            catch (Exception ex)
            {
                
            }

            return null; // Return null if no user with the specified username is found
        }
        public UserDTO GetCurrentUserByUsernameForVisitor(string username)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = @"
                SELECT u.*, v.*
                FROM Visitors v
                FROM Employees e  
                LEFT JOIN users v ON u.UserID = v.UserID
                LEFT JOIN users u ON u.UserID = e.UserID
                WHERE u.Username = @Username;
            ";
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
                            VisitorID = Convert.ToInt32(dr["VisitorID"])
                        };
                        return userDTO;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
            }

            return null; // Return null if no user with the specified username is found
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
                    conn.Open();

                    // Check if the username already exists
                    string checkUsernameQuery = "SELECT COUNT(*) FROM users WHERE Username = @Username";
                    SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, conn);
                    checkUsernameCmd.Parameters.AddWithValue("@Username", userDTO.Username);
                    int existingUserCount = (int)checkUsernameCmd.ExecuteScalar();

                    if (existingUserCount > 0)
                    {
                        throw new Exception("Username already exists");
                    }

                    // Check if the email already exists
                    string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE Email = @Email";
                    SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, conn);
                    checkEmailCmd.Parameters.AddWithValue("@Email", userDTO.Email);
                    int existingEmailCount = (int)checkEmailCmd.ExecuteScalar();

                    if (existingEmailCount > 0)
                    {
                        throw new Exception("Email already exists");
                    }

                    // If both username and email are unique, proceed with the insertion
                    string insertQuery = "INSERT INTO users (Username, Password, Email, Salt) VALUES (@Username, @Password, @Email, @Salt)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@Username", userDTO.Username);
                    cmd.Parameters.AddWithValue("@Password", hashedPW);
                    cmd.Parameters.AddWithValue("@Email", userDTO.Email);
                    cmd.Parameters.AddWithValue("@Salt", salt);

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
                    conn.Open();

                    // Check if the new username already exists
                    string checkUsernameQuery = "SELECT COUNT(*) FROM users WHERE Username = @NewUsername AND UserID <> @UserID";
                    using (SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, conn))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("@NewUsername", userDTO.Username);
                        checkUsernameCmd.Parameters.AddWithValue("@UserID", userDTO.UserID);
                        int existingUserCount = (int)checkUsernameCmd.ExecuteScalar();

                        if (existingUserCount > 0)
                        {
                            throw new Exception("Username already exists");
                        }
                    }

                    // Check if the new email already exists
                    string checkEmailQuery = "SELECT COUNT(*) FROM users WHERE Email = @NewEmail AND UserID <> @UserID";
                    using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, conn))
                    {
                        checkEmailCmd.Parameters.AddWithValue("@NewEmail", userDTO.Email);
                        checkEmailCmd.Parameters.AddWithValue("@UserID", userDTO.UserID);
                        int existingEmailCount = (int)checkEmailCmd.ExecuteScalar();

                        if (existingEmailCount > 0)
                        {
                            throw new Exception("Email already exists");
                        }
                    }

                    // If both new username and email are unique, proceed with the update
                    string sql = "UPDATE users SET Username = @NewUsername, Password = @Password, Email = @NewEmail, Salt = @Salt WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewUsername", userDTO.Username);
                        cmd.Parameters.AddWithValue("@Password", userDTO.Password);
                        cmd.Parameters.AddWithValue("@NewEmail", userDTO.Email);
                        cmd.Parameters.AddWithValue("@Salt", userDTO.Salt);
                        cmd.Parameters.AddWithValue("@UserID", userDTO.UserID);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
                return false;
            }
        }



        public bool CreateVisitor(UserDTO userDTO)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Check if the username already exists
                    string checkUsernameQuery = "SELECT COUNT(*) FROM [users] WHERE Username = @Username";
                    using (SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, connection))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("@Username", userDTO.Username);
                        int existingUserCount = (int)checkUsernameCmd.ExecuteScalar();

                        if (existingUserCount > 0)
                        {
                            throw new Exception("Username already exists");
                            
                        }
                    }

                    // Check if the email already exists
                    string checkEmailQuery = "SELECT COUNT(*) FROM [users] WHERE Email = @Email";
                    using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, connection))
                    {
                        checkEmailCmd.Parameters.AddWithValue("@Email", userDTO.Email);
                        int existingEmailCount = (int)checkEmailCmd.ExecuteScalar();

                        if (existingEmailCount > 0)
                        {
                            throw new Exception("Email already exists");
                        }
                    }

                    // If both username and email are unique, proceed with the insertion
                    using (SqlCommand cmdUser = new SqlCommand("INSERT INTO [users] (Username, Password, Salt, Email) VALUES (@Username, @Password, @Salt, @Email); SELECT SCOPE_IDENTITY();", connection))
                    {
                        var salt = DateTime.Now.ToString();
                        var hashedPW = UserManager.HashedPassword($"{userDTO.Password}{salt.Trim()}");

                        cmdUser.Parameters.AddWithValue("@Username", userDTO.Username);
                        cmdUser.Parameters.AddWithValue("@Password", hashedPW);
                        cmdUser.Parameters.AddWithValue("@Salt", salt);
                        cmdUser.Parameters.AddWithValue("@Email", userDTO.Email);

                        int userID = Convert.ToInt32(cmdUser.ExecuteScalar()); // Get the auto-generated UserID

                        // Insert into Visitors table with the obtained UserID
                        using (SqlCommand cmdVisitor = new SqlCommand("INSERT INTO Visitors (UserID) VALUES (@UserID);", connection))
                        {
                            cmdVisitor.Parameters.AddWithValue("@UserID", userID); // Use the obtained UserID
                            cmdVisitor.ExecuteNonQuery(); // Insert visitor record
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public int GetEmpIDbyUserId(int id)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();


                    using (SqlCommand command = new SqlCommand("SELECT EmployeeId \r\nFROM Employees \r\nWHERE UserId = @UserId\r\n", connection))
                    {
                        command.Parameters.Add(new SqlParameter("@UserId", id));
                        object result = command.ExecuteScalar();
                        int EmpId = Convert.ToInt32(result);
                        return EmpId;
                    }

                }
            }
            catch (Exception ex)
            {
                return -1;
            }

        }
        public void ChangePassword(int userId, string oldPassword, string newPassword, string confirmNewPassword)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Validate old password before proceeding
                    string hashedOldPassword = GetHashedPassword(userId, oldPassword);

                    if (hashedOldPassword != GetUserPassword(userId))
                    {
                        // Old password does not match, handle accordingly (throw exception, show error message, etc.)
                    }

                    // Validate new password and confirm new password
                    if (newPassword != confirmNewPassword)
                    {
                        // New password and confirm password do not match, handle accordingly (throw exception, show error message, etc.)
                    }

                    // Update the password
                    string salt = DateTime.Now.ToString();
                    string hashedNewPassword = UserManager.HashedPassword($"{newPassword}{salt.Trim()}");

                    using (SqlCommand cmd = new SqlCommand("UPDATE [Users] SET Password = @Password, Salt = @Salt WHERE UserID = @UserID", connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Password", hashedNewPassword);
                        cmd.Parameters.AddWithValue("@Salt", salt);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
        }

        public string GetHashedPassword(int userId, string password)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT Password, Salt FROM [users] WHERE UserID = @UserID", connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader["Password"].ToString();
                                string salt = reader["Salt"].ToString();

                                // Hash the provided password with the stored salt
                                return UserManager.HashedPassword($"{password}{salt}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log, or throw accordingly
                throw new Exception("Failed to get hashed password", ex);
            }

            return null;
        }

        public string GetUserPassword(int userId)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT Password FROM [users] WHERE UserID = @UserID", connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);

                        object result = cmd.ExecuteScalar();

                        return result != null ? result.ToString() : null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log, or throw accordingly
                throw new Exception("Failed to get user password", ex);
            }
        }
    }
}
