using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class CategoryVM
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(50, ErrorMessage = "Category name cannot exceed 50 characters.")]
        public string Name { get; set; } = string.Empty;
    }
}