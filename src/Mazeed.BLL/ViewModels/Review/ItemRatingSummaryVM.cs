namespace Mazeed.BLL.ViewModels
{
    public class ItemRatingSummaryVM
    {
        public long ItemId { get; set; }
        public int ReviewCount { get; set; }
        public double AverageRating { get; set; }
    }
}