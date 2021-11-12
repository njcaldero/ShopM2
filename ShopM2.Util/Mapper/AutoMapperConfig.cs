using AutoMapper;
using ShopM2.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Util.Mapper
{
    public static class AutoMapperConfig
    {
        public static MapperConfiguration Initialize()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, Core.Entities.Product>();
                cfg.CreateMap<Order, Core.Entities.Order>().ReverseMap();
                cfg.CreateMap<Customer, Core.Entities.Customer>().ReverseMap();
                cfg.CreateMap<OrderDetail, Core.Entities.OrderDetail>().ReverseMap();
            });
            return configuration;
        }
    }
}
