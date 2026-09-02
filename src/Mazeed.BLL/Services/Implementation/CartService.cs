using Mazeed.BLL.Responses;
using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.Cart;
using Mazeed.DAL.Entities;
using Mazeed.DAL.Repos.Abstraction;

namespace Mazeed.BLL.Services.Implementation
{
    public class CartService : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICartRepository _cartRepository;

        public CartService(IUnitOfWork unitOfWork, ICartRepository cartRepository)
        {
            _unitOfWork = unitOfWork;
            _cartRepository = cartRepository;
        }

        public async Task<ServiceResponse<CartVM>> GetCartAsync(long userId)
        {
            var cartItems = await _cartRepository.GetCartByUserIdAsync(userId);
            var itemVMs = cartItems.Select(MapToCartItemVM).ToList();

            var cartVM = new CartVM
            {
                Items = itemVMs,
                TotalItemsCount = itemVMs.Sum(i => i.Quantity),
                Subtotal = itemVMs.Sum(i => i.LineTotal)
            };

            return ServiceResponse<CartVM>.SuccessResponse(cartVM, "Cart retrieved successfully.");
        }

        public async Task<ServiceResponse<CartItemVM>> AddToCartAsync(long userId, AddToCartVM model)
        {
            var variant = await _unitOfWork.Repository<ItemVariant>().GetByIdAsync(model.ItemVariantId);
            if (variant == null || variant.IsDeleted)
                return ServiceResponse<CartItemVM>.FailureResponse("Item variant not found.");

            var existing = await _cartRepository.GetCartItemAsync(userId, model.ItemVariantId);
            var newQuantity = (existing?.Quantity ?? 0) + model.Quantity;

            if (newQuantity > variant.StockQuantity)
                return ServiceResponse<CartItemVM>.FailureResponse($"Only {variant.StockQuantity} unit(s) available in stock.");

            if (existing != null)
            {
                existing.Quantity = newQuantity;
                _cartRepository.Update(existing);
            }
            else
            {
                existing = new ShopperCart
                {
                    UserId = userId,
                    ItemVariantId = model.ItemVariantId,
                    Quantity = model.Quantity
                };
                await _cartRepository.AddAsync(existing);
            }

            await _unitOfWork.CompleteAsync();

            var reloaded = await _cartRepository.GetCartItemAsync(userId, model.ItemVariantId);
            return ServiceResponse<CartItemVM>.SuccessResponse(MapToCartItemVM(reloaded!), "Item added to cart.");
        }

        public async Task<ServiceResponse<CartItemVM>> UpdateQuantityAsync(long userId, long itemVariantId, UpdateCartQuantityVM model)
        {
            if (model.Quantity <= 0)
                return ServiceResponse<CartItemVM>.FailureResponse("Quantity must be greater than 0. Use remove to delete the item instead.");

            var existing = await _cartRepository.GetCartItemAsync(userId, itemVariantId);
            if (existing == null)
                return ServiceResponse<CartItemVM>.FailureResponse("This item is not in your cart.");

            if (model.Quantity > existing.ItemVariant.StockQuantity)
                return ServiceResponse<CartItemVM>.FailureResponse($"Only {existing.ItemVariant.StockQuantity} unit(s) available in stock.");

            existing.Quantity = model.Quantity;
            _cartRepository.Update(existing);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<CartItemVM>.SuccessResponse(MapToCartItemVM(existing), "Cart item updated.");
        }

        public async Task<ServiceResponse<bool>> RemoveFromCartAsync(long userId, long itemVariantId)
        {
            var existing = await _cartRepository.GetCartItemAsync(userId, itemVariantId);
            if (existing == null)
                return ServiceResponse<bool>.FailureResponse("This item is not in your cart.");

            _cartRepository.Delete(existing);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<bool>.SuccessResponse(true, "Item removed from cart.");
        }

        public async Task<ServiceResponse<bool>> ClearCartAsync(long userId)
        {
            var cartItems = (await _cartRepository.GetCartByUserIdForDeleteAsync(userId)).ToList(); // was GetCartByUserIdAsync
            if (!cartItems.Any())
                return ServiceResponse<bool>.SuccessResponse(true, "Cart is already empty.");

            _cartRepository.DeleteRange(cartItems);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<bool>.SuccessResponse(true, "Cart cleared.");
        }

