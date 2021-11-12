using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System.Collections.Generic;

namespace ShopM2.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository OrderRepository;

        public OrderService(IOrderRepository _OrderRepository)
        {
            OrderRepository = _OrderRepository;
        }

        /// <summary>
        /// service that returns the order created
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Order</returns>
        Order IOrderService.Create(Order order)
        {
            return OrderRepository.Insert(order);
        }

        /// <summary>
        /// service that returns the list of Orders
        /// </summary>
        /// <returns></returns>
        List<Order> IOrderService.GetAll()
        {
            return OrderRepository.GetAll();
        }
    }
}
