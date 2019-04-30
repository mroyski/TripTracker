using Microsoft.EntityFrameworkCore;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Data
{
    public class TripContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }
    }
}
