using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class UpdateCartQuantityVM
    {
        [Range(1, 1000)]
        public int Quantity { get; set; }
    }
}