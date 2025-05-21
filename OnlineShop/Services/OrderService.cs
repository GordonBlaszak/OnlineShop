using Database;
using OnlineShopModels.Dto;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Services
{
    public class OrderService:IOrderService
    {

        public IEnumerable<FilteredOrderResultDto> GetFiltered()
        {
            using (OrdersContext db = new OrdersContext())
            {
                var sql = @"
            SELECT o.OrderId, o.City, SUM(ol.NetPrice * ol.Quantity) AS TotalNet
            FROM Orders o
            JOIN OrderLines ol ON o.OrderId = ol.OrderId
            JOIN Stores s ON o.StoreId = s.StoreId
            WHERE s.StoreId % 2 = 0 AND o.City LIKE '%a%'
            GROUP BY o.OrderId, o.City";

                return db.Database.SqlQuery<FilteredOrderResultDto>(sql).ToList();
            }
        }
    }
}