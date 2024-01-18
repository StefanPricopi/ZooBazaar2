using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeRepository : Connection, IEmployee
    {
        public DataTable LoadEmployees()
        {
            using (SqlConnection connection = InitializeConection())
            {
                connection.Open();

                string selectQuery = @"
                SELECT 
                    E.EmployeeID, 
                    E.FirstName, 
                    E.LastName, 
                    E.PhoneNumber, 
                    E.DateOfBirth, 
                    E.BSN, 
                    u.UserID,
                    U.Username, 
                    U.Password, 
                    U.Email, 
                    U.Salt, 
                    EC.ContractID, 
                    EC.StartDate, 
                    EC.EndDate, 
                    EC.RoleID, 
                    EC.Salary, 
                    EC.ContractType, 
                    EP.PartnerID, 
                    EP.FirstName AS PartnerFirstName, 
                    EP.LastName AS PartnerLastName, 
                    EP.PhoneNumber AS PartnerPhoneNumber,  
                    EA.AddressID, 
                    EA.StreetName, 
                    EA.City, 
                    EA.ZipCode, 
                    EA.Country
                FROM Employees E
                LEFT JOIN Users U ON E.UserID = U.UserID
                LEFT JOIN EmployeeContracts EC ON E.EmployeeID = EC.EmployeeID
                LEFT JOIN EmployeePartner EP ON E.EmployeeID = EP.EmployeeID
                LEFT JOIN EmployeeAddress EA ON E.EmployeeID = EA.EmployeeID";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable employeeDataTable = new DataTable();
                        adapter.Fill(employeeDataTable);
                        return employeeDataTable;
                    }
                }
            }
        }
    
    public bool DeleteEmployee(EmployeeDTO employeeDTO)
        {
            int uniqueIdentifier = employeeDTO.EmployeeID;


            using (SqlConnection connection = InitializeConection())
            {
                connection.Open();

                // Retrieve the UserID from the Employees table
                string selectQuery = "SELECT UserID FROM Employees WHERE EmployeeID = @UniqueIdentifier";

                int userIdToDelete = -1; // Initialize to an invalid value

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@UniqueIdentifier", uniqueIdentifier);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userIdToDelete = reader.GetInt32(reader.GetOrdinal("UserID"));
                        }
                    }
                }

                // Delete the user from the users table using the retrieved UserID

                string deleteUsersQuery = "DELETE FROM users WHERE UserID = @UserID";

                using (SqlCommand deleteUsersCommand = new SqlCommand(deleteUsersQuery, connection))
                {
                    deleteUsersCommand.Parameters.AddWithValue("@UserID", userIdToDelete);

                    int usersRowsAffected = deleteUsersCommand.ExecuteNonQuery();
                    return usersRowsAffected > 0;


                }

            }
        }

        public bool CreateEmployee(EmployeeDTO employeeDTO, UserDTO userDTO, ContractDTO contractDTO, AddressDTO addressDTO, PartnerDTO partnerDTO, RoleDTO roleDTO)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Insert into User table
                    using (SqlCommand cmdUser = new SqlCommand("INSERT INTO [users] (Username, Email, Password, Salt) VALUES (@Username, @Email, @Password, @Salt); SELECT SCOPE_IDENTITY();", connection))
                    {
                        var salt = DateTime.Now.ToString();
                        var hashedPW = UserManager.HashedPassword($"{userDTO.Password}{salt.Trim()}");

                        cmdUser.Parameters.AddWithValue("@Username", userDTO.Username);
                        cmdUser.Parameters.AddWithValue("@Email", userDTO.Email);
                        cmdUser.Parameters.AddWithValue("@Password", hashedPW);
                        cmdUser.Parameters.AddWithValue("@Salt", salt);

                        int userID = Convert.ToInt32(cmdUser.ExecuteScalar()); // Get the auto-generated UserID

                        // Insert into Employee table with the obtained UserID
                        using (SqlCommand cmdEmployee = new SqlCommand("INSERT INTO Employees (FirstName, LastName, PhoneNumber, DateOfBirth, BSN, UserID) VALUES (@FirstName, @LastName, @PhoneNumber, @DateOfBirth, @BSN, @UserID);SELECT SCOPE_IDENTITY();", connection))
                        {
                            cmdEmployee.Parameters.AddWithValue("@FirstName", employeeDTO.FirstName);
                            cmdEmployee.Parameters.AddWithValue("@LastName", employeeDTO.LastName);
                            cmdEmployee.Parameters.AddWithValue("@PhoneNumber", employeeDTO.PhoneNumber);
                            cmdEmployee.Parameters.AddWithValue("@DateOfBirth", employeeDTO.DateOfBirth);
                            cmdEmployee.Parameters.AddWithValue("@BSN", employeeDTO.BSN);
                            cmdEmployee.Parameters.AddWithValue("@UserID", userID); // Use the obtained UserID
                            
                            int employeeID = Convert.ToInt32(cmdEmployee.ExecuteScalar()); // Get the auto-generated EmployeeID

                            // Insert employee record
                            using (SqlCommand cmdContract = new SqlCommand("INSERT INTO EmployeeContracts (StartDate, EndDate, RoleID, Salary, ContractType, EmployeeID) VALUES (@StartDate, @EndDate, @RoleID, @Salary, @ContractType, @EmployeeID);SELECT SCOPE_IDENTITY();", connection))
                            {
                                cmdContract.Parameters.AddWithValue("@StartDate", contractDTO.StartDate);
                                cmdContract.Parameters.AddWithValue("@EndDate", contractDTO.EndDate);
                                cmdContract.Parameters.AddWithValue("@Salary", contractDTO.Salary);
                                cmdContract.Parameters.AddWithValue("@ContractType", contractDTO.ContractType);
                                cmdContract.Parameters.AddWithValue("@EmployeeID", employeeID);
                                cmdContract.Parameters.AddWithValue("@RoleID", contractDTO.RoleID+1);

                                int contractID = Convert.ToInt32(cmdContract.ExecuteScalar());
                            }

                            // Insert partner data
                            using (SqlCommand cmdPartner = new SqlCommand("INSERT INTO EmployeePartner (FirstName, LastName, PhoneNumber, EmployeeID) VALUES (@FirstName, @LastName, @PhoneNumber, @EmployeeID);SELECT SCOPE_IDENTITY();", connection))
                            {
                                cmdPartner.Parameters.AddWithValue("@FirstName", partnerDTO.FirstName);
                                cmdPartner.Parameters.AddWithValue("@LastName", partnerDTO.LastName);
                                cmdPartner.Parameters.AddWithValue("@PhoneNumber", partnerDTO.PhoneNumber);
                                cmdPartner.Parameters.AddWithValue("@EmployeeID", employeeID);

                                int partnerID = Convert.ToInt32(cmdPartner.ExecuteScalar());
                            }

                            // Insert address data
                            using (SqlCommand cmdAddress = new SqlCommand("INSERT INTO EmployeeAddress (StreetName, City, ZipCode, Country, EmployeeID) VALUES (@StreetName, @City, @ZipCode, @Country, @EmployeeID);SELECT SCOPE_IDENTITY();", connection))
                            {
                                cmdAddress.Parameters.AddWithValue("@StreetName", addressDTO.StreetName);
                                cmdAddress.Parameters.AddWithValue("@City", addressDTO.City);
                                cmdAddress.Parameters.AddWithValue("@ZipCode", addressDTO.ZipCode);
                                cmdAddress.Parameters.AddWithValue("@Country", addressDTO.Country);
                                cmdAddress.Parameters.AddWithValue("@EmployeeID", employeeID);

                                int addressID = Convert.ToInt32(cmdAddress.ExecuteScalar());
                            }

                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (log, rethrow, etc.)
                return false;
            }
        }

        public bool UpdateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, DateOfBirth = @DateOfBirth, BSN = @BSN, Position = @Position WHERE EmployeeID = @EmployeeID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", employeeDTO.FirstName);
                        command.Parameters.AddWithValue("@LastName", employeeDTO.LastName);
                        command.Parameters.AddWithValue("@PhoneNumber", employeeDTO.PhoneNumber);
                        command.Parameters.AddWithValue("@DateOfBirth", employeeDTO.DateOfBirth);
                        command.Parameters.AddWithValue("@BSN", employeeDTO.BSN);
                        command.Parameters.AddWithValue("@RoleID", employeeDTO.RoleID);
                        command.Parameters.AddWithValue("@EmployeeID", employeeDTO.EmployeeID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0; // Return true if at least one row was affected by the update.
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateEmployeeLoginDetails(UserDTO userDTO)
        {
            string salt = DateTime.Now.ToString();
            var hashedPW = UserManager.HashedPassword($"{userDTO.Password}{salt.Trim()}");
            try
            {
                using (SqlConnection connection = InitializeConection())
                {

                    connection.Open();

                    string updateQuery = "UPDATE users SET Username = @Username, Password = @Password, Email = @Email, Salt = @Salt WHERE UserID = @UserID";



                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", userDTO.Username);
                        command.Parameters.AddWithValue("@Password", hashedPW);
                        command.Parameters.AddWithValue("@Email", userDTO.Email);
                        command.Parameters.AddWithValue("@Salt", salt);
                        command.Parameters.AddWithValue("@UserID", userDTO.UserID);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateEmployeeContract(ContractDTO contractDTO)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE EmployeeContracts SET StartDate = @StartDate, EndDate = @EndDate, RoleID = @RoleID, Salary = @Salary, ContractType = @ContractType WHERE ContractID = @ContractID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", contractDTO.StartDate);
                        command.Parameters.AddWithValue("@EndDate", contractDTO.EndDate);
                        command.Parameters.AddWithValue("@RoleID", contractDTO.RoleID);
                        command.Parameters.AddWithValue("@Salary", contractDTO.Salary);
                        command.Parameters.AddWithValue("@ContractType", contractDTO.ContractType);
                        command.Parameters.AddWithValue("@ContractID", contractDTO.ContractID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0; // Return true if at least one row was affected by the update.
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateEmployeePartner(PartnerDTO partnerDTO)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE EmployeePartner SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber WHERE PartnerID = @PartnerID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", partnerDTO.FirstName);
                        command.Parameters.AddWithValue("@LastName", partnerDTO.LastName);
                        command.Parameters.AddWithValue("@PhoneNumber", partnerDTO.PhoneNumber);
                        command.Parameters.AddWithValue("@PartnerID", partnerDTO.PartnerID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0; // Return true if at least one row was affected by the update.
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateEmployeeAddress(AddressDTO addressDTO)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE EmployeeAddress SET StreetName = @StreetName, City = @City, ZipCode = @ZipCode, Country = @Country WHERE AddressID = @AddressID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StreetName", addressDTO.StreetName);
                        command.Parameters.AddWithValue("@City", addressDTO.City);
                        command.Parameters.AddWithValue("@ZipCode", addressDTO.ZipCode);
                        command.Parameters.AddWithValue("@AddressID", addressDTO.AddressID);
                        command.Parameters.AddWithValue("@Country", addressDTO.Country);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0; // Return true if at least one row was affected by the update.
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateAllTables(EmployeeDTO employeeDTO, UserDTO userDTO, ContractDTO contractDTO, PartnerDTO partnerDTO, AddressDTO addressDTO)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string updateQuery = @"
                UPDATE Employees
                SET FirstName = @EmployeeFirstName, LastName = @EmployeeLastName, PhoneNumber = @EmployeePhoneNumber,
                    DateOfBirth = @EmployeeDateOfBirth, BSN = @EmployeeBSN
                WHERE EmployeeID = @EmployeeID;

                UPDATE Users
                SET Username = @UserUsername, Password = @UserPassword, Email = @UserEmail, Salt = @UserSalt
                WHERE UserID = @UserID;

                UPDATE EmployeeContracts
                SET StartDate = @ContractStartDate, EndDate = @ContractEndDate, RoleID = @ContractRoleID,
                    Salary = @ContractSalary, ContractType = @ContractType
                WHERE ContractID = @ContractID;

                UPDATE EmployeePartner
                SET FirstName = @PartnerFirstName, LastName = @PartnerLastName, PhoneNumber = @PartnerPhoneNumber
                WHERE PartnerID = @PartnerID;

                UPDATE EmployeeAddress
                SET StreetName = @AddressStreetName, City = @AddressCity, ZipCode = @AddressZipCode, Country = @AddressCountry
                WHERE AddressID = @AddressID;";
                    
                    
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters for the query
                        AddParameter(command, "@EmployeeID", employeeDTO.EmployeeID);
                        AddParameter(command, "@EmployeeFirstName", employeeDTO.FirstName);
                        AddParameter(command, "@EmployeeLastName", employeeDTO.LastName);
                        AddParameter(command, "@EmployeePhoneNumber", employeeDTO.PhoneNumber);
                        AddParameter(command, "@EmployeeDateOfBirth", employeeDTO.DateOfBirth);
                        AddParameter(command, "@EmployeeBSN", employeeDTO.BSN);

                        AddParameter(command, "@UserID", userDTO.UserID);
                        AddParameter(command, "@UserUsername", userDTO.Username);
                        AddParameter(command, "@UserPassword", userDTO.Password);
                        AddParameter(command, "@UserEmail", userDTO.Email);
                        AddParameter(command, "@UserSalt", userDTO.Salt);

                        AddParameter(command, "@ContractID", contractDTO.ContractID);
                        AddParameter(command, "@ContractStartDate", contractDTO.StartDate);
                        AddParameter(command, "@ContractEndDate", contractDTO.EndDate);
                        AddParameter(command, "@ContractRoleID", contractDTO.RoleID+1);
                        AddParameter(command, "@ContractSalary", contractDTO.Salary);
                        AddParameter(command, "@ContractType", contractDTO.ContractType);

                        AddParameter(command, "@PartnerID", partnerDTO.PartnerID);
                        AddParameter(command, "@PartnerFirstName", partnerDTO.FirstName);
                        AddParameter(command, "@PartnerLastName", partnerDTO.LastName);
                        AddParameter(command, "@PartnerPhoneNumber", partnerDTO.PhoneNumber);

                        AddParameter(command, "@AddressID", addressDTO.AddressID);
                        AddParameter(command, "@AddressStreetName", addressDTO.StreetName);
                        AddParameter(command, "@AddressCity", addressDTO.City);
                        AddParameter(command, "@AddressZipCode", addressDTO.ZipCode);
                        AddParameter(command, "@AddressCountry", addressDTO.Country);

                        // Execute the query
                        command.ExecuteNonQuery();

                        return true; // If the query executes successfully
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void AddParameter(SqlCommand command, string parameterName, object value)
        {
            command.Parameters.AddWithValue(parameterName, value);
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
        public EmployeeDTO GetEmployeeById(int employeeID)
        {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM Employees WHERE EmployeeID = @EmployeeID";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        var employeeDTO = new EmployeeDTO
                        {
                            EmployeeID = Convert.ToInt32(dr["EmployeeID"]),
                            FirstName = dr["FirstName"].ToString(),
                            LastName = dr["LastName"].ToString(),
                            PhoneNumber = dr["PhoneNumber"].ToString(),
                            DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]),
                            BSN = Convert.ToInt32( dr["BSN"]),
                            RoleID = Convert.ToInt32(dr["RoleID"]) // Adjust based on your actual column names
                        };

                        return employeeDTO; // Create an Employee object from the EmployeeDTO
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error)
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return null; // Return null if no employee with the specified ID is found
        }



    }
}

