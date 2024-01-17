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
    public class VisitorProfileRepository : Connection, IVisitor
    {
        public VisitorDTO GetActualProfileByID(int id)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string selectQuery = @"
                SELECT 
                    Users.Username, 
                    Users.Email, 
                    Visitors.TotalTicketPurchased
                FROM 
                    Users
                LEFT JOIN 
                    Visitors ON Users.UserID = Visitors.UserID
                WHERE 
                    Users.UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                VisitorDTO u = new VisitorDTO();

                                u.UserID = id; // Assuming employeeID is still relevant
                                u.Email = reader["Email"].ToString();
                                u.Username = reader["Username"].ToString();
                                u.TotalTicketsPurchased = reader["TotalTicketPurchased"] == DBNull.Value
                                ? 0 // or any default value you prefer
                                : Convert.ToInt32(reader["TotalTicketPurchased"]);


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
        public VisitorDTO UpdateVisitorInformation(VisitorDTO updatedVisitor)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Fetch the existing visitor information
                    VisitorDTO currentVisitor = GetActualProfileByID(updatedVisitor.UserID);

                    // Build the update query dynamically based on the changes
                    string updateQuery = "UPDATE dbo.Users SET";
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    // Add checks for visitor information
                    if (currentVisitor.Username != updatedVisitor.Username)
                    {
                        updateQuery += " Username = @NewUsername,";
                        parameters.Add(new SqlParameter("@NewUsername", updatedVisitor.Username));
                    }

                    if (currentVisitor.Email != updatedVisitor.Email)
                    {
                        updateQuery += " Email = @NewEmail,";
                        parameters.Add(new SqlParameter("@NewEmail", updatedVisitor.Email));
                    }

                    // Add checks for other visitor information fields (e.g., TotalTicketPurchased)

                    // Remove the trailing comma if there are updates
                    if (parameters.Count > 0)
                    {
                        updateQuery = updateQuery.TrimEnd(',') + " WHERE UserID = @UserID";

                        parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = updatedVisitor.UserID });
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

                    // Return the updated visitor information
                    return GetActualProfileByID(updatedVisitor.UserID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in UpdateVisitorInformation: {ex.Message}");
                throw new Exception("Failed to update visitor information", ex);
            }
        }


    }
}
