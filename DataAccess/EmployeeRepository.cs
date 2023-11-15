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
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeRepository : Connection, IEmployee
    {
        public (DataTable, DataTable, DataTable, DataTable, DataTable) LoadEmployees()
        {
            using (SqlConnection connection = InitializeConection())
            {
                connection.Open();

                string selectQuery1 = "SELECT EmployeeID, FirstName, LastName, PhoneNumber, DateOfBirth, BSN, UserID, Position FROM Employees";

                using (SqlCommand command1 = new SqlCommand(selectQuery1, connection))
                {
                    using (SqlDataAdapter adapter1 = new SqlDataAdapter(command1))
                    {
                        DataTable employeeDataTable1 = new DataTable();
                        adapter1.Fill(employeeDataTable1);

                        string selectQuery2 = "SELECT UserID, Username, Password, Email, Salt FROM users";

                        using (SqlCommand command2 = new SqlCommand(selectQuery2, connection))
                        {
                            using (SqlDataAdapter adapter2 = new SqlDataAdapter(command2))
                            {
                                DataTable employeeDataTable2 = new DataTable();
                                adapter2.Fill(employeeDataTable2);

                                string selectQuery3 = "SELECT ContractID, StartDate, EndDate, RoleID, Salary, ContractType, EmployeeID FROM EmployeeContracts";
                                using (SqlCommand command3 = new SqlCommand(selectQuery3, connection))
                                {
                                    using (SqlDataAdapter adapter3 = new SqlDataAdapter(command3))
                                    {
                                        DataTable employeeDataTable3 = new DataTable();
                                        adapter3.Fill(employeeDataTable3);

                                        string selectQuery4 = "SELECT PartnerID, FirstName, LastName, PhoneNumber, EmployeeID FROM EmployeePartner";

                                        using (SqlCommand command4 = new SqlCommand(selectQuery4, connection))
                                        {
                                            using (SqlDataAdapter adapter4 = new SqlDataAdapter(command4))
                                            {
                                                DataTable employeeDataTable4 = new DataTable();
                                                adapter4.Fill(employeeDataTable4);

                                                string selectQuery5 = "SELECT AddressID, StreetName, City, ZipCode, Country, EmployeeID FROM EmployeeAddress";

                                                using (SqlCommand command5 = new SqlCommand(selectQuery5, connection))
                                                {
                                                    using (SqlDataAdapter adapter5 = new SqlDataAdapter(command5))
                                                    {
                                                        DataTable employeeDataTable5 = new DataTable();
                                                        adapter5.Fill(employeeDataTable5);

                                                        return (employeeDataTable1, employeeDataTable2, employeeDataTable3, employeeDataTable4, employeeDataTable5);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
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

                    // Insert into User tablestring updateQuery = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, DateOfBirth = @DateOfBirth, BSN = @BSN, Position = @Position WHERE EmployeeID = @EmployeeID";
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
                        using (SqlCommand cmdEmployee = new SqlCommand("INSERT INTO Employees (FirstName, LastName, PhoneNumber, DateOfBirth, BSN, UserID, Position) VALUES (@FirstName, @LastName, @PhoneNumber, @DateOfBirth, @BSN, @UserID, @Position);SELECT SCOPE_IDENTITY();", connection))
                        {
                            cmdEmployee.Parameters.AddWithValue("@FirstName", employeeDTO.FirstName);
                            cmdEmployee.Parameters.AddWithValue("@LastName", employeeDTO.LastName);
                            cmdEmployee.Parameters.AddWithValue("@PhoneNumber", employeeDTO.PhoneNumber);
                            cmdEmployee.Parameters.AddWithValue("@DateOfBirth", employeeDTO.DateOfBirth);
                            cmdEmployee.Parameters.AddWithValue("@BSN", employeeDTO.BSN);
                            cmdEmployee.Parameters.AddWithValue("@UserID", userID); // Use the obtained UserID
                            cmdEmployee.Parameters.AddWithValue("@Position", employeeDTO.Position);

                            int employeeID = Convert.ToInt32(cmdEmployee.ExecuteScalar());
                            cmdEmployee.ExecuteNonQuery();
                            // Insert employee record


                            using (SqlCommand cmdContract = new SqlCommand("INSERT INTO EmployeeContracts (StartDate, EndDate, RoleID, Salary, ContractType, EmployeeID) VALUES (@StartDate, @EndDate, @RoleID, @Salary, @ContractType, @EmployeeID);SELECT SCOPE_IDENTITY();", connection))
                            {
                                cmdContract.Parameters.AddWithValue("@StartDate", contractDTO.StartDate);
                                cmdContract.Parameters.AddWithValue("@EndDate", contractDTO.EndDate);
                                cmdContract.Parameters.AddWithValue("@Salary", contractDTO.Salary);
                                cmdContract.Parameters.AddWithValue("@ContractType", contractDTO.ContractType);
                                cmdContract.Parameters.AddWithValue("@EmployeeID", employeeID);
                                cmdContract.Parameters.AddWithValue("@RoleID", roleDTO.RoleID);

                                int contractID = Convert.ToInt32(cmdContract.ExecuteScalar());
                                cmdContract.ExecuteNonQuery();
                            }
                            //Insert partner data
                            using (SqlCommand cmdPartner = new SqlCommand("INSERT INTO EmployeePartner (FirstName, LastName, PhoneNumber, EmployeeID) VALUES (@FirstName, @LastName, @PhoneNumber, @EmployeeID);SELECT SCOPE_IDENTITY();", connection))
                            {
                               cmdPartner.Parameters.AddWithValue("@FirstName", partnerDTO.FirstName);
                               cmdPartner.Parameters.AddWithValue("@LastName", partnerDTO.LastName);
                               cmdPartner.Parameters.AddWithValue("@PhoneNumber", partnerDTO.PhoneNumber);
                               cmdPartner.Parameters.AddWithValue("@EmployeeID", employeeID);

                               int partnerID = Convert.ToInt32(cmdPartner.ExecuteScalar());
                               cmdPartner.ExecuteNonQuery();
                            }

                            using (SqlCommand cmdAddress = new SqlCommand("INSERT INTO EmployeeAddress (StreetName, City, ZipCode, Country, EmployeeID) VALUES (@StreetName, @City, @ZipCode, @Country, @EmployeeID);SELECT SCOPE_IDENTITY();", connection))
                            {
                                cmdAddress.Parameters.AddWithValue("@StreetName", addressDTO.StreetName);
                                cmdAddress.Parameters.AddWithValue("@City", addressDTO.City);
                                cmdAddress.Parameters.AddWithValue("@ZipCode", addressDTO.ZipCode);
                                cmdAddress.Parameters.AddWithValue("@Country", addressDTO.Country);
                                cmdAddress.Parameters.AddWithValue("@EmployeeID", employeeID);

                                int addressID = Convert.ToInt32(cmdAddress.ExecuteScalar());
                                cmdAddress.ExecuteNonQuery();
                            }
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
                        command.Parameters.AddWithValue("@Position", employeeDTO.Position);
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
    }
}

