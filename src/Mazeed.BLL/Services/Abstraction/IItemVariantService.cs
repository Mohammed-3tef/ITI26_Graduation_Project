using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IItemVariantService
    {
        Task<ServiceResponse<IEnumerable<ItemVariantVM>>> GetAllAsync();
        Task<ServiceResponse<ItemVariantVM>> GetByIdAsync(long id);
        Task<ServiceResponse<ItemVariantVM>> CreateAsync(ItemVariantVM model);
        Task<ServiceResponse<bool>> UpdateAsync(ItemVariantVM model);
        Task<ServiceResponse<bool>> DeleteAsync(long id);
    }
}