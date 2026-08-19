using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface ICategoryService
    {
        Task<ServiceResponse<IEnumerable<CategoryVM>>> GetAllAsync();
        Task<ServiceResponse<CategoryVM>> GetByIdAsync(long id);
        Task<ServiceResponse<CategoryVM>> CreateAsync(CategoryVM model);
        Task<ServiceResponse<bool>> UpdateAsync(CategoryVM model);
        Task<ServiceResponse<bool>> DeleteAsync(long id);
    }
}