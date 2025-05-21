using OnlineShop.Entities;
using System.Data.Entity;

namespace OnlineShop.Database
{
    public class OrdersContext : DbContext
    {
        public DbSet<StoreEntity> Stores { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderLineEntity> OrderLines { get; set; }
        public OrdersContext() : base("OrdersConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}