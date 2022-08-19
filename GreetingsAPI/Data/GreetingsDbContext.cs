using Microsoft.EntityFrameworkCore;
using GreetingsAPI.Models;

namespace GreetingsAPI.Data
{
    public class GreetingsDbContext : DbContext
    {
        public DbSet<Greeting>? greetings { get; set; }

        public GreetingsDbContext(DbContextOptions<GreetingsDbContext> options) : base(options)
        { 
        }

    }
}
