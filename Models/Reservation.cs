using System;

namespace AsinTransientAndApartment.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NumberOfGuest { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public int ProcessedBy { get; set; }
        public DateTime ProcessedDate { get; set; }
        public string Comment { get; set; }
    }
}
