using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IItemService
    {
        Task<ServiceResponse<IEnumerable<ItemVM>>> GetAllAsync();
        Task<ServiceResponse<ItemVM>> GetByIdAsync(long id);
        Task<ServiceResponse<ItemVM>> CreateAsync(ItemVM model);
        Task<ServiceResponse<bool>> UpdateAsync(ItemVM model);
        Task<ServiceResponse<bool>> DeleteAsync(long id);
    }
}