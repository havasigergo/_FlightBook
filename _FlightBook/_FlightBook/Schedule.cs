using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _FlightBook
{
    public class Schedule
    {
        private List<Flight> _flights;
        public List<Flight> Flights
        {
            get { return _flights; }
        }

        public Schedule()
        {
            _flights = new List<Flight>();
        }

        public void AddFlight(Flight flight)
        {
            _flights.Add(flight);
        }

        public int FullyBookedCount()
        {
            int     fullybooked = 0;

            foreach (var flight in _flights)
            {
                if (flight.FreeSeats == 0)
                {
                    fullybooked++;
                }
            }
            return fullybooked;
        }

        public int FreeSeatsTo(string destination)
        { 
            int freeSeats = 0;

            foreach (Flight flight in _flights)
            {
                if (flight.Destination == destination)
                {
                    freeSeats += flight.FreeSeats;
                }
            }
            return freeSeats;
        }
    }
}
