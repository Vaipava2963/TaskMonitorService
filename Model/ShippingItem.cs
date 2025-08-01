using System.ComponentModel.DataAnnotations;

namespace ShippingServices.Model
{
    public class ShippingItem
    {
        [Key]
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public DateTime ItemShippedDate { get; set; }
    }
}
