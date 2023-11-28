using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.Data.SqlClient;


namespace DataAccess
{
    public class ScheduleRepository : Connection, ISchedule
    {
        public List<KeyValuePair<int, string>> GetEmployeeList()
        {
            List<KeyValuePair<int, string>> employeeList = new List<KeyValuePair<int, string>>();

            using (SqlConnection connection = InitializeConection())
            {
                connection.Open();

                string sqlString = "SELECT EmployeeID, FirstName, LastName FROM Employees";
                using (SqlCommand command = new SqlCommand(sqlString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Display the combination of FirstName and LastName in the ComboBox
                            string fullName = $"{reader["FirstName"]} {reader["LastName"]}";
                            int employeeID = Convert.ToInt32(reader["EmployeeID"]);

                            // Add the item with the employee's full name as the display text and the ID as the value
                            employeeList.Add(new KeyValuePair<int, string>(employeeID, fullName));
                        }
                    }
                }
            }

            return employeeList;
        }
        public void CreateShift(int employeeID, DateTime Date, string Shift, int areaID)
        {
            using (SqlConnection connection = InitializeConection())
            {
                string sqlString = "INSERT INTO Schedules (EmployeeID, Date, Shift, AreaID) VALUES (@EmployeeID,@Date,@Shift,@AreaID);";
                using (SqlCommand command = new SqlCommand(sqlString, connection))
                {

                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@Shift", Shift);
                    command.Parameters.AddWithValue("@AreaID", areaID);
                    connection.Open();
                    command.ExecuteNonQuery();

                }
            }
        }
        public bool UpdateShift(Schedule schedule)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE Schedules SET EmployeeID = @EmployeeID, Date = @Date, Shift = @Shift, AreaID=@AreaID WHERE ScheduleID = @ScheduleID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", schedule.EmployeeId);
                        command.Parameters.AddWithValue("@Date", schedule.Date);
                        command.Parameters.AddWithValue("@Shift", schedule.Shift);
                        command.Parameters.AddWithValue("@ScheduleID", schedule.ScheduleId);
                        command.Parameters.AddWithValue("@AreaID", schedule.AreaID);


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
        public DataTable LoadSchedules(DateTime selectedDate)
        {
            using (SqlConnection connection = InitializeConection())
            {
                connection.Open();

                string selectQuery1 = "SELECT ScheduleID, EmployeeID, Date, Shift,AreaID" +
                                        " FROM Schedules WHERE " +
                                        "Date BETWEEN @StartDate AND @EndDate";

                using (SqlCommand command1 = new SqlCommand(selectQuery1, connection))
                {
                    command1.Parameters.AddWithValue("@StartDate", selectedDate.Date);
                    command1.Parameters.AddWithValue("@EndDate", selectedDate.Date);
                    using (SqlDataAdapter adapter1 = new SqlDataAdapter(command1))
                    {
                        DataTable employeeDataTable1 = new DataTable();
                        adapter1.Fill(employeeDataTable1);

                        
                         return employeeDataTable1;
                    }       
                }
            }
        }

        public List<Schedule> PopulateSchedule(DateTime selectedDate)
        {
            List<Schedule> scheduleEntries = new List<Schedule>();
            List<EmployeeDTO> employees = new List<EmployeeDTO>();

            using (SqlConnection connection = InitializeConection())
            {
                connection.Open();

                string sqlQuery = @"
        SELECT 
            s.ScheduleID,
            s.EmployeeID,
            s.Date,
            s.Shift,
            s.AreaID,
            e.FirstName,
            z.areaName
        FROM 
            Schedules s
        INNER JOIN 
            Employees e ON s.EmployeeID = e.EmployeeID
        INNER JOIN
            zooArea z ON z.areaID = s.AreaID
        WHERE 
            CAST(s.Date AS DATE) BETWEEN @StartDate AND @EndDate";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", selectedDate.Date);
                    command.Parameters.AddWithValue("@EndDate", selectedDate.AddDays(6).Date);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Schedule scheduleEntry = new Schedule
                            {
                                ScheduleId = reader.GetInt32(reader.GetOrdinal("ScheduleID")),
                                EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                Shift = reader.GetString(reader.GetOrdinal("Shift")),
                                AreaName = reader.GetString(reader.GetOrdinal("AreaName"))
                            };

                            EmployeeDTO employee = new EmployeeDTO
                            {
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName"))
                            };

                            employees.Add(employee);

                            // Check the shift type and use the interface
                            if (scheduleEntry.Shift == "MorningShift"  && ShiftPanelManager.MorningShiftPanels.ContainsKey(scheduleEntry.Date))
                            {
                                ShiftPanelManager.MorningShiftPanels[scheduleEntry.Date].AddShiftLabel(employee.FirstName + "(" + scheduleEntry.AreaName + ")");
                            }
                            else if (scheduleEntry.Shift == "AfternoonShift"  && ShiftPanelManager.AfternoonShiftPanels.ContainsKey(scheduleEntry.Date))
                            {
                                ShiftPanelManager.AfternoonShiftPanels[scheduleEntry.Date].AddShiftLabel(employee.FirstName + "(" + scheduleEntry.AreaName + ")");
                            }
                            else if (scheduleEntry.Shift == "EveningShift" && ShiftPanelManager.EveningShiftPanels.ContainsKey(scheduleEntry.Date))
                            {
                                ShiftPanelManager.EveningShiftPanels[scheduleEntry.Date].AddShiftLabel(employee.FirstName + "("+ scheduleEntry.AreaName + ")");
                            }

                            scheduleEntries.Add(scheduleEntry);
                        }
                    }
                }
            }

            return scheduleEntries;
        }
        public List<Schedule> GetScheduleByID(int id)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();
                    string selectQuery1 = "SELECT s.ScheduleID, s.EmployeeID, s.Date, s.Shift, s.AreaID, z.AreaName " +
                                            "FROM Schedules s " +
                                            "INNER JOIN zooArea z ON s.AreaID = z.AreaID " +
                                            "WHERE s.EmployeeID = @EmployeeID";
                    using (SqlCommand command1 = new SqlCommand(selectQuery1, connection))
                    {

                        command1.Parameters.AddWithValue("@EmployeeID", id);

                        using (SqlDataReader reader = command1.ExecuteReader())
                        {
                            List<Schedule> schedules = new List<Schedule>();

                            while (reader.Read())
                            {
                                Schedule schedule = new Schedule
                                {
                                    ScheduleId = reader.GetInt32(reader.GetOrdinal("ScheduleID")),
                                    EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                    Date = reader.GetDateTime(reader.GetOrdinal("Date")),
                                    Shift = reader.GetString(reader.GetOrdinal("Shift")),
                                    AreaID = reader.GetInt32(reader.GetOrdinal("AreaID")),
                                    AreaName = reader.GetString(reader.GetOrdinal("AreaName"))
                                    // Add other properties here
                                };

                                schedules.Add(schedule);
                            }

                            return schedules;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid ID");
            }
        }

        public bool DeleteShift(int Id)
        {
            using (SqlConnection connection = InitializeConection())
            {
                connection.Open();

                string deleteQuery = "DELETE FROM Schedules WHERE ScheduleID = @UniqueIdentifier";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@UniqueIdentifier", Id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }

}

