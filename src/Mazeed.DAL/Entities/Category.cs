using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class Category : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty; // Ar / En
        [MaxLength(1000)]
        public string? Description { get; set; }

        // Navigation Properties
        public ICollection<ItemCategory> ItemCategories { get; set; } = new List<ItemCategory>();
    }
}
