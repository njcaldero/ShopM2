using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopM2.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpPost]
        public List<Product> GetAll()
        {
            try
            {
                return productService.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.ToString());
            }
        }

        [HttpGet]
        public string GetAllTest()
        {
            try
            {
                return productService.GetAll().Count().ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
               return ex.ToString();
            }
        }

    }
}