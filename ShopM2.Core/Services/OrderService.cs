using ShopM2.Core.Dto;
using ShopM2.Core.Entities;
using ShopM2.Core.Enumerators;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace ShopM2.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        private readonly ICustomerService customerService;
        private readonly IPayService payService;
        private readonly ITransactionLogService transactionLogService;

        public OrderService(IOrderRepository _orderRepository, ICustomerService _customerService, IPayService _payService, ITransactionLogService _transactionLogService)
        {
            orderRepository = _orderRepository;
            customerService = _customerService;
            payService = _payService;
            transactionLogService = _transactionLogService;
        }

        /// <summary>
        /// check payment
        /// </summary>
        /// <param name="idOrder">int idOrder</param>
        /// <returns></returns>
        Order IOrderService.CheckPayment(int idOrder)
        {
            TransactionLog transactionLog = transactionLogService.GetByIdOrder(idOrder);
            if (transactionLog != null)
            {
                OutPutPayDto outPutPayDto = payService.CheckPayment(new InputPayDto() { reference = transactionLog.IdRequest });

                if (outPutPayDto != null && (outPutPayDto.status.Equals(PaymentStatus.ST_APPROVED) || outPutPayDto.status.Equals(PaymentStatus.ST_REJECTED)))
                {
                    Order order = orderRepository.GetById(idOrder);
                    order.Updated_at = DateTime.Now;
                    order.IdStatus = outPutPayDto.status.Equals(PaymentStatus.ST_APPROVED) ? (int)Status.Payed : (int)Status.Reject;
                    orderRepository.Update(order);
                    return order;
                }
            }
            return null;
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
        /// <returns>List<Order></returns>
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

        string IOrderService.PayOrder(int idOrder)
        {
            Order order = orderRepository.GetById(idOrder);
            InputPayDto inputPayDto = new InputPayDto()
            {
                amount = order.OrderDetails[0].TotalPrice,
                reference = order.Id.ToString()
            };

            OutPutPayDto outPutPayDto = payService.PayOrder(inputPayDto);

            if (outPutPayDto != null)
            {
                TransactionLog transactionLog = new TransactionLog()
                {
                    IdOrder = idOrder,
                    IdRequest = outPutPayDto.requestId,
                    ResponseTransaction = outPutPayDto.responseTrx
                };

                transactionLogService.Insert(transactionLog);

                return outPutPayDto.processUrl;
            }
            return null;
        }

        Order IOrderService.Update(Order order)
        {
            return orderRepository.Update(order);
        }
    }
}
