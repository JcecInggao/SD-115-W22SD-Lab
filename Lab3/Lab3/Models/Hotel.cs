using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReview
{
    class Hotel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Client> Clients { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Hotel(string name, string address)
        {
            Name = name;
            Address = address;
            Clients = new List<Client>();
            Rooms = new List<Room>();
            Reservations = new List<Reservation>();
        }
    }
}
