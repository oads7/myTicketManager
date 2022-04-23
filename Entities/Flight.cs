using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTicketManager.Entities
{
    public interface IFlight
    {
        public string numFlight { get; set; }
        public string airline { get; set; }

        public string source { get; set; }
        public string destiny { get; set; }

        public DateTime departureDate { get; set; }
        public DateTime arriveDate { get; set; }
        public string state { get; set; }
    }


    public class Flight : IFlight
    {
        public string numFlight { get; set; }
        public string airline { get; set; }
        public string source { get; set; }
        public string destiny { get; set; }
        public DateTime departureDate { get; set; }
        public DateTime arriveDate { get; set; }
        public string state { get; set; }

        // Waiting
        // Boarding
        // Flying
        // Finished

    }

    public static class FlightState
    {
        public const string Waiting = "Waiting";
        public const string Boarding = "Boarding";
        public const string Flying = "Flying";
        public const string Finished = "Finished";
    }
}
