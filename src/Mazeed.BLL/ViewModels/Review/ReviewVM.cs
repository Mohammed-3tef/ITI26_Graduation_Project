namespace Mazeed.BLL.ViewModels
{
    public class ReviewVM
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public long UserId { get; set; }
        public string ReviewerName { get; set; } = null!;
        public int Rate { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}