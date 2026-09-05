using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Mazeed.DAL.Entities
{
    public class ItemPhoto : BaseEntity
    {
        [MaxLength(500)]
        public string PhotoUrl { get; set; } = string.Empty;

        // Foreign Key
        [ForeignKey(nameof(Item))]
        public long ItemId { get; set; }
        public Item Item { get; set; } = null!;
    }
}
