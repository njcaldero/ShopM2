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
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        DbSet<Data.Order> entities;

        private readonly IMapper mapper;

        public OrderRepository(SHOP_M2Entities context, IMapper _mapper) : base(context)
        {
            entities = context.Set<Order>();
            mapper = _mapper;
        }

        List<Core.Entities.Order> IOrderRepository.GetAll()
        {
            var entityList = entities.ToList();

            var list = mapper.Map<List<Core.Entities.Order>>(entityList);

            return list;
        }

        Core.Entities.Order IOrderRepository.Insert(Core.Entities.Order order)
        {
            Order entity = mapper.Map<Order>(order);
            Order result = entities.Add(entity);
            this.Save();
            if (result != null && result.Id > 0)
            {
                Core.Entities.Order orderNew = mapper.Map<Core.Entities.Order>(result);
                return orderNew;
            }
            else return null;
        }

    }
}
