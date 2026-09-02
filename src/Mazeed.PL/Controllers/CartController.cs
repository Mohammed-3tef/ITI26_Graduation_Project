using Mazeed.BLL.Services.Abstraction;
using Mazeed.BLL.ViewModels;
using Mazeed.BLL.ViewModels.Cart;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Mazeed.BLL.Services;

namespace Mazeed.PL.Controllers
{
    [Authorize]
    [Route("api/cart")]
    public class CartController : ApiBaseController
    {
        private readonly ICartService _cartService;
        private readonly PaymobService _paymobService;
        private readonly IUserService _userService;

        public CartController(ICartService cartService, PaymobService paymobService, IUserService userService)
        {
            _cartService = cartService;
            _paymobService = paymobService;
            _userService = userService;
        }

        [HttpGet("/Cart")]
        public async Task<IActionResult> Index()
        {
            var result = await _cartService.GetCartAsync(CurrentUserId);
            await PopulateCheckoutFieldsAsync();
            return View(result.Data);
        }

        [HttpGet]
        public async Task<IActionResult> GetCart()
            => HandleResponse(await _cartService.GetCartAsync(CurrentUserId));

        [HttpPost]
        public async Task<IActionResult> AddToCart([FromBody] AddToCartVM model)
            => HandleResponse(await _cartService.AddToCartAsync(CurrentUserId, model));

        [HttpPut("{itemVariantId:long}")]
        public async Task<IActionResult> UpdateQuantity(long itemVariantId, [FromBody] UpdateCartQuantityVM model)
            => HandleResponse(await _cartService.UpdateQuantityAsync(CurrentUserId, itemVariantId, model));

        [HttpDelete("{itemVariantId:long}")]
        public async Task<IActionResult> RemoveFromCart(long itemVariantId)
            => HandleResponse(await _cartService.RemoveFromCartAsync(CurrentUserId, itemVariantId));

        [HttpDelete]
        public async Task<IActionResult> ClearCart()
            => HandleResponse(await _cartService.ClearCartAsync(CurrentUserId));

        [HttpGet("/Checkout")]
        public async Task<IActionResult> CheckOut()
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpPost("/Checkout")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckOut([FromForm] CheckoutVM model)
        {
            var cart = await _cartService.GetCartAsync(CurrentUserId);
            if (!ModelState.IsValid)
            {
                PopulateCheckoutFields(model);
                return View("Index", cart.Data);
            }

            if (!cart.Succeeded || cart.Data == null || !cart.Data.Items.Any())
                return RedirectToAction(nameof(Index));

            if (!_paymobService.IsConfigured)
            {
                ModelState.AddModelError(string.Empty, "Paymob is not configured. Please contact the store administrator.");
                PopulateCheckoutFields(model);
                return View("Index", cart.Data);
            }

            var cartTotal = cart.Data.Subtotal;

            var result = await _cartService.CreateOrderAsync(CurrentUserId, model);
            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, result.Message ?? "Unable to create your order.");
                PopulateCheckoutFields(model);
                return View("Index", cart.Data);
            }

            try
            {
                var paymentSession = await _paymobService.CreatePaymentUrlAsync(
                    result.Data,
                    cartTotal,
                    model,
                    User.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value,
                    Url.Action(nameof(PaymobResult), "Cart", null, Request.Scheme, Request.Host.Value)!);
                await _cartService.SetPaymobOrderIdAsync(result.Data, paymentSession.PaymobOrderId);
                return Redirect(paymentSession.PaymentUrl);
            }
            catch (Exception exception) when (exception is HttpRequestException or InvalidOperationException or FormatException)
            {
                ModelState.AddModelError(string.Empty, exception.Message);
                var cartData = await _cartService.GetCartAsync(CurrentUserId);
                PopulateCheckoutFields(model);
                return View("Index", cartData.Data);
            }
        }

        [AllowAnonymous]
        [IgnoreAntiforgeryToken]
        [HttpPost("/Checkout/PaymobCallback")]
        public async Task<IActionResult> PaymobCallback([FromBody] JsonElement payload)
        {
            var obj = payload.TryGetProperty("obj", out var objProperty) ? objProperty : payload;
            var success = obj.TryGetProperty("success", out var successProperty) && successProperty.GetBoolean();
            var transactionId = obj.TryGetProperty("id", out var idProperty) ? idProperty.ToString() : null;
            var paymobOrder = obj.TryGetProperty("order", out var orderProperty) &&
                              orderProperty.TryGetProperty("merchant_order_id", out var merchantOrder)
                ? merchantOrder.ToString()
                : null;

            if (!long.TryParse(paymobOrder, out var localOrderId))
                return BadRequest();

            var result = await _cartService.CompletePaymentAsync(localOrderId, success, transactionId);
            return result.Succeeded ? Ok() : BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("/Checkout/PaymobResult")]
        public async Task<IActionResult> PaymobResult(
            [FromQuery] long? order,
            [FromQuery] string? success,
            [FromQuery] string? id)
        {
            if (!order.HasValue)
            {
                return View("PaymentResult", new PaymentResultVM
                {
                    IsSuccessful = false,
                    Message = "We could not identify this payment."
                });
            }

            var localOrder = await _cartService.GetLocalOrderIdByPaymobOrderIdAsync(order.Value);
            if (!localOrder.Succeeded)
            {
                return View("PaymentResult", new PaymentResultVM
                {
                    IsSuccessful = false,
                    Message = "We could not find the order associated with this payment."
                });
            }

            var isSuccessful = string.Equals(success, "true", StringComparison.OrdinalIgnoreCase);
            await _cartService.CompletePaymentAsync(localOrder.Data, isSuccessful, id);

            return View("PaymentResult", new PaymentResultVM
            {
                IsSuccessful = isSuccessful,
                OrderId = localOrder.Data,
                Message = isSuccessful
                    ? "Thank you for using the online payment service."
                    : "Your payment was not approved. No payment was taken."
            });
        }

        private async Task PopulateCheckoutFieldsAsync()
        {
            var email = User.FindFirst(System.Security.Claims.ClaimTypes.Email)?.Value;
            if (string.IsNullOrWhiteSpace(email))
                return;

            var user = await _userService.GetUserByEmailAsync(email);
            if (user.Data == null)
                return;

            ViewBag.CheckoutFirstName = user.Data.FirstName;
            ViewBag.CheckoutLastName = user.Data.LastName;
            ViewBag.CheckoutPhoneNumber = user.Data.PhoneNumber;
            ViewBag.CheckoutShippingAddress = user.Data.Street;
        }

        private void PopulateCheckoutFields(CheckoutVM model)
        {
            ViewBag.CheckoutFirstName = model.FirstName;
            ViewBag.CheckoutLastName = model.LastName;
            ViewBag.CheckoutPhoneNumber = model.PhoneNumber;
            ViewBag.CheckoutShippingAddress = model.ShippingAddress;
        }
    }
}