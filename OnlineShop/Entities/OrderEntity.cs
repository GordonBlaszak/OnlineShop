using OnlineShopModels.Enum;
using System.Collections.Generic;

namespace OnlineShop.Entities
{
    public class OrderEntity
    {
        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public StoreEntity Store { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public ICollection<OrderLineEntity> OrderLines { get; set; }
    }
}