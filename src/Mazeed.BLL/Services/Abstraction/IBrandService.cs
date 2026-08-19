using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IBrandService
    {
        Task<ServiceResponse<IEnumerable<BrandVM>>> GetAllAsync();
        Task<ServiceResponse<BrandVM>> GetByIdAsync(long id);
        Task<ServiceResponse<BrandVM>> CreateAsync(BrandVM model);
        Task<ServiceResponse<bool>> UpdateAsync(BrandVM model);
        Task<ServiceResponse<bool>> DeleteAsync(long id);
    }
}
