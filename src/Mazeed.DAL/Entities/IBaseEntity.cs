namespace Mazeed.DAL.Entities
{
    public interface IBaseEntity
    {
        public DateTime CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
