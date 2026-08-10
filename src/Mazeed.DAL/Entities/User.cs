using Microsoft.AspNetCore.Identity;

namespace Mazeed.DAL.Entities
{
    public class User : IdentityUser<long>, IBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public char Gender { get; set; }

        public DateTime CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}