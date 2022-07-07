using Microsoft.AspNetCore.Mvc;
using Lab3.Models;
using HotelReview;

namespace Lab3.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllRooms(int number, int capacity, bool occupied)
        {
            return View();
        }

        public IActionResult Capacity(int capacity)
        {
            if (capacity <= 0)
            {
                ViewBag.Message = "No more than 25 employees should be in this building, according to local fire codes";
            }
            return View();
        }

        public IActionResult FindRoom(int occupants)
        {
            //Room foundRoom = Database.Room.First(r => r.Capacity >= occupants);
            //return View(foundRoom);
            return View();
        }
    }
}
