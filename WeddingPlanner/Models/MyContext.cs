using Microsoft.EntityFrameworkCore;
namespace WeddingPlanner.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Monsters" table name will come from the DbSet variable name
        public DbSet<RegisterUser> Users { get; set; }
        public DbSet<WeddingUsers> WedUsers { get; set; }
        public DbSet<RSVP> RSVPUsers { get; set; }
    }
}