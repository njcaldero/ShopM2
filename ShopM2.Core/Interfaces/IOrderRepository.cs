using ShopM2.Core.Entities;
using System.Collections.Generic;

namespace ShopM2.Core.Interfaces
{
    public class IOrderRepository
    {
        List<Order> GetAll();
    }
}
