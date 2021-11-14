using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Services
{
    public class TransactionLogService : ITransactionLogService
    {
        ITransactionLogRepository transactionLogRepository;

        public TransactionLogService(ITransactionLogRepository _transactionLogRepository)
        {
            transactionLogRepository = _transactionLogRepository;
        }

        TransactionLog ITransactionLogService.GetByIdOrder(int idOrder)
        {
            return transactionLogRepository.GetByIdOrder(idOrder);
        }

        TransactionLog ITransactionLogService.Insert(TransactionLog transactionLog)
        {
            return transactionLogRepository.Insert(transactionLog);
        }
    }
}
