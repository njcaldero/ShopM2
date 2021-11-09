using ShopM2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Interfaces
{
    public interface IProductService
    {
        /// <summary>
        /// interface that returns the list of products
        /// </summary>
        /// <returns>Task<List<Product>></returns>
        List<Product> GetAll();
    }
}
