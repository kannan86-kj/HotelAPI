using HotelAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private static List<Booking> bookings = new List<Booking>(); // This should eventually be replaced by a database

        [HttpPost]
        public IActionResult BookRoom([FromBody] Booking booking)
        {
            // Validate the booking data
            if (booking == null || booking.CheckInDate >= booking.CheckOutDate)
            {
                return BadRequest("Invalid booking data.");
            }

            // For now, just add it to an in-memory list
            booking.Id = bookings.Count + 1; // Simulating auto-increment
            bookings.Add(booking);

            // Return a 201 Created response with the booking data
            return CreatedAtAction(nameof(BookRoom), new { id = booking.Id }, booking);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Booking>> GetBookings()
        {
            return Ok(bookings); // Return all bookings
        }
    }
}
