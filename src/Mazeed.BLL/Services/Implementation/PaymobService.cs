using System.Net.Http.Json;
using System.Text.Json;
using Mazeed.BLL.Helpers;
using Mazeed.BLL.ViewModels.Cart;
using Microsoft.Extensions.Configuration;

namespace Mazeed.BLL.Services
{
    public sealed record PaymobPaymentSession(long PaymobOrderId, string PaymentUrl);

    public class PaymobService
    {
        private readonly HttpClient _httpClient;
        private readonly PaymobSettings _settings;

        public PaymobService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _settings = configuration.GetSection("Paymob").Get<PaymobSettings>() ?? new PaymobSettings();
            _httpClient.BaseAddress = new Uri(_settings.BaseUrl);
        }

        public bool IsConfigured => !string.IsNullOrWhiteSpace(_settings.ApiKey) &&
                                     !string.IsNullOrWhiteSpace(_settings.IntegrationId) &&
                                     !string.IsNullOrWhiteSpace(_settings.IframeId);

        public async Task<PaymobPaymentSession> CreatePaymentUrlAsync(
            long localOrderId,
            decimal amount,
            CheckoutVM checkout,
            string? email,
            string redirectionUrl)
        {
            if (!IsConfigured)
                throw new InvalidOperationException("Paymob is not configured. Add Paymob:ApiKey, IntegrationId, and IframeId.");

            var authResponse = await _httpClient.PostAsJsonAsync("/api/auth/tokens", new { api_key = _settings.ApiKey });
            authResponse.EnsureSuccessStatusCode();
            using var authJson = JsonDocument.Parse(await authResponse.Content.ReadAsStringAsync());
            var authToken = authJson.RootElement.GetProperty("token").GetString()!;
            var amountCents = decimal.ToInt32(decimal.Round(amount * 100, 0));

            var orderResponse = await _httpClient.PostAsJsonAsync("/api/ecommerce/orders", new
            {
                auth_token = authToken,
                delivery_needed = false,
                amount_cents = amountCents,
                currency = "EGP",
                merchant_order_id = localOrderId.ToString(),
                items = Array.Empty<object>()
            });
            orderResponse.EnsureSuccessStatusCode();
            using var orderJson = JsonDocument.Parse(await orderResponse.Content.ReadAsStringAsync());
            var paymobOrderId = orderJson.RootElement.GetProperty("id").GetInt64();

            var paymentKeyResponse = await _httpClient.PostAsJsonAsync("/api/acceptance/payment_keys", new
            {
                auth_token = authToken,
                amount_cents = amountCents,
                expiration = 3600,
                order_id = paymobOrderId,
                billing_data = new
                {
                    apartment = "NA",
                    email = email ?? "customer@mazeed.local",
                    floor = "NA",
                    first_name = checkout.FirstName,
                    street = checkout.ShippingAddress,
                    building = "NA",
                    phone_number = checkout.PhoneNumber,
                    shipping_method = "PKG",
                    postal_code = "NA",
                    city = "NA",
                    last_name = checkout.LastName,
                    state = "NA",
                    country = "EGY"
                },
                currency = "EGP",
                integration_id = int.Parse(_settings.IntegrationId),
                redirection_url = redirectionUrl
            });
            paymentKeyResponse.EnsureSuccessStatusCode();
            using var paymentKeyJson = JsonDocument.Parse(await paymentKeyResponse.Content.ReadAsStringAsync());
            var paymentToken = paymentKeyJson.RootElement.GetProperty("token").GetString()!;

            return new PaymobPaymentSession(
                paymobOrderId,
                $"{_settings.BaseUrl}/api/acceptance/iframes/{_settings.IframeId}?payment_token={Uri.EscapeDataString(paymentToken)}");
        }
    }
}