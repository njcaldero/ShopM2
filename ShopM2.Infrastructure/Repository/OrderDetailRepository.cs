
using AutoMapper;
using ShopM2.Core.Interfaces;
using ShopM2.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Infrastructure.Repository
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        DbSet<OrderDetail> entities;

        private readonly IMapper mapper;

        public OrderDetailRepository(SHOP_M2Entities context, IMapper _mapper) : base(context)
        {
            entities = context.Set<OrderDetail>();
            mapper = _mapper;
        }

        Core.Entities.OrderDetail IOrderDetailRepository.GetByIdOrder(int idOrder)
        {
            var entity = entities.SingleOrDefault(x => x.IdOrder == idOrder);

            var entityDB = mapper.Map<Core.Entities.OrderDetail>(entity);

            return entityDB;
        }

        Core.Entities.OrderDetail IOrderDetailRepository.Insert(Core.Entities.OrderDetail orderDetail)
        {
            OrderDetail entity = mapper.Map<OrderDetail>(orderDetail);
            OrderDetail result = entities.Add(entity);
            this.Save();
            if (result != null && result.Id > 0)
            {
                Core.Entities.OrderDetail orderNew = mapper.Map<Core.Entities.OrderDetail>(result);
                return orderNew;
            }
            else return null;
        }

    }
}
