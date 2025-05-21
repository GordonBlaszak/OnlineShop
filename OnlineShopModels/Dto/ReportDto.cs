using OnlineShopModels.Enum;

namespace OnlineShopModels.Dto
{
    public class ReportDto
    {
        public PaymentMethod PaymentMethod { get; set; }
        public int OrderCount { get; set; }
        public decimal TotalGross { get; set; }
    }
}
