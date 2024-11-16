using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        // Sample data (can be replaced with a database in the future)
        private static List<Hotel> hotels = new List<Hotel>
        {
            new Hotel { Id = 1, Name = "Hotel One", City = "New York", RoomsAvailable = 5 },
            new Hotel { Id = 2, Name = "Hotel Two", City = "Los Angeles", RoomsAvailable = 3 },
            new Hotel { Id = 3, Name = "Hotel Three", City = "Chicago", RoomsAvailable = 0 }
        };

        // GET: api/hotel
        [HttpGet]
        public ActionResult<List<Hotel>> GetHotels()
        {
            return Ok(hotels);
        }

        // GET: api/hotel/{id}
        [HttpGet("{id}")]
        public ActionResult<Hotel> GetHotel(int id)
        {
            var hotel = hotels.FirstOrDefault(h => h.Id == id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }
    }

    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int RoomsAvailable { get; set; }
    }
}
