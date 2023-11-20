﻿using System;
using System.Collections.Generic;
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
        public void CreateShift(int employeeID, DateTime Date, string Shift)
        {
            using (SqlConnection connection = InitializeConection())
            {
                string sqlString = "INSERT INTO Schedules (EmployeeID, Date, Shift) VALUES (@EmployeeID,@Date,@Shift);";
                using (SqlCommand command = new SqlCommand(sqlString, connection))
                {

                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@Shift", Shift);
                    connection.Open();
                    command.ExecuteNonQuery();

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
            e.FirstName
        FROM 
            Schedules s
        INNER JOIN 
            Employees e ON s.EmployeeID = e.EmployeeID
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
                                Shift = reader.GetString(reader.GetOrdinal("Shift"))
                            };

                            EmployeeDTO employee = new EmployeeDTO
                            {
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName"))
                            };

                            employees.Add(employee);

                            // Check the shift type and use the interface
                            if (scheduleEntry.Shift == "MorningShift" && ShiftPanelManager.MorningShiftPanels.ContainsKey(scheduleEntry.Date))
                            {
                                ShiftPanelManager.MorningShiftPanels[scheduleEntry.Date].AddShiftLabel(employee.FirstName);
                            }
                            else if (scheduleEntry.Shift == "AfternoonShift" && ShiftPanelManager.AfternoonShiftPanels.ContainsKey(scheduleEntry.Date))
                            {
                                ShiftPanelManager.AfternoonShiftPanels[scheduleEntry.Date].AddShiftLabel(employee.FirstName);
                            }
                            else if (scheduleEntry.Shift == "EveningShift" && ShiftPanelManager.EveningShiftPanels.ContainsKey(scheduleEntry.Date))
                            {
                                ShiftPanelManager.EveningShiftPanels[scheduleEntry.Date].AddShiftLabel(employee.FirstName);
                            }

                            scheduleEntries.Add(scheduleEntry);
                        }
                    }
                }
            }

            return scheduleEntries;
        }

    }

}