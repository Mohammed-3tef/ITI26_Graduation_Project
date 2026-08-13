using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Repos.Abstraction
{
    public interface IUnitOfWork : IDisposable
    {
     
        IGenericRepository<T> Repository<T>() where T : class;

        Task<int> CompleteAsync();
    }
}
