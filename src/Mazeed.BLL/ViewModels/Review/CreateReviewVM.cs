using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class CreateReviewVM
    {
        [Required]
        public long ItemId { get; set; }

        [Range(1, 5)]
        public int Rate { get; set; }

        [MaxLength(1000)]
        public string? Comment { get; set; }
    }
}