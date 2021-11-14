using ShopM2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Interfaces
{
  public  interface ITransactionLogService
    {
        TransactionLog Insert(TransactionLog transactionLog);

        TransactionLog GetByIdOrder(int IdOrder);
    }
}
