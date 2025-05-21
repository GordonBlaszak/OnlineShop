using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Entities
{
    public class OrderLineEntity
    {
        [Key]
        public long OrderLineId { get; set; }
        public string ProductCode { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public int Quantity { get; set; }
        public long OrderId { get; set; }
        public OrderEntity Order { get; set; }
    }
}