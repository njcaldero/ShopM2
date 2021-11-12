using ShopM2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Dto
{
    public class OrderDto
    {
        public Order order;
        public Customer customer;
        public OrderDetail OrderDetail;
    }
}
