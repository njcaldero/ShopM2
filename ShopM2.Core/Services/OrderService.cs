using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System.Collections.Generic;

namespace ShopM2.Core.Services
{
    public class OrderService : IOrderService
    {
        /// <summary>
        /// interface that returns the list of orders
        /// </summary>
        /// <returns>Task<List<Product>></returns>
        List<Order> GetAll();
    }
}
