using AnyarMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AnyarMVC.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Position> Positions { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
