using System.ComponentModel.DataAnnotations.Schema;

namespace Mazeed.DAL.Entities
{
    public class Governorate
    {
        public long Id { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }

        [ForeignKey("Province")]
        public long ProvinceId { get; set; }

        [ForeignKey(nameof(ProvinceId))]
        public Province Province { get; set; }
    }
}
