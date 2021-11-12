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
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        DbSet<Data.Product> entities;

        private readonly IMapper mapper;

        public ProductRepository(SHOP_M2Entities context, IMapper _mapper) : base(context)
        {
            entities = context.Set<Product>();
            mapper = _mapper;
        }

        List<Core.Entities.Product> IProductRepository.GetAll()
        {
            var entityList = entities.ToList();
           
            var listProduct = mapper.Map<List<Core.Entities.Product>>(entityList);

            return listProduct;
        }
    }
}
