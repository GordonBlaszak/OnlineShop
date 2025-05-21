using System.Collections.Generic;

namespace OnlineShop.Entities
{
    public class StoreEntity
    {
        public int StoreId { get; set; }
        public string Name { get; set; }
        public ICollection<OrderEntity> Orders { get; set; }
    }
}