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
        private bool _reservationStatus;
        public Flight ReservedFlight { get { return _reservedFlight; } }
        public string ClientName { get { return _clientName; } }
        public string ClientCitizenship { get { return _clientCitizenship; } }
        public string ReservationCode { get { return _reservationCode; } }
        public bool ReservationStatus { get { return _reservationStatus; } }
        public Reservation(Flight flight, string clientName, string clientCitizenship)
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            List<string> code = new List<string>();
            Random rnd = new Random();
            int rndNum = rnd.Next(26);
            code.Add(letters[rndNum].ToString());
            for (int i = 0; i<4; i++)
            {
                rndNum = rnd.Next(9);
                code.Add(rndNum.ToString());
            }
            _reservationCode = String.Join("", code);
            flight.Seats -= 1;
            _reservedFlight = flight;
            _clientName = clientName;
            _clientCitizenship = clientCitizenship;
            _reservationStatus = true;
        }

        public void SetInactive()
        {
            _reservationStatus = false;
            _reservedFlight.Seats += 1;
        }
    }
}
