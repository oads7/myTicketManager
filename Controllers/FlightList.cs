using myTicketManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTicketManager.Controllers
{
    public static class FlightList
    {

        public static async Task<IEnumerable<Flight>> GetList(int lastFlights)
        {
            return await Database.GetFlights(lastFlights);
        }

        //public static async Task<IEnumerable<Flight>> GetList(DateTime start, DateTime last)
        //{
        //    return await Database.GetFlights(start, last);
        //}

        public static async void DeleteFlight(string numFlight)
        {
            await Database.DeleteFlight(numFlight);
        }

        public static async void AddFlight(Flight flight)
        {
            await Database.AddFlight(flight);
        }

    }
}
