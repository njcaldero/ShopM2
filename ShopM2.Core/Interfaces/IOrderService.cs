using ShopM2.Core.Dto;
using ShopM2.Core.Entities;
using System.Collections.Generic;

namespace ShopM2.Core.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetAll();

        Order Create(Order order);

        Order GetById(int idOrder);

        string PayOrder(int idOrder);

        Order CheckPayment(int idOrder);

        Order Update(Order order);
    }
}