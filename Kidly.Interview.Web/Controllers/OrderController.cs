using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kidly.Interview.Web.Models.Order;
using Kidly.Interview.Web.Models.Product;
using Kidly.Interview.Web.Order;
using Kidly.Interview.Web.Views.Order;

namespace Kidly.Interview.Web.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var orderService = new OrderService();

            var order = orderService.LoadOrder(1001);

            var model = new OrderViewModel()
            {
                OrderId = order.Id,
                DatePlaced = order.DatePlaced,
                DeliveryCost = order.DeliveryCost,
                OrderItems = MapOrderItems(order.OrderLines)
            };

            return View(model);
        }

        private List<OrderItem> MapOrderItems(List<OrderLine> orderLines)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (var orderLine in orderLines)
            {
                var productService = new ProductService();
                var product = productService.LoadProduct(orderLine.Sku);

                orderItems.Add(new OrderItem()
                {
                    Sku = orderLine.Sku,
                    Price = orderLine.UnitPrice,
                    Quantity = orderLine.Quantity,
                    ProductName = product.ProductName,
                    ImagePath = product.ImagePath
                });
            }

            return orderItems;
        }
    }
}