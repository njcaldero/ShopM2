using ShopM2.Core.Dto;
using ShopM2.Core.Entities;
using System.Collections.Generic;

namespace ShopM2.Core.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> GetAll();

        Order Insert(Order order);
    }
}
