  
using Microsoft.EntityFrameworkCore;
namespace CharactersPowers.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<CharacterHasPower> CharacterHasPowers { get; set; }
    }
}