using System;
using System.Collections.Generic;
using Kidly.Interview.Web.Order;

namespace Kidly.Interview.Web.Models.Order
{
    public class OrderService
    {
        public Web.Order.Order LoadOrder(int orderId)
        {
            var orderLines = new List<OrderLine>();
            orderLines.Add(new OrderLine(){Id = 1, Quantity = 1,Sku = "KD01", UnitPrice = 12m});
            orderLines.Add(new OrderLine() { Id = 2, Quantity = 2, Sku = "KD02", UnitPrice =7m });
            orderLines.Add(new OrderLine() { Id = 3, Quantity = 3, Sku = "KD03", UnitPrice =5.50m });

            return new Web.Order.Order()
            {
                Id = 1001,
                CustomerId = 1,
                DatePlaced = new DateTime(2020,01,10,11, 22, 33),
                OrderLines = orderLines,
                DeliveryCost = 5m
            };
        }
    }
}