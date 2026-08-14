using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class City
    {
        public long Id { get; set; }
        public string ArabicName { get; set; }
        public string EnglishName { get; set; }

        public long GovernorateId { get; set; }
        [JsonIgnore]
        [ForeignKey(nameof(GovernorateId))]
        public Governorate Governorate { get; set; }
    }
}
