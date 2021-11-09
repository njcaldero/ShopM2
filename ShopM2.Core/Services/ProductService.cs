using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        /// <summary>
        /// service that returns the list of products
        /// </summary>
        /// <returns></returns>
        List<Product> IProductService.GetAll()
        {
            return productRepository.GetAll();
        }
    }
}
