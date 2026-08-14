using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class Brand : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(500)]
        public string? Logo { get; set; }

        // Navigation Properties
        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
