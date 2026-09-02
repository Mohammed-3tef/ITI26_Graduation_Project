using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels.Cart
{
    public class CheckoutVM
    {
        [Required, StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required, StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required, Phone, StringLength(30)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required, StringLength(150)]
        public string ShippingAddress { get; set; } = string.Empty;
    }
}