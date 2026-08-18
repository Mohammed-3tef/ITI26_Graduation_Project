using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface IDiscountService
    {
        Task<ServiceResponse<IEnumerable<DiscountRuleVM>>> GetAllDiscountRulesAsync();
        Task<ServiceResponse<DiscountRuleVM>> GetDiscountRuleByIdAsync(long id);
        Task<ServiceResponse<DiscountRuleVM>> CreateDiscountRuleAsync(CreateDiscountRuleVM model, string createdBy);
        Task<ServiceResponse<DiscountRuleVM>> UpdateDiscountRuleAsync(long id, UpdateDiscountRuleVM model, string updatedBy);
        Task<ServiceResponse<bool>> DeleteDiscountRuleAsync(long id, string deletedBy);
        Task<ServiceResponse<DiscountResultVM>> ValidateAndApplyAsync(ApplyPromoCodeVM model);
    }
}