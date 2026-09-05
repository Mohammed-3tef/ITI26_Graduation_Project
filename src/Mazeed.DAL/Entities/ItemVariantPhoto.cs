using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class ItemVariantPhoto : BaseEntity
    {
        [MaxLength(500)]
        public string PhotoUrl { get; set; } = string.Empty;

        // Foreign Key
        [ForeignKey(nameof(ItemVariant))]
        public long ItemVariantId { get; set; }
        public ItemVariant ItemVariant { get; set; } = null!;
    }
}
