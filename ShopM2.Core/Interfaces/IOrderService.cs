using ShopM2.Core.Entities;
using System.Collections.Generic;

namespace ShopM2.Core.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetAll();
    }
}