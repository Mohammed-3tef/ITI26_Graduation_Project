using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazeed.DAL.Entities
{
    public class Shipment : BaseEntity
    {
        [Required, MaxLength(100)]
        public string CarrierName { get; set; } = string.Empty;

        [Required, MaxLength(100)]
        public string TrackingNumber { get; set; } = string.Empty;

        [Required, MaxLength(30)]
        public string ShipmentStatus { get; set; } = "Preparing";

        public DateTime? ShippedDate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

        // Foreign Key
        [ForeignKey(nameof(Order))]
        public long OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
