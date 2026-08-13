using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class ItemPhoto : BaseEntity
    {
        [MaxLength(500)]
        public string PhotoUrl { get; set; } = string.Empty;

        // Foreign Key
        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;
    }
}
