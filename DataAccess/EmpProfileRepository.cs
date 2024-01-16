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
    public class EmpProfileRepository : Connection, IEmpProfile
    {
        public EmpProfileDTO GetActualProfileByID(int id)
        {

            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();
                    string selectQuery1 = @"
            SELECT 
                Employees.FirstName, 
                Employees.LastName, 
                Employees.PhoneNumber, 
                Employees.DateOfBirth, 
                EmployeePartner.FirstName AS PartnerFirstName, 
                EmployeePartner.LastName AS PartnerLastName, 
                EmployeePartner.PhoneNumber AS PartnerPhoneNumber, 
                Users.Username, 
                Users.Email, 
                EmployeeAddress.StreetName, 
                EmployeeAddress.Zipcode, 
                EmployeeAddress.City, 
                EmployeeAddress.Country
            FROM 
                Employees
            JOIN 
                EmployeePartner ON Employees.EmployeeID = EmployeePartner.EmployeeID
            JOIN 
                Users ON Employees.UserID = Users.UserID
            JOIN 
                EmployeeAddress ON Employees.EmployeeID = EmployeeAddress.EmployeeID
            WHERE 
                Employees.EmployeeID = @EmployeeID";

                    using (SqlCommand command1 = new SqlCommand(selectQuery1, connection))
                    {
                        command1.Parameters.AddWithValue("@EmployeeID", id);

                        using (SqlDataReader reader = command1.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                EmpProfileDTO u = new EmpProfileDTO();

                                u.employeeID = id;
                                u.email = reader["Email"].ToString();
                                u.lastName = reader["LastName"].ToString();
                                u.firstName = reader["FirstName"].ToString();
                                u.phoneNumber = reader["PhoneNumber"].ToString();
                                u.dateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                                u.partnerFirstName = reader["PartnerFirstName"].ToString();
                                u.partnerLastName = reader["PartnerLastName"].ToString();
                                u.partnerPhoneNumber = reader["PartnerPhoneNumber"].ToString();
                                u.username = reader["Username"].ToString();
                                u.street = reader["StreetName"].ToString();
                                u.zipcode = reader["Zipcode"].ToString();
                                u.city = reader["City"].ToString();
                                u.country = reader["Country"].ToString();

                                return u;
                            }
                            else
                            {
                                throw new Exception("Invalid ID");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid ID");
            }

        }

        public EmpProfileDTO UpdateProfile(EmpProfileDTO updatedProfile)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Fetch the existing profile information
                    EmpProfileDTO currentProfile = GetActualProfileByID(updatedProfile.employeeID);

                    // Build the update query dynamically based on the changes
                    string updateQuery = "UPDATE dbo.Employees SET";
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    // Add checks for personal information
                    if (currentProfile.firstName != updatedProfile.firstName)
                    {
                        updateQuery += " FirstName = @NewFirstName,";
                        parameters.Add(new SqlParameter("@NewFirstName", updatedProfile.firstName));
                    }

                    if (currentProfile.lastName != updatedProfile.lastName)
                    {
                        updateQuery += " LastName = @NewLastName,";
                        parameters.Add(new SqlParameter("@NewLastName", updatedProfile.lastName));
                    }

                    if (currentProfile.phoneNumber != updatedProfile.phoneNumber)
                    {
                        updateQuery += " PhoneNumber = @NewPhoneNumber,";
                        parameters.Add(new SqlParameter("@NewPhoneNumber", updatedProfile.phoneNumber));
                    }

                    if (currentProfile.dateOfBirth != updatedProfile.dateOfBirth)
                    {
                        updateQuery += " DateOfBirth = @NewDateOfBirth,";
                        parameters.Add(new SqlParameter("@NewDateOfBirth", updatedProfile.dateOfBirth));
                    }

                    // Add checks for address information
                    if (currentProfile.street != updatedProfile.street)
                    {
                        updateQuery += " StreetName = @NewStreet,";
                        parameters.Add(new SqlParameter("@NewStreet", updatedProfile.street));
                        UpdateAddressInformation(connection, updatedProfile.employeeID, updatedProfile.street, updatedProfile.zipcode, updatedProfile.city, updatedProfile.country);
                    }

                    if (currentProfile.zipcode != updatedProfile.zipcode)
                    {
                        updateQuery += " ZipCode = @NewZipcode,";
                        parameters.Add(new SqlParameter("@NewZipcode", updatedProfile.zipcode));
                        UpdateAddressInformation(connection, updatedProfile.employeeID, updatedProfile.street, updatedProfile.zipcode, updatedProfile.city, updatedProfile.country);
                    }

                    if (currentProfile.city != updatedProfile.city)
                    {
                        updateQuery += " City = @NewCity,";
                        parameters.Add(new SqlParameter("@NewCity", updatedProfile.city));
                        UpdateAddressInformation(connection, updatedProfile.employeeID, updatedProfile.street, updatedProfile.zipcode, updatedProfile.city, updatedProfile.country);
                    }

                    if (currentProfile.country != updatedProfile.country)
                    {
                        updateQuery += " Country = @NewCountry,";
                        parameters.Add(new SqlParameter("@NewCountry", updatedProfile.country));
                        UpdateAddressInformation(connection, updatedProfile.employeeID, updatedProfile.street, updatedProfile.zipcode, updatedProfile.city, updatedProfile.country);
                    }

                    // Add checks for spouse information
                    if (currentProfile.partnerFirstName != updatedProfile.partnerFirstName)
                    {
                        updateQuery += " FirstName = @NewPartnerFirstName,";
                        parameters.Add(new SqlParameter("@NewPartnerFirstName", updatedProfile.partnerFirstName));
                    }

                    if (currentProfile.partnerLastName != updatedProfile.partnerLastName)
                    {
                        updateQuery += " LastName = @NewPartnerLastName,";
                        parameters.Add(new SqlParameter("@NewPartnerLastName", updatedProfile.partnerLastName));
                    }

                    if (currentProfile.partnerPhoneNumber != updatedProfile.partnerPhoneNumber)
                    {
                        updateQuery += " PhoneNumber = @NewPartnerPhoneNumber,";
                        parameters.Add(new SqlParameter("@NewPartnerPhoneNumber", updatedProfile.partnerPhoneNumber));
                    }

                    // Remove the trailing comma if there are updates
                    if (parameters.Count > 0)
                    {
                        updateQuery = updateQuery.TrimEnd(',') + " WHERE EmployeeID = @EmployeeID";

                        parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = updatedProfile.employeeID });
                        Console.WriteLine("Generated SQL Query: " + updateQuery);
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            foreach (SqlParameter parameter in parameters)
                            {
                                updateCommand.Parameters.Add(parameter);
                            }

                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    // Update email in the Users table
                    if (currentProfile.email != updatedProfile.email)
                    {
                        string updateEmailQuery = "UPDATE dbo.Users SET Email = @NewEmail WHERE UserID = (SELECT UserID FROM Employees WHERE EmployeeID = @EmployeeID)";
                        using (SqlCommand updateEmailCommand = new SqlCommand(updateEmailQuery, connection))
                        {
                            updateEmailCommand.Parameters.Add(new SqlParameter("@NewEmail", updatedProfile.email));
                            updateEmailCommand.Parameters.Add(new SqlParameter("@EmployeeID", updatedProfile.employeeID));
                            updateEmailCommand.ExecuteNonQuery();
                        }
                    }

                    // Update information in other related tables
                    UpdatePartnerInformation(connection, updatedProfile.employeeID, updatedProfile.partnerFirstName, updatedProfile.partnerLastName, updatedProfile.partnerPhoneNumber);
                    UpdateAddressInformation(connection, updatedProfile.employeeID, updatedProfile.street, updatedProfile.zipcode, updatedProfile.city, updatedProfile.country);


                    // Return the updated profile
                    return GetActualProfileByID(updatedProfile.employeeID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in UpdateProfile: {ex.Message}");
                throw new Exception("Failed to update profile", ex);
            }
        }

        private void UpdatePartnerInformation(SqlConnection connection, int employeeID, string partnerFirstName, string partnerLastName, string partnerPhoneNumber)
        {
            string updatePartnerQuery = @"
    UPDATE dbo.EmployeePartner
    SET FirstName = @PartnerFirstName, LastName = @PartnerLastName, PhoneNumber = @PartnerPhoneNumber
    WHERE EmployeeID = @EmployeeID";

            using (SqlCommand updateCommand = new SqlCommand(updatePartnerQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                updateCommand.Parameters.AddWithValue("@PartnerFirstName", partnerFirstName);
                updateCommand.Parameters.AddWithValue("@PartnerLastName", partnerLastName);
                updateCommand.Parameters.AddWithValue("@PartnerPhoneNumber", partnerPhoneNumber);

                updateCommand.ExecuteNonQuery();
            }
        }

        private void UpdateAddressInformation(SqlConnection connection, int employeeID, string street, string zipcode, string city, string country)
        {
            string updateAddressQuery = @"
UPDATE dbo.EmployeeAddress
SET StreetName = @Street, ZipCode = @Zipcode, City = @City, Country = @Country
WHERE EmployeeID = @EmployeeID";

            using (SqlCommand updateCommand = new SqlCommand(updateAddressQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@EmployeeID", employeeID);
                updateCommand.Parameters.AddWithValue("@Street", street);
                updateCommand.Parameters.AddWithValue("@Zipcode", zipcode);
                updateCommand.Parameters.AddWithValue("@City", city);
                updateCommand.Parameters.AddWithValue("@Country", country);

                updateCommand.ExecuteNonQuery();
            }
        }


    }

}
