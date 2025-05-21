using OnlineShop.Database;
using OnlineShopModels.Dto;
using System.Linq;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class OrdersApiController : Controller
    {
        private OrdersContext db = new OrdersContext();

        [HttpGet]
        [Route("api/orders/filtered")]
        public ActionResult GetFilteredOrders()
        {
            var sql = @"
            SELECT o.OrderId, o.City, SUM(ol.NetPrice * ol.Quantity) AS TotalNet
            FROM Orders o
            JOIN OrderLines ol ON o.OrderId = ol.OrderId
            JOIN Stores s ON o.StoreId = s.StoreId
            WHERE s.StoreId % 2 = 0 AND o.City LIKE '%a%'
            GROUP BY o.OrderId, o.City";

            var result = db.Database.SqlQuery<FilteredOrderResultDto>(sql).ToList();
            return View(result);
        }
    }

}