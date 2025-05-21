using Database.Entities;
using OnlineShopModels.Enum;
using System.Collections.Generic;
using System.Data.Entity;

namespace Database
{
    public class OrdersInitializer : DropCreateDatabaseAlways<OrdersContext>
    {
        protected override void Seed(OrdersContext context)
        {
            for (int i = 1; i <= 10; i++)
            {
                var store = new StoreEntity { Name = $"Sklep {i}" };
                context.Stores.Add(store);

                var order = new OrderEntity
                {
                    Store = store,
                    City = i % 2 == 0 ? "Warszawa" : "Kielce",
                    Street = "Ulica " + i,
                    PostalCode = "00-00" + i,
                    PaymentMethod = (PaymentMethod)(i % 3),
                    OrderLines = new List<OrderLineEntity>
                {
                    new OrderLineEntity
                    {
                        ProductCode = $"P{i}",
                        NetPrice = 100 + i,
                        GrossPrice = 123 + i,
                        Quantity = 1
                    }
                }
                };

                context.Orders.Add(order);
            }

            context.SaveChanges();
        }
    }
}