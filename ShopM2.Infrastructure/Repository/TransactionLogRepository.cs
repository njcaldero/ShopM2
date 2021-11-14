using AutoMapper;
using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using ShopM2.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionLog = ShopM2.Infrastructure.Data.TransactionLog;

namespace ShopM2.Infrastructure.Repository
{
    public class TransactionLogRepository : BaseRepository<Data.TransactionLog>, ITransactionLogRepository
    {
        DbSet<TransactionLog> entities;

        private readonly IMapper mapper;

        public TransactionLogRepository(SHOP_M2Entities context, IMapper _mapper) : base(context)
        {
            entities = context.Set<Data.TransactionLog>();
            mapper = _mapper;
        }
      

        Core.Entities.TransactionLog ITransactionLogRepository.Insert(Core.Entities.TransactionLog transactionLog)
        {
            TransactionLog entity = mapper.Map<TransactionLog>(transactionLog);
            TransactionLog result = entities.Add(entity);
            this.Save();
            if (result != null && result.Id > 0)
            {
                Core.Entities.TransactionLog orderNew = mapper.Map<Core.Entities.TransactionLog>(result);
                return orderNew;
            }
            else return null;
        }

        Core.Entities.TransactionLog ITransactionLogRepository.GetByIdOrder(int idOrder)
        {
            TransactionLog result = entities.Where(x => x.IdOrder == idOrder).OrderByDescending(x=>x.Id).SingleOrDefault();

            if (result != null && result.Id > 0)
            {
                Core.Entities.TransactionLog orderNew = mapper.Map<Core.Entities.TransactionLog>(result);
                return orderNew;
            }
            else return null;
        }
    }
}
