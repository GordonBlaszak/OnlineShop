using OnlineShop.Services;
using System;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class OrdersController : Controller
    {
        //TODO IoC
        private readonly IOrderService _orderService;

        public OrdersController()
        {
            _orderService = new OrderService();
        }

        public ActionResult GetFilteredOrders()
        {
            try
            {
                return View(_orderService.GetFiltered());
            }
            catch (Exception e)
            {
                //some logging
                return View("Error");

            }
        }
    }
}