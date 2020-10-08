using System;
using Microsoft.AspNetCore.Identity;
namespace EventMeeting.Models
{
    public class RentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int RoomNumber { get; set; }
        public Enum Features { get; set; }
        public bool IsEmpty { get; set; }

    }
}