using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Services
{
    public class OrderDetailService : IOrderDetailService
    {
     //   private readonly IOrderDetailRepository orderDetailRepository;

        

        OrderDetail IOrderDetailService.GetByIdOrder(int idOrder)
        {
            return null;// orderDetailRepository.GetByIdOrder(idOrder);
        }

        OrderDetail IOrderDetailService.Insert(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
