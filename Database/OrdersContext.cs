using Database.Entities;
using System.Data.Entity;

namespace Database
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

            modelBuilder.Entity<OrderEntity>()
          .HasRequired(o => o.Store)
          .WithMany(s => s.Orders)
          .HasForeignKey(o => o.StoreId);

            modelBuilder.Entity<OrderLineEntity>()
                .HasRequired(ol => ol.Order)
                .WithMany(o => o.OrderLines)
                .HasForeignKey(ol => ol.OrderId);
        }
    }
}
