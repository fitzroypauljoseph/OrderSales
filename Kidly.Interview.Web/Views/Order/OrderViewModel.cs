using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kidly.Interview.Web.Views.Order
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public DateTime DatePlaced { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal DeliveryCost { get; set; }
    }

    public class OrderItem
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
        public string ImagePath { get; set; }
    }
}