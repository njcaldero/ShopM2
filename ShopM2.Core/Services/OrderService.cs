using ShopM2.Core.Dto;
using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace ShopM2.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly ICustomerService customerService;
        //private readonly IOrderDetailService orderDetailService;

        public OrderService(IOrderRepository _orderRepository, ICustomerService _customerService)
        {
            orderRepository = _orderRepository;
            customerService = _customerService;
           // orderDetailService = _orderDetailService;
        }

        /// <summary>
        /// service that returns the order created
        /// </summary>
        /// <param name="order">Order</param>
        /// <returns>Order</returns>
        Order IOrderService.Create(Order order)
        {

            Customer customer = customerService.SelectByEmail(order.Customer.Email);

            if (customer != null)
            {
                order.IdCustomer = customer.Id;
                order.Customer = null;
            }

         return orderRepository.Insert(order);
    
        }

        /// <summary>
        /// service that returns the list of Orders
        /// </summary>
        /// <returns></returns>
        List<Order> IOrderService.GetAll()
        {
            return orderRepository.GetAll();
        }

        /// <summary>
        /// service that returns the order by id
        /// </summary>
        /// <param name="idOrder">int idOrder</param>
        /// <returns>Order</returns>
        Order IOrderService.GetById(int idOrder)
        {
            return orderRepository.GetById(idOrder);
        }

        bool IOrderService.PayOrder(int idOrder)
        {
            throw new NotImplementedException();
        }
    }
}
