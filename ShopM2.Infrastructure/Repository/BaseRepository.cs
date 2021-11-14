using AutoMapper;
using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using ShopM2.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ShopM2.Infrastructure.Repository
{

    public class BaseRepository<T>
    {
        private readonly SHOP_M2Entities context;

        public BaseRepository(SHOP_M2Entities _context)
        {
            context = _context;
            
        }
        public void Save()
        {
            context.SaveChanges();
        }

        public void Entry<TEntity>(TEntity entity)
        {
           context.Entry(entity).State = EntityState.Modified;  
        }

   


    }

}
