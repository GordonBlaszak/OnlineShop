using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Database.Entities
{
    public class StoreEntity
    {
        [Key]
        public long StoreId { get; set; }
        public string Name { get; set; }
        public ICollection<OrderEntity> Orders { get; set; }
    }
}