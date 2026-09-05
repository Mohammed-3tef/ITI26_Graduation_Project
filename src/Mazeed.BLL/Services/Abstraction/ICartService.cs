using Mazeed.BLL.Responses;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.Cart;

namespace Mazeed.BLL.Services.Abstraction
{
    public interface ICartService
    {
        Task<ServiceResponse<CartVM>> GetCartAsync(long userId);
        Task<ServiceResponse<CartItemVM>> AddToCartAsync(long userId, AddToCartVM model);
        Task<ServiceResponse<CartItemVM>> UpdateQuantityAsync(long userId, long itemVariantId, UpdateCartQuantityVM model);
        Task<ServiceResponse<bool>> RemoveFromCartAsync(long userId, long itemVariantId);
        Task<ServiceResponse<bool>> ClearCartAsync(long userId);
        Task<ServiceResponse<long>> CreateOrderAsync(long userId, CheckoutVM model);
        Task<ServiceResponse<bool>> CompletePaymentAsync(long orderId, bool succeeded, string? transactionId);
        Task<ServiceResponse<bool>> SetPaymobOrderIdAsync(long orderId, long paymobOrderId);
        Task<ServiceResponse<long>> GetLocalOrderIdByPaymobOrderIdAsync(long paymobOrderId);
    }
}