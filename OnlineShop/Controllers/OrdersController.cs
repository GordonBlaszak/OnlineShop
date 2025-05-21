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

        [HttpGet]
        public ActionResult GetFilteredOrders()
        {
            try
            {
                return Json(_orderService.GetFiltered(), JsonRequestBehavior.AllowGet);

            }
            catch (Exception e)
            {
                //some logging
                return View("Error");

            }
        }
    }
}