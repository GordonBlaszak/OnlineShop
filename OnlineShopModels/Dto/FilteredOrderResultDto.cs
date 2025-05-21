namespace OnlineShopModels.Dto
{
    public class FilteredOrderResultDto
    {
        public long OrderId { get; set; }
        public string City { get; set; }
        public decimal TotalNet { get; set; }
    }
}
