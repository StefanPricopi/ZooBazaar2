using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TicketRepository : Connection, ITicket
    {
        public Ticket RetrieveTicketFromID(int id)
         {
            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "SELECT *" +
                        " FROM Ticket" +
                        " WHERE TickeID = @TickeID ;";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TickeID", id);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Ticket ticket = new Ticket
                        {
                            TicketID = Convert.ToInt32(dr["TickeID"]),
                            TicketPrice = dr["TicketPrice"].ToString(),
                            TicketType = dr["TicketType"].ToString(),
                            TimeOfPurchase = Convert.ToDateTime(dr["Date"].ToString()),
                            DateValidity = Convert.ToDateTime(dr["Date"].ToString()),
                            UserID = Convert.ToInt32(dr["UserID"]),
                        };
                        return ticket;
                    }

                    // nothing found
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log it, etc.
                return null;
            }
        }



    
    public int CreateTicket(Ticket ticket)
        {
            int newTicketID = -1; // Default value indicating failure

            try
            {
                using (SqlConnection conn = InitializeConection())
                {
                    string sql = "INSERT INTO Ticket (UserID, TicketPrice, TicketType, Date, DateValidity) VALUES (@UserID, @TicketPrice, @TicketType, @Date, @DateValidity); SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserID", ticket.UserID);
                    cmd.Parameters.AddWithValue("@TicketPrice", ticket.TicketPrice);
                    cmd.Parameters.AddWithValue("@TicketType", ticket.TicketType);
                    cmd.Parameters.AddWithValue("@Date", ticket.TimeOfPurchase);
                    cmd.Parameters.AddWithValue("@DateValidity", ticket.DateValidity);

                    conn.Open();

                    // ExecuteScalar is used to retrieve the identity value (TicketID) of the recently added record
                    object result = cmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out newTicketID))
                    {
                        // TicketID retrieval successful
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., log the error
            }

            return newTicketID;
        }

    }
}
