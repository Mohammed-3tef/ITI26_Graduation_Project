using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.Search;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IItemVariantService
    {
        Task<ServiceResponse<IEnumerable<ItemVariantVM>>> GetAllAsync();
        Task<ServiceResponse<ItemVariantVM>> GetByIdAsync(long id);
        Task<ServiceResponse<ItemVariantVM>> CreateAsync(ItemVariantVM model);
        Task<ServiceResponse<bool>> UpdateAsync(ItemVariantVM model);
        Task<ServiceResponse<bool>> DeleteAsync(long id);
        Task<ServiceResponse<IEnumerable<ColorItem>>> GetDistinctColors();
        Task<ServiceResponse<IEnumerable<string>>> GetDistinctSize();

    }
}