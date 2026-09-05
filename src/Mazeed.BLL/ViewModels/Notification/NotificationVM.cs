namespace Mazeed.BLL.ViewModels
{
    public class NotificationVM
    {
        public long Id { get; set; }
        public string Title { get; set; } = null!;
        public string Msg { get; set; } = null!;
        public string Type { get; set; } = null!;
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}