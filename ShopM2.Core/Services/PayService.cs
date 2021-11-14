using ShopM2.Core.Dto;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Services
{
    public class PayService : IPayService
    {
        IPayRepository payRepository;

        public PayService(IPayRepository _payRepository)
        {
            payRepository = _payRepository;
        }

        OutPutPayDto IPayService.CheckPayment(InputPayDto inputPayDto)
        {
            return payRepository.CheckPayment(inputPayDto);
        }

        OutPutPayDto IPayService.PayOrder(InputPayDto inputPayDto)
        {
            return payRepository.PayOrder(inputPayDto);
        }
    }
}
