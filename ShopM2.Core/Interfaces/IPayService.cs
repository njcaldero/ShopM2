using ShopM2.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Interfaces
{
    public interface IPayService
    {
        OutPutPayDto PayOrder(InputPayDto inputPayDto);

        OutPutPayDto CheckPayment(InputPayDto order);
    }
}
