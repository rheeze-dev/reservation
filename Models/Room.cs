using System;

namespace AsinTransientAndApartment.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public int Capacity { get; set; }
        public int Type { get; set; }
        public int Amount { get; set; }
        public int Status { get; set; }
        public DateTime VacantDate { get; set; }
    }
}
