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
        public List<KeyValuePair<int, string>> GetEmployeeListExcludingDateAndShift(DateTime date, string shift)
        {
            List<KeyValuePair<int, string>> allEmployees = GetEmployeeList();
            List<KeyValuePair<int, string>> availableEmployees = GetEmployeeListByDateAndShift(date, shift);

            // Use LINQ to filter out employees who are available on the specified date and shift
            List<KeyValuePair<int, string>> excludedEmployees = allEmployees
                .Where(employee => !availableEmployees.Any(availableEmployee => availableEmployee.Key == employee.Key))
                .ToList();

            return excludedEmployees;
        }

        public void CreateShift(int employeeID, DateTime Date, string Shift, int areaID, int Needed, int Filled)
        {
            using (SqlConnection connection = InitializeConection())
            {
                // Check if the row with the given date and shift already exists in ScheduleCapacity
                string checkIfExistsSql = "SELECT FilledCapacity FROM ScheduleCapacity WHERE Date = @Date AND Shift = @Shift;";
                using (SqlCommand checkCommand = new SqlCommand(checkIfExistsSql, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Date", Date);
                    checkCommand.Parameters.AddWithValue("@Shift", Shift);
                    connection.Open();

                    object existingFilledCapacity = checkCommand.ExecuteScalar();

                    if (existingFilledCapacity != null)
                    {
                        // Row already exists, update FilledCapacity
                        int currentFilledCapacity = (int)existingFilledCapacity;
                        int newFilledCapacity = currentFilledCapacity + 1;

                        string updateSql = "UPDATE ScheduleCapacity SET FilledCapacity = @NewFilledCapacity WHERE Date = @Date AND Shift = @Shift;";
                        using (SqlCommand updateCommand = new SqlCommand(updateSql, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@NewFilledCapacity", newFilledCapacity);
                            updateCommand.Parameters.AddWithValue("@Date", Date);
                            updateCommand.Parameters.AddWithValue("@Shift", Shift);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Row doesn't exist, insert new row
                        string insertSql = "INSERT INTO ScheduleCapacity (Date, Shift, NeededCapacity, FilledCapacity) VALUES (@Date, @Shift, @NeededCapacity, @FilledCapacity);";
                        using (SqlCommand insertCommand = new SqlCommand(insertSql, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@Date", Date);
                            insertCommand.Parameters.AddWithValue("@Shift", Shift);
                            insertCommand.Parameters.AddWithValue("@NeededCapacity", Needed);
                            insertCommand.Parameters.AddWithValue("@FilledCapacity", Filled);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                // Insert into Schedules table
                string insertScheduleSql = "INSERT INTO Schedules (EmployeeID, Date, Shift, AreaID) VALUES (@EmployeeID, @Date, @Shift, @AreaID);";
                using (SqlCommand command = new SqlCommand(insertScheduleSql, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.Parameters.AddWithValue("@Date", Date);
                    command.Parameters.AddWithValue("@Shift", Shift);
                    command.Parameters.AddWithValue("@AreaID", areaID);
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

                // Query to retrieve schedule information
                string scheduleQuery = @"
SELECT 
    s.ScheduleID,
    s.EmployeeID,
    s.Date,
    s.Shift,
    s.AreaID,
    e.FirstName,
    z.areaName,
    s.AvailableEmployeeID
FROM 
    Schedules s
INNER JOIN 
    Employees e ON s.EmployeeID = e.EmployeeID
INNER JOIN
    zooArea z ON z.areaID = s.AreaID
WHERE 
    CAST(s.Date AS DATE) BETWEEN @StartDate AND @EndDate";

                using (SqlCommand scheduleCommand = new SqlCommand(scheduleQuery, connection))
                {
                    scheduleCommand.Parameters.AddWithValue("@StartDate", selectedDate.Date);
                    scheduleCommand.Parameters.AddWithValue("@EndDate", selectedDate.AddDays(6).Date);

                    using (SqlDataReader scheduleReader = scheduleCommand.ExecuteReader())
                    {
                        while (scheduleReader.Read())
                        {
                            Schedule scheduleEntry = new Schedule
                            {
                                ScheduleId = scheduleReader.GetInt32(scheduleReader.GetOrdinal("ScheduleID")),
                                EmployeeId = scheduleReader.GetInt32(scheduleReader.GetOrdinal("EmployeeID")),
                                Date = scheduleReader.GetDateTime(scheduleReader.GetOrdinal("Date")),
                                Shift = scheduleReader.GetString(scheduleReader.GetOrdinal("Shift")),
                                AreaName = scheduleReader.GetString(scheduleReader.GetOrdinal("AreaName"))
                            };

                            EmployeeDTO employee = new EmployeeDTO
                            {
                                FirstName = scheduleReader.GetString(scheduleReader.GetOrdinal("FirstName"))
                            };

                            employees.Add(employee);

                            scheduleEntries.Add(scheduleEntry);
                            if (scheduleEntry != null)
                            {
                                // Add shift labels
                                if (scheduleEntry.Shift == "MorningShift" && ShiftPanelManager.MorningShiftPanels.ContainsKey(scheduleEntry.Date))
                                {
                                    ShiftPanelManager.MorningShiftPanels[scheduleEntry.Date].AddShiftLabel(employee.FirstName + "(" + scheduleEntry.AreaName + ")");
                                }
                                else if (scheduleEntry.Shift == "AfternoonShift" && ShiftPanelManager.AfternoonShiftPanels.ContainsKey(scheduleEntry.Date))
                                {
                                    ShiftPanelManager.AfternoonShiftPanels[scheduleEntry.Date].AddShiftLabel(employee.FirstName + "(" + scheduleEntry.AreaName + ")");
                                }
                                else if (scheduleEntry.Shift == "EveningShift" && ShiftPanelManager.EveningShiftPanels.ContainsKey(scheduleEntry.Date))
                                {
                                    ShiftPanelManager.EveningShiftPanels[scheduleEntry.Date].AddShiftLabel(employee.FirstName + "(" + scheduleEntry.AreaName + ")");
                                }
                            }
                        }
                    }
                }

                // Query to retrieve schedule capacity information
                // Query to retrieve schedule capacity information
                string capacityQuery = @"
                SELECT 
                    ScheduleCapacityID,
                    NeededCapacity,
                    Shift,
                    FilledCapacity,
                    Date AS CapacityDate
                FROM 
                    ScheduleCapacity
                WHERE 
                    CAST(Date AS DATE) BETWEEN @StartDate AND @EndDate";

                using (SqlCommand capacityCommand = new SqlCommand(capacityQuery, connection))
                {
                    capacityCommand.Parameters.AddWithValue("@StartDate", selectedDate.Date);
                    capacityCommand.Parameters.AddWithValue("@EndDate", selectedDate.AddDays(6).Date);
                    capacityCommand.Parameters.AddWithValue("@Date", selectedDate.Date);

                    using (SqlDataReader capacityReader = capacityCommand.ExecuteReader())
                    {
                        while (capacityReader.Read())
                        {
                            int scheduleId = capacityReader.GetInt32(capacityReader.GetOrdinal("ScheduleCapacityID"));
                            int neededCapacity = capacityReader.GetInt32(capacityReader.GetOrdinal("NeededCapacity"));
                            int filledCapacity = capacityReader.GetInt32(capacityReader.GetOrdinal("FilledCapacity"));
                            string Shift = capacityReader.GetString(capacityReader.GetOrdinal("Shift"));
                            DateTime dateTime = capacityReader.GetDateTime(capacityReader.GetOrdinal("CapacityDate"));
                            // Find the corresponding schedule entry and update shift capacity
                            Schedule scheduleEntry = scheduleEntries.Find(s => s.ScheduleId == scheduleId);

                            
                               
                                  
                            if (neededCapacity != null && filledCapacity != null && dateTime != null && Shift == "MorningShift")
                            {
                            ShiftPanelManager.MorningShiftPanels[dateTime].UpdateShiftCapacity(neededCapacity, filledCapacity);         
                            }
                            if (neededCapacity != null && filledCapacity != null && dateTime != null && Shift == "AfternoonShift")
                            {
                                ShiftPanelManager.AfternoonShiftPanels[dateTime].UpdateShiftCapacity(neededCapacity, filledCapacity);
                            }
                            if (neededCapacity != null && filledCapacity != null && dateTime != null && Shift == "EveningShift")
                            {
                                ShiftPanelManager.EveningShiftPanels[dateTime].UpdateShiftCapacity(neededCapacity, filledCapacity);
                            }



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

        public bool CreateShiftCapacity(DateTime date, string shift, int Needed, int Filled)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Check if an entry with the same date and shift already exists
                    string checkExistenceQuery = "SELECT COUNT(*) FROM ScheduleCapacity WHERE Date = @Date AND Shift = @Shift";

                    using (SqlCommand checkExistenceCommand = new SqlCommand(checkExistenceQuery, connection))
                    {
                        checkExistenceCommand.Parameters.AddWithValue("@Date", date);
                        checkExistenceCommand.Parameters.AddWithValue("@Shift", shift);

                        int existingEntries = (int)checkExistenceCommand.ExecuteScalar();

                        if (existingEntries > 0)
                        {
                            // Entry with the same date and shift already exists, return false
                            return false;
                        }
                    }

                    // Entry does not exist, proceed with the insert
                    string insertQuery = "INSERT INTO ScheduleCapacity (NeededCapacity, FilledCapacity, Date, Shift) VALUES (@NeededCapacity, @FilledCapacity, @Date, @Shift)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NeededCapacity", Needed);
                        command.Parameters.AddWithValue("@FilledCapacity", Filled);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Shift", shift);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0; // Return true if at least one row was affected by the insert.
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool UpdateShiftCapacity(DateTime Date, string shift, int NeededCapacity)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE ScheduleCapacity SET NeededCapacity = @NeededCapacity WHERE Date = @Date AND Shift = @Shift";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NeededCapacity", NeededCapacity);
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@Shift", shift);

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

        public void AddAvailableEmployees(DateTime date, string shift, int employeeID)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string updateQuery = "INSERT INTO AvailableEmployee (Shift, UserID, Date) VALUES (@Shift, @UserID, @Date)";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Shift", shift);
                        command.Parameters.AddWithValue("@UserID", employeeID);
                        command.Parameters.AddWithValue("@Date", date);

                        int rowsAffected = command.ExecuteNonQuery();

                         
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Inside your ScheduleManager class
        public List<SelectedPanelData> GetSavedPanelsFromDatabase(int employeeID)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string selectQuery = "SELECT Date, Shift FROM AvailableEmployee WHERE UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", employeeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            List<SelectedPanelData> savedPanels = new List<SelectedPanelData>();

                            while (reader.Read())
                            {
                                string date = reader["Date"].ToString();
                                string shift = reader["Shift"].ToString();

                                savedPanels.Add(new SelectedPanelData
                                {
                                    PanelId = $"{date}-{shift}",
                                    Date = date,
                                    ShiftType = shift
                                });
                            }

                            return savedPanels;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public List<KeyValuePair<int, string>> GetEmployeeListByDateAndShift(DateTime date, string shift)
        {
            List<KeyValuePair<int, string>> employeeList = new List<KeyValuePair<int, string>>();

            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Retrieve the available panels for the specified date and shift with user details
                    string selectQuery = "SELECT AE.UserID, E.FirstName, E.LastName, AE.Shift " +
                                         "FROM AvailableEmployee AE " +
                                         "INNER JOIN Employees E ON AE.UserID = E.EmployeeID " +
                                         "WHERE AE.Date = @Date AND AE.Shift = @Shift";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Shift", shift);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Iterate through the available panels
                            while (reader.Read())
                            {
                                int employeeID = Convert.ToInt32(reader["UserID"]);
                                string firstName = reader["FirstName"].ToString();
                                string lastName = reader["LastName"].ToString();
                                string fullName = $"{firstName} {lastName}";

                                // Use the EmployeeID and Full Name as the KeyValuePair
                                employeeList.Add(new KeyValuePair<int, string>(employeeID, $"{fullName}"));
                            }
                        }
                    }
                }

                return employeeList;
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw ex;
            }
        }

        public List<Employee> RetrieveAvailableEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string sql = "SELECT * FROM AvailableEmployee;";

            using (SqlConnection connection = InitializeConection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Map database columns to Employee object properties
                        Employee employee = new Employee
                        {
                            EmployeeID = (int)reader["EmployeeID"],
                            // Map other properties
                        };

                        employees.Add(employee);
                    }
                }
            }

            return employees;
        }

        public Dictionary<Tuple<DateTime, string>, List<int>> IdentifyDayWithLeastEmployees()
        {
            Dictionary<Tuple<DateTime, string>, List<int>> dateShiftUserCounts = new Dictionary<Tuple<DateTime, string>, List<int>>();

            // Get the start date (Sunday before the start of next week)
            DateTime currentDate = DateTime.Today;
            int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)currentDate.DayOfWeek + 7) % 7;
            DateTime startOfWeek = currentDate.AddDays(daysUntilSunday);

            // Get the end date (Saturday of next week)
            DateTime endOfWeek = startOfWeek.AddDays(6);

            string sql = "SELECT Date, Shift, UserID " +
                         "FROM AvailableEmployee " +
                         "WHERE Date BETWEEN @StartDate AND @EndDate;";

            using (SqlConnection connection = InitializeConection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@StartDate", startOfWeek);
                command.Parameters.AddWithValue("@EndDate", endOfWeek);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = (DateTime)reader["Date"];
                        string shift = (string)reader["Shift"];
                        int userID = (int)reader["UserID"];

                        // Create a composite key of date and shift
                        var key = Tuple.Create(date, shift);

                        // Add user ID to the list associated with the composite key
                        if (!dateShiftUserCounts.ContainsKey(key))
                        {
                            dateShiftUserCounts[key] = new List<int>();
                        }

                        dateShiftUserCounts[key].Add(userID);
                    }
                }
            }

            // Order the dictionary by the count of user IDs in descending order
            var sortedDictionary = dateShiftUserCounts.OrderByDescending(kv => kv.Value.Count)
                                                      .ToDictionary(kv => kv.Key, kv => kv.Value);

            // Pick the first date and shift from the sorted dictionary
            var selectedKey = sortedDictionary.Keys.FirstOrDefault();

            if (selectedKey == null)
            {
                throw new InvalidOperationException("Unable to identify the day with the least employees.");
            }

            return sortedDictionary;
        }


        public List<Employee> RetrieveEmployeeFulltime()
        {
            try
            {


                List<Employee> managers = new List<Employee>();
                string sql = "SELECT Employees.EmployeeID " +
                    "FROM Employees " +
                    "LEFT JOIN EmployeeContracts ON Employees.EmployeeID = EmployeeContracts.EmployeeID " +
                    " WHERE Employees.RoleID = 3 AND EmployeeContracts.ContractType = 'Fulltime';";

                using (SqlConnection connection = InitializeConection())
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Map database columns to Employee object properties
                            Employee manager = new Employee
                            {
                                EmployeeID = (int)reader["EmployeeID"],
                                // Map other properties
                            };

                            managers.Add(manager);
                        }
                    }
                }



                return managers;
            }
            catch (Exception ex) { return null; }

        }
        public List<Employee> RetrieveManagers()
        {
            try
            {

            
            List<Employee> managers = new List<Employee>();
            string sql = "SELECT Employees.EmployeeID " +
                    "FROM Employees " +
                    "LEFT JOIN EmployeeContracts ON Employees.EmployeeID = EmployeeContracts.EmployeeID " +
                    " WHERE Employees.RoleID = 2 AND EmployeeContracts.ContractType = 'fulltime';";

                using (SqlConnection connection = InitializeConection())
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Map database columns to Employee object properties
                        Employee manager = new Employee
                        {
                            EmployeeID = (int)reader["EmployeeID"],
                            // Map other properties
                        };

                        managers.Add(manager);
                    }
                }
            }
            
            

            return managers;
            }
            catch (Exception ex) { return null; }

        }
        public List<Employee> RetrieveParttimers()
        {
            try
            {


                List<Employee> managers = new List<Employee>();
                string sql = "SELECT Employees.EmployeeID " +
                        "FROM Employees " +
                        "LEFT JOIN EmployeeContracts ON Employees.EmployeeID = EmployeeContracts.EmployeeID " +
                        " WHERE Employees.RoleID = 3 AND EmployeeContracts.ContractType = 'Parttime';";

                using (SqlConnection connection = InitializeConection())
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Map database columns to Employee object properties
                            Employee manager = new Employee
                            {
                                EmployeeID = (int)reader["EmployeeID"],
                                // Map other properties
                            };

                            managers.Add(manager);
                        }
                    }
                }



                return managers;
            }
            catch (Exception ex) { return null; }

        }
        private bool IsManagerUnavailableOnShift(int managerID, DateTime date, string shift, SqlConnection connection)
        {
            try
            {
                // Implement logic to check if the manager is unavailable for the specified shift on the given date
                // You may need to query the database or use existing data structures to determine this

                // Sample SQL query (replace with your actual query)
                string sql = "SELECT COUNT(*) FROM AvailableEmployee WHERE UserID = @UserID AND Date = @Date AND Shift = @Shift;";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserID", managerID);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Shift", shift);

                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Return true if manager is unavailable, false otherwise
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        private int GetShiftsAssignedToday(int managerID, DateTime date, SqlConnection connection)
        {
            try
            {
                // Implement logic to get the number of shifts assigned to the manager on the specified date
                // You may need to query the database or use existing data structures to determine this

                // Sample SQL query (replace with your actual query)
                string sql = "SELECT COUNT(*) FROM Schedules WHERE EmployeeID = @ManagerID AND Date = @Date;";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ManagerID", managerID);
                    command.Parameters.AddWithValue("@Date", date);

                    int count = (int)command.ExecuteScalar();
                    return count; // Return the count of shifts assigned today
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return 0;
            }
        }

        private int GetShiftsAssignedThisWeek(int managerID, DateTime date, SqlConnection connection)
        {
            try
            {
                // Implement logic to get the number of shifts assigned to the manager in the current week
                // You may need to query the database or use existing data structures to determine this

                // Sample SQL query (replace with your actual query)
                string sql = "SELECT COUNT(*) FROM Schedules WHERE EmployeeID = @ManagerID AND Date >= @StartDate AND Date <= @EndDate;";

                DateTime startOfWeek = date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Sunday);
                DateTime endOfWeek = startOfWeek.AddDays(6);

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ManagerID", managerID);
                    command.Parameters.AddWithValue("@StartDate", startOfWeek);
                    command.Parameters.AddWithValue("@EndDate", endOfWeek);

                    int count = (int)command.ExecuteScalar();
                    return count; // Return the count of shifts assigned this week
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return 0;
            }
        }
        public void AssignFullTimeEmployeesToShifts(List<Employee> fullTimeEmployees, List<Tuple<DateTime, string>> dateShiftUserCounts)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Get the current date and move to the next Sunday
                    DateTime currentDate = DateTime.Today;
                    int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)currentDate.DayOfWeek + 7) % 7;
                    DateTime nextSunday = currentDate.AddDays(daysUntilSunday);

                    // Iterate through each day of the week (next Sunday to Saturday)
                    for (int i = 0; i < 7; i++)
                    {
                        DateTime date = nextSunday.AddDays(i);

                        // Check if the date is within dateShiftUserCounts
                        if (dateShiftUserCounts.Any(pair => pair.Item1 == date))
                        {
                            // Iterate through each shift on the current date
                            // Iterate through each shift on the current date
                            foreach (var shift in new[] { "MorningShift", "AfternoonShift", "EveningShift" })
                            {
                                // Check if the shift already has the required number of employees assigned
                                if (!IsShiftFilled(date, shift, connection, neededCapacity: 5))
                                {
                                    // Iterate through full-time employees for this shift
                                    foreach (var employee in fullTimeEmployees)
                                    {
                                        // Check if the shift is already filled
                                        if (IsShiftFilled(date, shift, connection, neededCapacity: 5))
                                        {
                                            // Move to the next shift if the current shift is already filled
                                            break;
                                        }

                                        // Check if the employee is available for this shift
                                        if (!IsEmployeeUnavailableOnShift(employee.EmployeeID, date, shift, connection))
                                        {
                                            // Check if the employee has not exceeded the limit of 2 shifts per day and 10 shifts per week
                                            if (GetShiftsAssignedToday(employee.EmployeeID, date, connection) < 2 &&
                                                GetShiftsAssignedThisWeek(employee.EmployeeID, date, connection) < 10)
                                            {
                                                // Run the CreateShift query
                                                CreateShift(employee.EmployeeID, date, shift, areaID: 1, Needed: 5, Filled: 1);

                                               

                                                // Check if the employee has reached the weekly limit
                                                if (GetShiftsAssignedThisWeek(employee.EmployeeID, date, connection) >= 10)
                                                {
                                                    // Break if the weekly limit is reached for this employee
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    // The shift is already filled, move to the next shift
                                    continue;
                                }
                            }

                        }
                    
                        else
                        {
                            // The date is not within dateShiftUserCounts, you can handle it as needed
                            // For example, run default logic or log a message
                            Console.WriteLine($"No preferences found for {date}. Running default logic.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }



        private bool IsShiftFilled(DateTime date, string shift, SqlConnection connection, int neededCapacity)
        {
            try
            {
                // Implement logic to check if the shift has the required number of employees assigned
                // You may need to query the database or use existing data structures to determine this

                // Sample SQL query (replace with your actual query)
                string sql = "SELECT COUNT(*) FROM ScheduleCapacity WHERE Date = @Date AND Shift = @Shift AND FilledCapacity >= @NeededCapacity;";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Shift", shift);
                    command.Parameters.AddWithValue("@NeededCapacity", neededCapacity);

                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Return true if the shift is filled, false otherwise
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

       

        private bool IsEmployeeUnavailableOnShift(int employeeID, DateTime date, string shift, SqlConnection connection)
        {
            try
            {
                // Implement logic to check if the employee is unavailable for the specified shift on the given date
                // You may need to query the database or use existing data structures to determine this

                // Sample SQL query (replace with your actual query)
                string sql = "SELECT COUNT(*) FROM AvailableEmployee WHERE UserID = @UserID AND Date = @Date AND Shift = @Shift;";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@UserID", employeeID);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@Shift", shift);

                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Return true if employee is unavailable, false otherwise
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
        private List<Tuple<DateTime, string>> GetShiftsWithAvailableCapacity(List<Tuple<DateTime, string>> dateShiftUserCounts, SqlConnection connection)
        {
            try
            {
                List<Tuple<DateTime, string>> shiftsWithAvailableCapacity = new List<Tuple<DateTime, string>>();

                foreach (var dateShiftPair in dateShiftUserCounts)
                {
                    string shift = dateShiftPair.Item2;
                    DateTime date = dateShiftPair.Item1;

                    // Check if the shift has available capacity
                    if (!IsShiftFilled(date, shift, connection))
                    {
                        shiftsWithAvailableCapacity.Add(new Tuple<DateTime, string>(date, shift));
                    }
                }

                return shiftsWithAvailableCapacity;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<Tuple<DateTime, string>>();
            }
        }
        public bool AreAllShiftsFilled(DateTime startDate, DateTime endDate)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Iterate through each date and shift between the start and end date
                    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                    {
                        foreach (var shift in new[] { "MorningShift", "AfternoonShift", "EveningShift" })
                        {
                            // Check if the shift is filled
                            if (!IsShiftFilled(date, shift, connection))
                            {
                                return false;
                            }
                        }
                    }

                    // All shifts are filled
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false; // Handle the error as appropriate for your application
            }
        }
        // Method to assign part-time employees to shifts
        public void AssignPartTimeEmployeesToShifts(List<Employee> partTimeEmployees, List<Tuple<DateTime, string>> dateShiftUserCounts)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Get the current date and move to the next Sunday
                    DateTime currentDate = DateTime.Today;
                    int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)currentDate.DayOfWeek + 7) % 7;
                    DateTime nextSunday = currentDate.AddDays(daysUntilSunday);

                    // Iterate through each day of the week (next Sunday to Saturday)
                    for (int i = 0; i < 7; i++)
                    {
                        DateTime date = nextSunday.AddDays(i);

                        // Check if the date is within dateShiftUserCounts
                        if (dateShiftUserCounts.Any(pair => pair.Item1 == date))
                        {
                            // Iterate through each shift on the current date
                            // Iterate through each shift on the current date
                            foreach (var shift in new[] { "MorningShift", "AfternoonShift", "EveningShift" })
                            {
                                // Check if the shift already has the required number of employees assigned
                                if (!IsShiftFilled(date, shift, connection, neededCapacity: 5))
                                {
                                    // Iterate through full-time employees for this shift
                                    foreach (var employee in partTimeEmployees)
                                    {
                                        // Check if the shift is already filled
                                        if (IsShiftFilled(date, shift, connection, neededCapacity: 5))
                                        {
                                            // Move to the next shift if the current shift is already filled
                                            break;
                                        }

                                        // Check if the employee is available for this shift
                                        if (!IsEmployeeUnavailableOnShift(employee.EmployeeID, date, shift, connection))
                                        {
                                            // Check if the employee has not exceeded the limit of 2 shifts per day and 10 shifts per week
                                            if (GetShiftsAssignedToday(employee.EmployeeID, date, connection) < 2 &&
                                                GetShiftsAssignedThisWeek(employee.EmployeeID, date, connection) < 10)
                                            {
                                                // Run the CreateShift query
                                                CreateShift(employee.EmployeeID, date, shift, areaID: 1, Needed: 5, Filled: 1);

                                                // Update the needed capacity for the shift
                                               

                                                // Check if the employee has reached the weekly limit
                                                if (GetShiftsAssignedThisWeek(employee.EmployeeID, date, connection) >= 10)
                                                {
                                                    // Break if the weekly limit is reached for this employee
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    // The shift is already filled, move to the next shift
                                    continue;
                                }
                            }

                        }
                        else
                        {
                            // The date is not within dateShiftUserCounts, you can handle it as needed
                            // For example, run default logic or log a message
                            Console.WriteLine($"No preferences found for {date}. Running default logic.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public void AssignManagersToShifts(List<Employee> managers, List<Tuple<DateTime, string>> dateShiftUserCounts)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    // Get the current date and move to the next Sunday
                    DateTime currentDate = DateTime.Today;
                    int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)currentDate.DayOfWeek + 7) % 7;
                    DateTime nextSunday = currentDate.AddDays(daysUntilSunday);

                    // Iterate through each day of the week (next Sunday to Saturday)
                    for (int i = 0; i < 7; i++)
                    {
                        DateTime date = nextSunday.AddDays(i);

                        // Check if the date is within dateShiftUserCounts
                        if (dateShiftUserCounts.Any(pair => pair.Item1 == date))
                        {
                            // Iterate through each shift on the current date
                            foreach (var shift in new[] { "MorningShift", "AfternoonShift", "EveningShift" })
                            {
                                // Check if the shift already has a manager assigned
                                if (!IsShiftFilledManager(date, shift, connection))
                                {
                                    // Iterate through managers for this shift
                                    foreach (var manager in managers)
                                    {
                                        // Check if the manager is available for this shift
                                        if (!IsManagerUnavailableOnShift(manager.EmployeeID, date, shift, connection))
                                        {
                                            // Check if the manager has not exceeded the limit of 2 shifts per day and 10 shifts per week
                                            if (GetShiftsAssignedToday(manager.EmployeeID, date, connection) < 2 &&
                                                GetShiftsAssignedThisWeek(manager.EmployeeID, date, connection) < 10)
                                            {
                                                // Run the CreateShift query
                                                CreateShift(manager.EmployeeID, date, shift, areaID: 1, Needed: 5, Filled: 1);
                                                break;  // Stop assigning to this shift after successfully assigning one manager
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            // The date is not within dateShiftUserCounts, you can handle it as needed
                            // For example, run default logic or log a message
                            Console.WriteLine($"No preferences found for {date}. Running default logic.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private bool IsShiftFilledManager(DateTime date, string shift, SqlConnection connection)
        {
            string sql = "SELECT COUNT(*) FROM ScheduleCapacity WHERE Date = @Date AND Shift = @Shift AND FilledCapacity >= 1;";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Shift", shift);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private bool IsShiftFilled(DateTime date, string shift, SqlConnection connection)
        {
            string sql = "SELECT COUNT(*) FROM ScheduleCapacity WHERE Date = @Date AND Shift = @Shift AND FilledCapacity >= 5;";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Shift", shift);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }



        private List<int> GetManagersUnavailableOnDate(DateTime date, SqlConnection connection, string shift)
        {
            List<int> unavailableManagerIDs = new List<int>();

            string sql = "SELECT DISTINCT UserID FROM AvailableEmployee WHERE Date = @Date AND Shift = @Shift;";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Shift", shift);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int userID = (int)reader["UserID"];
                        unavailableManagerIDs.Add(userID);
                    }
                }
            }

            return unavailableManagerIDs;
        }


        public void AssignManagersToShifts(List<Employee> managers, DateTime targetDate)
        {
            throw new NotImplementedException();
        }

        public List<Employee> RetrieveFullTimeEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Employee> RetrievePartTimeEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Employee> RetrieveZeroHourEmployees()
        {
            throw new NotImplementedException();
        }

        public void AssignEmployeesToShifts(List<Employee> employees, DateTime targetDate)
        {
            throw new NotImplementedException();
        }

        public void RemoveAvailableEmployee(DateTime date, string shift, int employeeID)
        {
            try
            {
                using (SqlConnection connection = InitializeConection())
                {
                    connection.Open();

                    string updateQuery = "DELETE FROM AvailableEmployee " +
                                         "WHERE Date = @Date AND UserID = @UserID AND Shift = @Shift";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Shift", shift);
                        command.Parameters.AddWithValue("@UserID", employeeID);
                        command.Parameters.AddWithValue("@Date", date);

                        int rowsAffected = command.ExecuteNonQuery();


                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}



