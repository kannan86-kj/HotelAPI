using System;

namespace HotelAPI.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int HotelRoomId { get; set; }  // Assuming you have a HotelRoom model
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalAmount { get; set; } // Total cost of the booking
    }
}
