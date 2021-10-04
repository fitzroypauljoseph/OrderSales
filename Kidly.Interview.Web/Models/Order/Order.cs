using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kidly.Interview.Web.Views.Order;

namespace Kidly.Interview.Web.Order
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime DatePlaced { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public decimal DeliveryCost { get; set; }
    }

    public class OrderLine
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}