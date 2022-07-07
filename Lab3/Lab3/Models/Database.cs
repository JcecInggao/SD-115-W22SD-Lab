using HotelReview;
namespace Lab3.Models
{
    public static class Database
    {
        public static int IdCounter { get; set; }

        static Database()
        {
            List<Room> Rooms = new List<Room>();
            List<Client> Clients = new List<Client>();
            List<Reservation> Reservations = new List<Reservation>();

        }

    }
}
