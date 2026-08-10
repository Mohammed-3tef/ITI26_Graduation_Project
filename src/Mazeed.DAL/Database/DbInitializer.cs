using Mazeed.DAL.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Mazeed.DAL.Database
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            RoleSeeder.Seed(_modelBuilder);
        }
    }
}
