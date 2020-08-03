using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventMeeting.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime EventStart { get; set; }
        public bool IsPaid { get; set; }
    }
}
