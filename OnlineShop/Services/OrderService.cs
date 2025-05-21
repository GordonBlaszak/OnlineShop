using Database;
using OnlineShopModels.Dto;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Services
{
    public class OrderService : IOrderService
    {

        public IEnumerable<FilteredOrderResultDto> GetFiltered()
        {
            using (OrdersContext db = new OrdersContext())
            {
                var query = from o in db.Orders
                            join ol in db.OrderLines on o.OrderId equals ol.OrderId
                            join s in db.Stores on o.StoreId equals s.StoreId
                            where s.StoreId % 2 == 0 && o.City.Contains("a")
                            group new { o, ol } by new { o.OrderId, o.City } into g
                            select new FilteredOrderResultDto
                            {
                                OrderId = g.Key.OrderId,
                                City = g.Key.City,
                                TotalNet = g.Sum(x => x.ol.NetPrice * x.ol.Quantity)
                            };

                return query.ToList();
            }
        }
    }
}