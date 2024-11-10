using Microsoft.EntityFrameworkCore;
using ThinkSmartAPI.Models;

namespace ThinkSmartAPI
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
: base(options)

        { }

        public DbSet<Students> Students { get; set; }
        public DbSet<Users> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
