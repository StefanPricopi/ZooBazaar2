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
    }

}
