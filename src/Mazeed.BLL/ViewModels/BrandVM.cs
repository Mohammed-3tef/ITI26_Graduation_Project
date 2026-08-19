using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.BLL.ViewModels
{
    public class BrandVM
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Brand name is required.")]
        [StringLength(50, ErrorMessage = "Brand name cannot exceed 50 characters.")]
        public string Name { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Logo URL cannot exceed 500 characters.")]
        public string? Logo { get; set; }
    }
}
