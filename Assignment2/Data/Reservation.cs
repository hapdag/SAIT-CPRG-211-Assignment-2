using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class Reservation
    {
        private Flight _reservedFlight;
        private string _clientName;
        private string _clientCitizenship;
        private string _reservationCode;
        public Flight ReservedFlight { get { return _reservedFlight; } }
        public string ClientName { get { return _clientName; } }
        public string ClientCitizenship { get { return _clientCitizenship; } }
        public string ReservationCode { get { return _reservationCode; } }
        public Reservation(Flight flight, string clientName, string clientCitizenship)
        {
            if(flight.Seats > 0)
            {
                flight.Seats -= 1;
                _reservedFlight = flight;
                _clientName = clientName;
                _clientCitizenship = clientCitizenship;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
