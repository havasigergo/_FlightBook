using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FlightBook
{
    public class Flight
    {
        private string _code;
        private string _destination;
        private int _basePrice;
        private int _freeSeats;

        public string Code { get { return _code; } set { _code = value; } }
        public string Destination { get { return _destination; } set { _destination = value; } }
        public int BasePrice { get { return _basePrice; } set { _basePrice = value; } }
        public int FreeSeats { get { return _freeSeats; } set { _freeSeats = value; } }

        public Flight(string code, string destination, int basePrice, int freeSeats)
        {
            _code = code;
            _destination = destination;
            _basePrice = basePrice;
            _freeSeats = freeSeats;
        }

        public bool BookSeat()
        {
            if (FreeSeats > 0)
            {
                FreeSeats--;
                return true;
            }
            return false;
        }

        public string Describe()
        {
            if (FreeSeats == 0)
            {
                return "telt ház";
            }
            return $"{Code}, {Destination}, {BasePrice}, {FreeSeats}";
        }
    }
}
