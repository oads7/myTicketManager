using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using myTicketManager.Models;
using myTicketManager.Entities;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace myTicketManager
{
    public static class Database
    {
        private static DBO database = new DBO(String.Empty);


        public static void InitializeDatabase()
        {
            database = new DBO(@"Server=sql.bsite.net\MSSQL2016;Database=oads7_myTicketManager;User Id=oads7_myTicketManager;Password=admin1234*;MultipleActiveResultSets=true;");
        }

        public static async Task<User> GetUser(string Username)
        {
            User user = new User();

            try
            {
                database.Open();
                SqlDataReader reader = await database.Query("SELECT * FROM dbo.Users WHERE Username='" +
                                                        Username + "' COLLATE SQL_Latin1_General_CP1_CS_AS");

                if (reader.Read())
                {
                    user.id = uint.Parse(reader["ID"].ToString());
                    user.username = reader["Username"].ToString();
                    user.password = reader["Password"].ToString();
                    user.fullname = reader["FullName"].ToString();
                    user.type = reader["Type"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }

            database.Close();
            return user;
        }

        //public static async Task<IEnumerable<Flight>> GetFlights(DateTime start, DateTime end)
        //{

            
        //}

        public static async Task<ICollection<Flight>> GetFlights(int lastFlights)
        {
            ICollection<Flight> list = new Collection<Flight>();

            try
            {
                database.Open();
                SqlDataReader reader = await database.Query("SELECT TOP " + lastFlights + 
                                                            " * FROM dbo.Flights ORDER BY DepartureDate DESC;");
                
                while(reader.Read())
                {
                    Flight flight = new Flight();

                    flight.numFlight = reader["Flight"].ToString();
                    flight.airline = reader["Airline"].ToString();
                    flight.source = reader["Source"].ToString();
                    flight.destiny = reader["Destiny"].ToString();

                    flight.departureDate = DateTime.Parse(reader["DepartureDate"].ToString());
                    flight.arriveDate = DateTime.Parse(reader["ArriveDate"].ToString());

                    flight.state = reader["State"].ToString();

                    list.Add(flight);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }

            database.Close();
            return list;
        }



        public static async Task<bool> AddFlight(Flight newFLight)
        {
            bool returnValue = false;

            try
            {
                database.Open();
                SqlDataReader reader = await database.Query("INSERT INTO dbo.Flights(Flight, Airline, " +
                                                                                    "Source, Destiny, " +
                                                                                    "DepartureDate, ArriveDate, " +
                                                                                    "State) " +
                                                            "VALUES('" + newFLight.numFlight + "', '" +
                                                                         newFLight.airline + "', '" +
                                                                         newFLight.source + "', '" +
                                                                         newFLight.destiny + "', '" +
                                                                         newFLight.departureDate.ToString("yyyy-MM-ddThh:mm:ss") + "', '" +
                                                                         newFLight.arriveDate.ToString("yyyy-MM-ddThh:mm:ss") + "', '" +
                                                                         newFLight.state + "');");

                reader.Read();
                reader.Close();
                returnValue = true;
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }

            database.Close();
            return returnValue;
        }

        public static async Task<bool> UpdateFlight(Flight existingFlight)
        {
            bool returnValue = false;

            try
            {
                database.Open();

                SqlDataReader reader = await database.Query("UPDATE dbo.Flights SET " +
                                                            "Airline='" + existingFlight.airline + "', " +
                                                            "Source='" + existingFlight.source + "', " +
                                                            "Destiny='" + existingFlight.destiny + "', " +
                                "DepartureDate='" + existingFlight.departureDate.ToString("yyyy-MM-ddThh:mm:ss") + "', " +
                                "ArriveDate='" + existingFlight.arriveDate.ToString("yyyy-MM-ddThh:mm:ss") + "', " +
                                                            "State='" + existingFlight.state + "' " +
                                                            "WHERE Flight='" + existingFlight.numFlight + "';");

                reader.Read();
                reader.Close();
                returnValue = true;
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }

            database.Close();
            return returnValue;
        }




        public static async Task<bool> DeleteFlight(string numFlight)
        {
            bool returnValue = false;

            try
            {
                database.Open();
                SqlDataReader reader = await database.Query("DELETE FROM dbo.Flights WHERE Flight='" + numFlight + "';");

                reader.Read();
                reader.Close();
                returnValue = true;
            }
            catch (Exception ex)
            {
                Log.WriteException(ex);
            }

            database.Close();
            return returnValue;
        }
    }
}
