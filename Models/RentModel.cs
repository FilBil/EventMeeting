using System;
using Microsoft.AspNetCore.Identity;
namespace EventMeeting.Models
{
    public class RentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int RoomNumber { get; set; }
        public bool IsEmpty { get; set; }

    }
}