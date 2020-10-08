using EventMeeting.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EventMeeting.Data
{
    public class RentBraContext : DbContext
    {
        public RentBraContext(DbContextOptions<RentBraContext> options)
            : base(options)
        {
        }

        public DbSet<RentModel> RentBra { get; set; }
    }
}