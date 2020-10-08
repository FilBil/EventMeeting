using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventMeeting.Models
{
    public class DriveGuide 
    {
        public int Id { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String UserEmail { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
    }
}
