using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
