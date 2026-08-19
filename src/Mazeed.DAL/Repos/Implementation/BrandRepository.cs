using Mazeed.DAL.Database;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Repos.Implementation
{
    public class BrandRepository : GenericRepository<Brand>, IBrandRepository
    {
        public BrandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
