using OnlineShopModels.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class OrderEntity
    {
        [Key]
        public long OrderId { get; set; }
        public long StoreId { get; set; }
        public virtual StoreEntity Store { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
        public ICollection<OrderLineEntity> OrderLines { get; set; }
    }
}