        public async Task<ServiceResponse<long>> CreateOrderAsync(long userId, CheckoutVM model)
        {
            var cartItems = (await _cartRepository.GetCartByUserIdForDeleteAsync(userId)).ToList();
            if (!cartItems.Any())
                return ServiceResponse<long>.FailureResponse("Your cart is empty.");

            foreach (var cartItem in cartItems)
            {
                if (cartItem.Quantity > cartItem.ItemVariant.StockQuantity)
                    return ServiceResponse<long>.FailureResponse($"Only {cartItem.ItemVariant.StockQuantity} unit(s) of {cartItem.ItemVariant.Item.Name} are available.");
            }

            var total = cartItems.Sum(item =>
                (item.ItemVariant.Item.Price + item.ItemVariant.PriceAdjustment) * item.Quantity);

            var order = new Order
            {
                UserId = userId,
                CreatedBy = userId.ToString(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                ShippingAddress = model.ShippingAddress,
                TotalPrice = total,
                Status = "Pending",
                Payment = new Payment
                {
                    CreatedBy = userId.ToString(),
                    Method = "Paymob",
                    Amount = total,
                    Status = "Pending"
                }
            };

            foreach (var cartItem in cartItems)
            {
                var unitPrice = cartItem.ItemVariant.Item.Price + cartItem.ItemVariant.PriceAdjustment;
                order.OrderDetails.Add(new OrderDetail
                {
                    CreatedBy = userId.ToString(),
                    ItemVariantId = cartItem.ItemVariantId,
                    Quantity = cartItem.Quantity,
                    PricePerItem = unitPrice
                });
                cartItem.ItemVariant.StockQuantity -= cartItem.Quantity;
            }

            await _unitOfWork.Repository<Order>().AddAsync(order);
            _cartRepository.DeleteRange(cartItems);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<long>.SuccessResponse(order.Id, "Order created. Continue to Paymob to complete payment.");
        }

        public async Task<ServiceResponse<bool>> CompletePaymentAsync(long orderId, bool succeeded, string? transactionId)
        {
            var payments = await _unitOfWork.Repository<Payment>().FindAsync(payment => payment.OrderId == orderId);
            var payment = payments.FirstOrDefault();
            var order = await _unitOfWork.Repository<Order>().GetByIdAsync(orderId);

            if (payment == null || order == null)
                return ServiceResponse<bool>.FailureResponse("Order payment was not found.");

            payment.Status = succeeded ? "Paid" : "Failed";
            payment.TransactionId = transactionId;
            payment.PaidAt = succeeded ? DateTime.UtcNow : null;
            order.Status = succeeded ? "Paid" : "Payment failed";
            _unitOfWork.Repository<Payment>().Update(payment);
            _unitOfWork.Repository<Order>().Update(order);
            await _unitOfWork.CompleteAsync();

            return ServiceResponse<bool>.SuccessResponse(true);
        }

        public async Task<ServiceResponse<bool>> SetPaymobOrderIdAsync(long orderId, long paymobOrderId)
        {
            var payments = await _unitOfWork.Repository<Payment>().FindAsync(payment => payment.OrderId == orderId);
            var payment = payments.FirstOrDefault();
            if (payment == null)
                return ServiceResponse<bool>.FailureResponse("Order payment was not found.");

            payment.PaymobOrderId = paymobOrderId;
            _unitOfWork.Repository<Payment>().Update(payment);
            await _unitOfWork.CompleteAsync();
            return ServiceResponse<bool>.SuccessResponse(true);
        }

        public async Task<ServiceResponse<long>> GetLocalOrderIdByPaymobOrderIdAsync(long paymobOrderId)
        {
            var payments = await _unitOfWork.Repository<Payment>().FindAsync(payment => payment.PaymobOrderId == paymobOrderId);
            var payment = payments.FirstOrDefault();
            return payment == null
                ? ServiceResponse<long>.FailureResponse("Paymob order was not found.")
                : ServiceResponse<long>.SuccessResponse(payment.OrderId);
        }

        private static CartItemVM MapToCartItemVM(ShopperCart cart)
        {
            var variant = cart.ItemVariant;
            var item = variant.Item;
            var unitPrice = item.Price + variant.PriceAdjustment;

            return new CartItemVM
            {
                ItemVariantId = variant.Id,
                ItemId = item.Id,
                ItemName = item.Name,
                BrandName = item.Brand?.Name,
                SKU = variant.SKU,
                Color = variant.Color,
                Size = variant.Size,
                UnitPrice = unitPrice,
                Quantity = cart.Quantity,
                LineTotal = unitPrice * cart.Quantity,
                StockQuantity = variant.StockQuantity,
                ImageUrl = item.Photos?.FirstOrDefault()?.PhotoUrl
            };
        }
    }
}