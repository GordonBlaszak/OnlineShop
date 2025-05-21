namespace OnlineShop.Entities
{
    public class OrderLineEntity
    {
        public int OrderLineId { get; set; }
        public string ProductCode { get; set; }
        public decimal NetPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public OrderEntity Order { get; set; }
    }
}