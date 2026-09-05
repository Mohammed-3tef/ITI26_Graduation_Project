using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class Item : BaseEntity
    {
        [Required, MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string Code { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? Description { get; set; }

        [Required, Range(0, 1000000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        // Foreign Key
        [ForeignKey(nameof(Brand))]
        public long BrandId { get; set; }
        public Brand Brand { get; set; } = null!;

        // Navigation Properties
        public ICollection<ItemPhoto> Photos { get; set; } = new List<ItemPhoto>();
        public ICollection<ItemVariant> Variants { get; set; } = new List<ItemVariant>();
        public ICollection<ItemCategory> ItemCategories { get; set; } = new List<ItemCategory>();
        public ICollection<ShopperFavorite> Favorites { get; set; } = new List<ShopperFavorite>();
        public ICollection<ItemReview> Reviews { get; set; } = new List<ItemReview>();
    }
}
