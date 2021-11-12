using System;
using System.Collections.Generic;

namespace ShopM2.Core.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public int IdStatus { get; set; }
        public System.DateTime Created_at { get; set; }
        public Nullable<System.DateTime> Updated_at { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
