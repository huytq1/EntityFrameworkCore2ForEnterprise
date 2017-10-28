using System;
using System.Collections.ObjectModel;
using Store.Core.EntityLayer.Dbo;
using Store.Core.EntityLayer.HumanResources;

namespace Store.Core.EntityLayer.Sales
{
    public class Order : IAuditEntity
    {
        public Order()
        {
        }

        public Order(Int64 orderID)
        {
            OrderID = orderID;
        }

        public Int64? OrderID { get; set; }

        public Int16? OrderStatusID { get; set; }

        public DateTime? OrderDate { get; set; }

        public Int32? CustomerID { get; set; }

        public Int32? EmployeeID { get; set; }

        public Int32? ShipperID { get; set; }

        public Decimal? Total { get; set; }

        public Int16? CurrencyID { get; set; }

        public Guid? PaymentMethodID { get; set; }

        public String Comments { get; set; }

        public String CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public String LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public Byte[] Timestamp { get; set; }

        public virtual OrderStatus OrderStatusFk { get; set; }

        public virtual Customer CustomerFk { get; set; }

        public virtual Employee EmployeeFk { get; set; }

        public virtual Shipper ShipperFk { get; set; }

        public virtual Currency CurrencyFk { get; set; }

        public virtual PaymentMethod PaymentMethodFk { get; set; }

        public virtual Collection<OrderDetail> OrderDetails { get; set; } = new Collection<OrderDetail>();
    }
}
