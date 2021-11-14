using ShopM2.Core.Dto;
using ShopM2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Interfaces
{
   public interface IPayRepository
    {
        OutPutPayDto PayOrder(InputPayDto order);

        OutPutPayDto CheckPayment(InputPayDto order);
    }
}
