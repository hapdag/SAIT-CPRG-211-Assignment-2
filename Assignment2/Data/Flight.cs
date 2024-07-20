using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class Flight
    {
        private string _flightNumber;
        private string _airline;
        private string _departure;
        private string _arrival;
        private string _flightDay;
        private string _flightTime;
        private int _seats;
        private double _ticketCost;
        public string FlightNumber { get { return _flightNumber; } }
        public string Airline { get { return _airline; } }
        public string Departure { get { return _departure; } }
        public string Arrival { get { return _arrival; } }
        public string FlightDay { get { return _flightDay; } }
        public string FlightTime { get { return _flightTime; } }
        public int Seats {  get { return _seats; } }
        public double TicketCost {  get { return _ticketCost; } }

        public Flight( string flightNumber, string airline, string departure, string arrival, string flightDay, string flightTime, int seats, double ticketCost)
        {
            _flightNumber = flightNumber;
            _airline = airline;
            _departure = departure;
            _arrival = arrival;
            _flightDay = flightDay;
            _flightTime = flightTime;
            _seats = seats;
            _ticketCost = ticketCost;
        }
    }
}
