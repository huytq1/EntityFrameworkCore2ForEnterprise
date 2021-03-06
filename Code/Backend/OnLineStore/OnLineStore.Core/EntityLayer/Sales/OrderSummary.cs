using System;

namespace OnLineStore.Core.EntityLayer.Sales
{
    public class OrderSummary : IEntity
    {
        public OrderSummary()
        {
        }

        public int? OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public string CustomerName { get; set; }

        public string EmployeeName { get; set; }

        public string ShipperName { get; set; }

        public int? OrderLines { get; set; }
    }
}
