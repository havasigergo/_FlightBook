using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _FlightBook
{
    public class Ticket
    {
        private Passenger _traveller;
        private Flight _bookedFlight;
        private bool _isConfirmed = false;

        public Passenger Traveller { get { return _traveller; } set { _traveller = value; } }
        public Flight BookedFlight { get { return _bookedFlight; } set { _bookedFlight = value; } }
        public bool IsConfirmed { get { return _isConfirmed; } set { _isConfirmed = value; } }

        public Ticket(Passenger traveller, Flight bookedFlight) 
        {
            _traveller = traveller;
            _bookedFlight = bookedFlight;
        }

        public int TotalPrice()
        {
            if (_traveller.IsChild() == true)
            {
                return (int)(_bookedFlight.BasePrice * 0.50 + (_traveller.BagCount * 8000));
            }
            else
            {
                return (int)(_bookedFlight.BasePrice + (_traveller.BagCount * 8000));
            }
        }

        public bool Confirm()
        {
            if (_isConfirmed == true) 
            {
                return false;
            }
            else
            {
                if(_bookedFlight.FreeSeats > 0)
                {
                    _bookedFlight.BookSeat();
                    _isConfirmed = true;
                    return true;
                }
            }
            return false;
        }
        
    }
}
